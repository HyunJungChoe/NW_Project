﻿namespace MultiChatClient {
    partial class ChatForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtTTS = new System.Windows.Forms.TextBox();
            this.lblTTS = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tblMainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.ColumnCount = 5;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMainLayout.Controls.Add(this.txtHistory, 0, 1);
            this.tblMainLayout.Controls.Add(this.txtTTS, 1, 2);
            this.tblMainLayout.Controls.Add(this.lblTTS, 0, 2);
            this.tblMainLayout.Controls.Add(this.lblAddress, 0, 0);
            this.tblMainLayout.Controls.Add(this.txtAddress, 1, 0);
            this.tblMainLayout.Controls.Add(this.btnConnect, 4, 0);
            this.tblMainLayout.Controls.Add(this.btnSend, 4, 2);
            this.tblMainLayout.Controls.Add(this.lblPortNumber, 2, 0);
            this.tblMainLayout.Controls.Add(this.txtID, 3, 0);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.Padding = new System.Windows.Forms.Padding(8);
            this.tblMainLayout.RowCount = 4;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainLayout.Size = new System.Drawing.Size(1092, 554);
            this.tblMainLayout.TabIndex = 2;
            this.tblMainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMainLayout_Paint);
            // 
            // txtHistory
            // 
            this.txtHistory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHistory.BackColor = System.Drawing.Color.White;
            this.tblMainLayout.SetColumnSpan(this.txtHistory, 5);
            this.txtHistory.Location = new System.Drawing.Point(12, 46);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(4, 3, 2, 3);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(1070, 442);
            this.txtHistory.TabIndex = 5;
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // txtTTS
            // 
            this.tblMainLayout.SetColumnSpan(this.txtTTS, 3);
            this.txtTTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTTS.Location = new System.Drawing.Point(112, 496);
            this.txtTTS.Margin = new System.Windows.Forms.Padding(4, 2, 3, 3);
            this.txtTTS.MaxLength = 260;
            this.txtTTS.Name = "txtTTS";
            this.txtTTS.Size = new System.Drawing.Size(869, 37);
            this.txtTTS.TabIndex = 7;
            // 
            // lblTTS
            // 
            this.lblTTS.AutoSize = true;
            this.lblTTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTTS.Location = new System.Drawing.Point(9, 495);
            this.lblTTS.Margin = new System.Windows.Forms.Padding(1);
            this.lblTTS.Name = "lblTTS";
            this.lblTTS.Size = new System.Drawing.Size(98, 30);
            this.lblTTS.TabIndex = 6;
            this.lblTTS.Text = "보낼 텍스트";
            this.lblTTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(9, 9);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 30);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "서버 주소";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(112, 10);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 2, 3, 3);
            this.txtAddress.MaxLength = 260;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(669, 37);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(985, 9);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 30);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.OnConnectToServer);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.Location = new System.Drawing.Point(985, 495);
            this.btnSend.Margin = new System.Windows.Forms.Padding(1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 30);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.OnSendData);
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortNumber.Location = new System.Drawing.Point(785, 9);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(1);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(98, 30);
            this.lblPortNumber.TabIndex = 2;
            this.lblPortNumber.Text = "ID";
            this.lblPortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtID.Location = new System.Drawing.Point(888, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 2, 3, 3);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 37);
            this.txtID.TabIndex = 3;
            // 
            // ChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1092, 554);
            this.Controls.Add(this.tblMainLayout);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ChatForm";
            this.Text = "Multi Chat Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.OnFormLoaded);
            this.tblMainLayout.ResumeLayout(false);
            this.tblMainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTTS;
        private System.Windows.Forms.Label lblTTS;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Button btnSend;
    }
}

