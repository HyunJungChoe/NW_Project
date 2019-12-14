using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;


namespace MultiChatClient
{
    public partial class ChatForm2 : Form

    {

        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;
        IPAddress thisAddress;
        string nameID;

        String[] word = new String[] { "한국성서대", "기말고사", "종강", "엄마", "미안","갓정현" , "리그오브레전드", "피파온라인", "브롤스타즈","끝"};

        int i = 1;
        int jum = 0;




        public ChatForm2()
        {
            InitializeComponent();

            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }

        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }
        void SendID()
        {
            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes("id:" + nameID);

            // 서버에 전송한다.
            mainSock.Send(bDts);

            // 연결 완료되었다는 메세지를 띄워준다.
            AppendText(txtHistory, "서버와 연결되었습니다.");
        }




        void Gamestart()
        {

            textBox1.ReadOnly = false;
            

            timer1.Start();
            
            label1.Text = word[0];
            textBox1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            
    

        }

        void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 데이터 수신을 끝낸다.
            int received = obj.WorkingSocket.EndReceive(ar);

            // 받은 데이터가 없으면(연결끊어짐) 끝낸다.
            if (received <= 0)
            {
                obj.WorkingSocket.Disconnect(false);
                obj.WorkingSocket.Close();
                return;
            }

            // 텍스트로 변환한다.
            string text = Encoding.UTF8.GetString(obj.Buffer);

            // : 기준으로 짜른다.
            // tokens[0] - 보낸 사람 ID
            // tokens[1] - 보낸 메세지
            string[] tokens = text.Split(':');
            if (tokens[0].Equals("id"))
            {// 새로 접속한 클라이언트가가 "id:자신의_ID" 전송함
                string id = tokens[1];
                AppendText(txtHistory, string.Format("[접속] ID : {0}", id));

                
            }
            if (tokens[0].Equals("JUM"))
            {

                string jum_id = tokens[1];
                string jum = tokens[2];
                string jum_listview = jum_id + ":" + jum;
                listView1.Items.Add(jum_listview);
            }
            else
            {
                string id = tokens[0];
                string msg = tokens[1];
                AppendText(txtHistory, string.Format("[받음]{0}: {1}", id, msg));
            }
            // 텍스트박스에 추가해준다.
            // 비동기식으로 작업하기 때문에 폼의 UI 스레드에서 작업을 해줘야 한다.
            // 따라서 대리자를 통해 처리한다.


            // 클라이언트에선 데이터를 전달해줄 필요가 없으므로 바로 수신 대기한다.
            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();

            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void OnSendData(object sender, EventArgs e)
        {
            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }

            // 보낼 텍스트
            string tts = txtTTS.Text.Trim();
            if (string.IsNullOrEmpty(tts))
            {
                MsgBoxHelper.Warn("텍스트가 입력되지 않았습니다!");
                txtTTS.Focus();
                return;
            }

            // ID 와 메세지를 담도록 만든다.

            // 문자열을 utf8 형식의 바이트로 변환한다.
            byte[] bDts = Encoding.UTF8.GetBytes(nameID + ':' + tts);

          //  byte[] bDts = new byte[4096];
            
            //AppendText(txtHistory, tts);

            // 서버에 전송한다.
            mainSock.Send(bDts);

            // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
            AppendText(txtHistory, string.Format("[보냄]{0}: {1}", nameID, tts));
            txtTTS.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnConnectToServer(object sender, EventArgs e)
        {
            if (mainSock.Connected)
            {
                MsgBoxHelper.Error("이미 연결되어 있습니다!");
                return;
            }

            int port = 15000;  //고정

            nameID = txtID.Text.Trim(); //ID
            if (string.IsNullOrEmpty(nameID))
            {
                MsgBoxHelper.Warn("ID가 입력되지 않았습니다!");
                txtID.Focus();
                return;
            }

            // 서버에 연결
            try
            {
                mainSock.Connect(txtAddress.Text, port);
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용: {0}", MessageBoxButtons.OK, ex.Message);
                return;
            }

            // 서버로 ID 전송
            SendID();

            // 연결 완료, 서버에서 데이터가 올 수 있으므로 수신 대기한다.
            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = mainSock;
            mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);

           


        }
    

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        if (mainSock != null)
        {
            mainSock.Disconnect(false);
            mainSock.Close();
        }

    }

        private void OnFormLoaded(object sender, EventArgs e)
        {
            if (thisAddress == null)
            {
                // 로컬호스트 주소를 사용한다.
                thisAddress = IPAddress.Loopback;
                txtAddress.Text = thisAddress.ToString();
            }
            else
            {
                thisAddress = IPAddress.Parse(txtAddress.Text);
            }

        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void userlist_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gamestart_Click(object sender, EventArgs e)
        {
            
            AppendText(txtHistory, string.Format("[게임이 시작되었습니다.]"));
            Gamestart();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            

                if (e.KeyCode == Keys.Enter)
                //엔터 칠때 실행
                {


                    if (textBox1.Text == label1.Text)
                    // 같은 단어를 쳤을 경우
                    {

                    
                    
                    //칸 비우기 
                       textBox1.Text = "";

                    //점수 더하기 
                        jum += 1;

                        label3.Text = Convert.ToString(jum);


                    }

                    else

                    {

                        textBox1.Text = "";

                    }

                }

            

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //3초마다 단어 변경하기
            //3초마다 단어 변경하기
            label1.Text = word[i];

            i += 1;

            if (i == 10)
            {
                timer1.Stop();
                MessageBox.Show("게임이 종료되었습니다.");
                textBox1.ReadOnly = true;

                string a = nameID + ":" + jum + "점";
                byte[] bDts = Encoding.UTF8.GetBytes("JUM:" + a);

                mainSock.Send(bDts);
                listView1.Items.Add(a);

            }

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
