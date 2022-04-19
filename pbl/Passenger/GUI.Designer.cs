namespace pbl
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_User = new System.Windows.Forms.Panel();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.panel_Other = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.pSetting = new System.Windows.Forms.PictureBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.pFeedback = new System.Windows.Forms.PictureBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.pHelp = new System.Windows.Forms.PictureBox();
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.pNotify = new System.Windows.Forms.PictureBox();
            this.pArrow = new System.Windows.Forms.PictureBox();
            this.pOther = new System.Windows.Forms.PictureBox();
            this.pTicket = new System.Windows.Forms.PictureBox();
            this.pChat = new System.Windows.Forms.PictureBox();
            this.pSchedule = new System.Windows.Forms.PictureBox();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel_Content.SuspendLayout();
            this.panel_User.SuspendLayout();
            this.panel_Other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFeedback)).BeginInit();
            this.panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHelp)).BeginInit();
            this.panelFeedback.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Controls.Add(this.panel_User);
            this.panel_Content.Controls.Add(this.panel_Other);
            this.panel_Content.Location = new System.Drawing.Point(2, 61);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1096, 689);
            this.panel_Content.TabIndex = 0;
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_User.Controls.Add(this.labelLogOut);
            this.panel_User.Controls.Add(this.labelPersonal);
            this.panel_User.Location = new System.Drawing.Point(851, 3);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(245, 316);
            this.panel_User.TabIndex = 5;
            // 
            // labelLogOut
            // 
            this.labelLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.Location = new System.Drawing.Point(3, 51);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(239, 49);
            this.labelLogOut.TabIndex = 13;
            this.labelLogOut.Text = "Đăng xuất";
            this.labelLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // labelPersonal
            // 
            this.labelPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonal.Location = new System.Drawing.Point(3, 2);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(239, 49);
            this.labelPersonal.TabIndex = 12;
            this.labelPersonal.Text = "Hồ sơ cá nhân";
            this.labelPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPersonal.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // panel_Other
            // 
            this.panel_Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Other.Controls.Add(this.label5);
            this.panel_Other.Controls.Add(this.pictureBox12);
            this.panel_Other.Controls.Add(this.labelSetting);
            this.panel_Other.Controls.Add(this.labelFeedback);
            this.panel_Other.Controls.Add(this.labelHelp);
            this.panel_Other.Controls.Add(this.panelHelp);
            this.panel_Other.Controls.Add(this.panelFeedback);
            this.panel_Other.Controls.Add(this.panelSetting);
            this.panel_Other.Location = new System.Drawing.Point(0, 0);
            this.panel_Other.Name = "panel_Other";
            this.panel_Other.Size = new System.Drawing.Size(217, 686);
            this.panel_Other.TabIndex = 4;
            this.panel_Other.Visible = false;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(3, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đường sắt Việt Nam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(0, 41);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(214, 123);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // labelSetting
            // 
            this.labelSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetting.Location = new System.Drawing.Point(65, 525);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(151, 49);
            this.labelSetting.TabIndex = 10;
            this.labelSetting.Text = "Cài đặt";
            this.labelSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSetting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // pSetting
            // 
            this.pSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pSetting.Image = ((System.Drawing.Image)(resources.GetObject("pSetting.Image")));
            this.pSetting.Location = new System.Drawing.Point(9, 10);
            this.pSetting.Name = "pSetting";
            this.pSetting.Size = new System.Drawing.Size(47, 49);
            this.pSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSetting.TabIndex = 9;
            this.pSetting.TabStop = false;
            this.pSetting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // labelFeedback
            // 
            this.labelFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(66, 452);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(151, 49);
            this.labelFeedback.TabIndex = 8;
            this.labelFeedback.Text = "Phản hồi";
            this.labelFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFeedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // pFeedback
            // 
            this.pFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pFeedback.Image = ((System.Drawing.Image)(resources.GetObject("pFeedback.Image")));
            this.pFeedback.Location = new System.Drawing.Point(9, 10);
            this.pFeedback.Name = "pFeedback";
            this.pFeedback.Size = new System.Drawing.Size(47, 49);
            this.pFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pFeedback.TabIndex = 7;
            this.pFeedback.TabStop = false;
            this.pFeedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(65, 386);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(151, 49);
            this.labelHelp.TabIndex = 6;
            this.labelHelp.Text = "Hỗ trợ";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.pHelp);
            this.panelHelp.Location = new System.Drawing.Point(0, 377);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(214, 68);
            this.panelHelp.TabIndex = 6;
            // 
            // pHelp
            // 
            this.pHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pHelp.Image = ((System.Drawing.Image)(resources.GetObject("pHelp.Image")));
            this.pHelp.Location = new System.Drawing.Point(9, 10);
            this.pHelp.Name = "pHelp";
            this.pHelp.Size = new System.Drawing.Size(47, 49);
            this.pHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHelp.TabIndex = 3;
            this.pHelp.TabStop = false;
            this.pHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // panelFeedback
            // 
            this.panelFeedback.Controls.Add(this.pFeedback);
            this.panelFeedback.Location = new System.Drawing.Point(3, 442);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(214, 68);
            this.panelFeedback.TabIndex = 6;
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.pSetting);
            this.panelSetting.Location = new System.Drawing.Point(3, 516);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(214, 68);
            this.panelSetting.TabIndex = 7;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Title.Controls.Add(this.pNotify);
            this.panel_Title.Controls.Add(this.pArrow);
            this.panel_Title.Controls.Add(this.pOther);
            this.panel_Title.Controls.Add(this.pTicket);
            this.panel_Title.Controls.Add(this.pChat);
            this.panel_Title.Controls.Add(this.pSchedule);
            this.panel_Title.Controls.Add(this.pImage);
            this.panel_Title.Controls.Add(this.pHome);
            this.panel_Title.Controls.Add(this.labelName);
            this.panel_Title.Location = new System.Drawing.Point(2, 2);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1095, 61);
            this.panel_Title.TabIndex = 1;
            // 
            // pNotify
            // 
            this.pNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotify.Image = ((System.Drawing.Image)(resources.GetObject("pNotify.Image")));
            this.pNotify.Location = new System.Drawing.Point(619, 7);
            this.pNotify.Name = "pNotify";
            this.pNotify.Size = new System.Drawing.Size(47, 51);
            this.pNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pNotify.TabIndex = 4;
            this.pNotify.TabStop = false;
            this.pNotify.Click += new System.EventHandler(this.pNotify_Click);
            // 
            // pArrow
            // 
            this.pArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pArrow.Image = ((System.Drawing.Image)(resources.GetObject("pArrow.Image")));
            this.pArrow.Location = new System.Drawing.Point(1025, 5);
            this.pArrow.Name = "pArrow";
            this.pArrow.Size = new System.Drawing.Size(37, 51);
            this.pArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pArrow.TabIndex = 4;
            this.pArrow.TabStop = false;
            this.pArrow.Click += new System.EventHandler(this.pArrow_Click);
            // 
            // pOther
            // 
            this.pOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pOther.Image = ((System.Drawing.Image)(resources.GetObject("pOther.Image")));
            this.pOther.Location = new System.Drawing.Point(3, 7);
            this.pOther.Name = "pOther";
            this.pOther.Size = new System.Drawing.Size(47, 51);
            this.pOther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOther.TabIndex = 3;
            this.pOther.TabStop = false;
            this.pOther.Click += new System.EventHandler(this.pOther_Click);
            // 
            // pTicket
            // 
            this.pTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTicket.Image = ((System.Drawing.Image)(resources.GetObject("pTicket.Image")));
            this.pTicket.Location = new System.Drawing.Point(403, 7);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(47, 51);
            this.pTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTicket.TabIndex = 3;
            this.pTicket.TabStop = false;
            this.pTicket.Click += new System.EventHandler(this.pTicket_Click);
            // 
            // pChat
            // 
            this.pChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pChat.Image = ((System.Drawing.Image)(resources.GetObject("pChat.Image")));
            this.pChat.Location = new System.Drawing.Point(295, 7);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(47, 51);
            this.pChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pChat.TabIndex = 3;
            this.pChat.TabStop = false;
            this.pChat.Click += new System.EventHandler(this.pChat_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pSchedule.Image")));
            this.pSchedule.Location = new System.Drawing.Point(510, 7);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(47, 51);
            this.pSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSchedule.TabIndex = 4;
            this.pSchedule.TabStop = false;
            this.pSchedule.Click += new System.EventHandler(this.pSchedule_Click);
            // 
            // pImage
            // 
            this.pImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pImage.Image = ((System.Drawing.Image)(resources.GetObject("pImage.Image")));
            this.pImage.Location = new System.Drawing.Point(981, 5);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(47, 51);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pImage.TabIndex = 2;
            this.pImage.TabStop = false;
            this.pImage.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.Color.Green;
            this.pHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHome.Image = ((System.Drawing.Image)(resources.GetObject("pHome.Image")));
            this.pHome.Location = new System.Drawing.Point(186, 7);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(47, 51);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // labelName
            // 
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(672, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(356, 49);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nguyễn Thế Đăng Hoan";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 752);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Content);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đường sắt Việt Nam";
            this.panel_Content.ResumeLayout(false);
            this.panel_User.ResumeLayout(false);
            this.panel_Other.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFeedback)).EndInit();
            this.panelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHelp)).EndInit();
            this.panelFeedback.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.PictureBox pHelp;
        private System.Windows.Forms.PictureBox pOther;
        private System.Windows.Forms.PictureBox pTicket;
        private System.Windows.Forms.PictureBox pChat;
        private System.Windows.Forms.PictureBox pSchedule;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.PictureBox pNotify;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pArrow;
        private System.Windows.Forms.Panel panel_Other;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.PictureBox pSetting;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.PictureBox pFeedback;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Panel panelFeedback;
        private System.Windows.Forms.Panel panelSetting;
    }
}