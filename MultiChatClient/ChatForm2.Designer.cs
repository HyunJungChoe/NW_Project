namespace MultiChatClient
{
    partial class ChatForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.userlist = new System.Windows.Forms.TextBox();
            this.lblTTS = new System.Windows.Forms.Label();
            this.txtTTS = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gamestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoEllipsis = true;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 25);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 18);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "서버 주소";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 22);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(359, 28);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(535, 25);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(1);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(22, 18);
            this.lblPortNumber.TabIndex = 3;
            this.lblPortNumber.Text = "ID";
            this.lblPortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(562, 22);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 2, 3, 3);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(298, 28);
            this.txtID.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.Location = new System.Drawing.Point(893, 10);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 47);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.OnConnectToServer);
            // 
            // txtHistory
            // 
            this.txtHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHistory.BackColor = System.Drawing.Color.White;
            this.txtHistory.Location = new System.Drawing.Point(37, 71);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(4, 3, 2, 3);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(347, 408);
            this.txtHistory.TabIndex = 6;
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // userlist
            // 
            this.userlist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userlist.BackColor = System.Drawing.Color.White;
            this.userlist.Location = new System.Drawing.Point(953, 126);
            this.userlist.Margin = new System.Windows.Forms.Padding(4, 3, 2, 3);
            this.userlist.Multiline = true;
            this.userlist.Name = "userlist";
            this.userlist.ReadOnly = true;
            this.userlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userlist.Size = new System.Drawing.Size(190, 333);
            this.userlist.TabIndex = 7;
            this.userlist.TextChanged += new System.EventHandler(this.userlist_TextChanged);
            // 
            // lblTTS
            // 
            this.lblTTS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTTS.AutoSize = true;
            this.lblTTS.Location = new System.Drawing.Point(46, 511);
            this.lblTTS.Margin = new System.Windows.Forms.Padding(1);
            this.lblTTS.Name = "lblTTS";
            this.lblTTS.Size = new System.Drawing.Size(104, 18);
            this.lblTTS.TabIndex = 8;
            this.lblTTS.Text = "보낼 텍스트";
            this.lblTTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTTS
            // 
            this.txtTTS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTTS.Location = new System.Drawing.Point(155, 508);
            this.txtTTS.Margin = new System.Windows.Forms.Padding(4, 2, 3, 3);
            this.txtTTS.MaxLength = 260;
            this.txtTTS.Name = "txtTTS";
            this.txtTTS.Size = new System.Drawing.Size(850, 28);
            this.txtTTS.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(1028, 499);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 43);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.OnSendData);
            // 
            // gamestart
            // 
            this.gamestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamestart.Location = new System.Drawing.Point(1032, 11);
            this.gamestart.Margin = new System.Windows.Forms.Padding(1);
            this.gamestart.Name = "gamestart";
            this.gamestart.Size = new System.Drawing.Size(122, 47);
            this.gamestart.TabIndex = 11;
            this.gamestart.Text = "게임 시작";
            this.gamestart.UseVisualStyleBackColor = true;
            this.gamestart.Click += new System.EventHandler(this.gamestart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(507, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "여기에 단어가 나옵니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(573, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "점수 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 28);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(679, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1008, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "점수표";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(755, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "점수 입력";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChatForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamestart);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtTTS);
            this.Controls.Add(this.lblTTS);
            this.Controls.Add(this.userlist);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPortNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Name = "ChatForm2";
            this.Text = "ChatForm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.TextBox userlist;
        private System.Windows.Forms.Label lblTTS;
        private System.Windows.Forms.TextBox txtTTS;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button gamestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}