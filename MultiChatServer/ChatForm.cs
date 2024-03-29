﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace MultiChatServer {
    public partial class ChatForm : Form {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;
        IPAddress thisAddress;
        Dictionary<String, Socket> connectedClients ;
        int clientNum;
        public ChatForm() {
            InitializeComponent();
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
            connectedClients = new Dictionary<string, Socket>();
            clientNum = 0; //초기화
        }

        void AppendText(Control ctrl, string s) {
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }

        void OnFormLoaded(object sender, EventArgs e) {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());
            // 처음으로 발견되는 ipv4 주소를 사용한다.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    AppendText(txtHistory, addr.ToString());
                }
            }
        }
        void BeginStartServer(object sender, EventArgs e) {
            int port;
            if (!int.TryParse(txtPort.Text, out port)) { //문자열을 int port로 변환
                MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                txtPort.Focus();
                txtPort.SelectAll();
                return;
            } 

            thisAddress = IPAddress.Parse(txtAddress.Text);
            if (thisAddress == null)
            {// 로컬호스트 주소를 사용한다.                
                thisAddress = IPAddress.Loopback;
                txtAddress.Text = thisAddress.ToString();
            }

            // 서버에서 클라이언트의 연결 요청을 대기하기 위해
            // 소켓을 열어둔다.
            IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);
           
            AppendText(txtHistory, string.Format("서버 시작: @{0}", serverEP));
            // 비동기적으로 클라이언트의 연결 요청을 받는다.
            mainSock.BeginAccept(AcceptCallback, null);
        }


        void AcceptCallback(IAsyncResult ar) {
            // 클라이언트의 연결 요청을 수락한다.
            Socket client = mainSock.EndAccept(ar);

            // 또 다른 클라이언트의 연결을 대기한다.
            mainSock.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);// 4096 buffer size
            obj.WorkingSocket = client;

            AppendText(txtHistory, string.Format("클라이언트 접속 : @{0}", 
                client.RemoteEndPoint));

            // 클라이언트의 ID 데이터를 받는다.
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar) {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 데이터 수신을 끝낸다.
            int received = obj.WorkingSocket.EndReceive(ar);

            // 받은 데이터가 없으면(연결끊어짐) 끝낸다.
            if (received <= 0) {
                //AppendText(txtHistory, string.Format("클라이언트 접속해제?{0}", clientNum));

                if (clientNum > 0)
                {
                    foreach (KeyValuePair<string, Socket> clients in connectedClients)
                    {
                        if (obj.WorkingSocket == clients.Value)
                        {
                            string key = clients.Key;
                            try
                            {
                                connectedClients.Remove(key);
                            }
                            catch { }
                            break;
                        }
                    }
                }
                obj.WorkingSocket.Disconnect(false);
                obj.WorkingSocket.Close();
                clientNum--;
               // AppendText(txtHistory, string.Format("클라이언트 접속해제완료{0}", clientNum));

                return;
            }

            // 텍스트로 변환한다.
            string text = Encoding.UTF8.GetString(obj.Buffer);
            AppendText(txtHistory, text);
            

            // : 기준으로 짜른다.
            // tokens[0] - 보낸 사람 ID
            // tokens[1] - 보낸 메세지
            string[] tokens = text.Split(':');
            string id = null;
            if (tokens[0].Equals("JUM"))
            {
                
                string jum_id = tokens[1];
                string jum = tokens[2];
                byte[] bDts = Encoding.UTF8.GetBytes("JUM" + ':' + jum_id + ":" + jum);
                // 연결된 모든 클라이언트에게 전송한다.

            }
            if (tokens[0].Equals("id"))
            {
                clientNum++;
                id = tokens[1];
                AppendText(txtHistory, string.Format("[접속{0}]ID : {1}", clientNum,id));
                
                // 연결된 클라이언트 리스트에 추가해준다.
                connectedClients.Add(id, obj.WorkingSocket);
            }
            else
            {
                id = tokens[0];
                string msg = tokens[1];
                AppendText(txtHistory, string.Format("[받음]{0}: {1}", id, msg));
            }
            // 텍스트박스에 추가해준다.
            // 비동기식으로 작업하기 때문에 폼의 UI 스레드에서 작업을 해줘야 한다.
            // 따라서 대리자를 통해 처리한다.
            // AppendText(txtHistory, string.Format("[받음]{0}: {1}", id, msg));

            // 전체 클라이언트에게 데이터를 보낸다.
            sendAll(obj.WorkingSocket, obj.Buffer);


            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();
            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void sendAll(Socket except, byte[] buffer)
        {
            foreach (KeyValuePair<string, Socket> clients in connectedClients)
            {
                Socket socket = clients.Value;
                if (socket!= except)
                {
                    try { socket.Send(buffer); }
                    catch
                    {// 오류 발생하면 전송 취소하고 삭제
                        try { socket.Dispose(); } catch { }
                    }
                }
            }
        }
        void OnSendData(object sender, EventArgs e) {
            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound) {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }
            
            // 보낼 텍스트
            string tts = txtTTS.Text.Trim();
            if (string.IsNullOrEmpty(tts)) {
                MsgBoxHelper.Warn("텍스트가 입력되지 않았습니다!");
                txtTTS.Focus();
                return;
            }
            
            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes("Server" + ':' + tts);

            // 연결된 모든 클라이언트에게 전송한다.
            sendAll(null, bDts);

            // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
            AppendText(txtHistory, string.Format("[보냄]server: {0}", tts));
            txtTTS.Clear();
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                mainSock.Close();
            }
            catch { }
        }
    }
}