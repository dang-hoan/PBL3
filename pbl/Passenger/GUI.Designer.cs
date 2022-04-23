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
            this.bSetting = new System.Windows.Forms.Button();
            this.bFeedback = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
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
            this.panel_Content.Location = new System.Drawing.Point(2, 49);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(974, 551);
            this.panel_Content.TabIndex = 0;
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_User.Controls.Add(this.labelLogOut);
            this.panel_User.Controls.Add(this.labelPersonal);
            this.panel_User.Location = new System.Drawing.Point(756, 2);
            this.panel_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(218, 253);
            this.panel_User.TabIndex = 5;
            this.panel_User.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_User_Paint);
            // 
            // labelLogOut
            // 
            this.labelLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.Location = new System.Drawing.Point(3, 41);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(213, 40);
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
            this.labelPersonal.Size = new System.Drawing.Size(213, 40);
            this.labelPersonal.TabIndex = 12;
            this.labelPersonal.Text = "Hồ sơ cá nhân";
            this.labelPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPersonal.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // panel_Other
            // 
            this.panel_Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Other.Controls.Add(this.bSetting);
            this.panel_Other.Controls.Add(this.bFeedback);
            this.panel_Other.Controls.Add(this.bHelp);
            this.panel_Other.Controls.Add(this.label5);
            this.panel_Other.Controls.Add(this.pictureBox12);
            this.panel_Other.Location = new System.Drawing.Point(0, 0);
            this.panel_Other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Other.Name = "panel_Other";
            this.panel_Other.Size = new System.Drawing.Size(193, 549);
            this.panel_Other.TabIndex = 4;
            this.panel_Other.Visible = false;
            // 
            // bSetting
            // 
            this.bSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bSetting.FlatAppearance.BorderSize = 0;
            this.bSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSetting.ForeColor = System.Drawing.Color.Black;
            this.bSetting.Image = ((System.Drawing.Image)(resources.GetObject("bSetting.Image")));
            this.bSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSetting.Location = new System.Drawing.Point(0, 404);
            this.bSetting.Margin = new System.Windows.Forms.Padding(0);
            this.bSetting.Name = "bSetting";
            this.bSetting.Size = new System.Drawing.Size(193, 50);
            this.bSetting.TabIndex = 13;
            this.bSetting.Text = " Cài đặt";
            this.bSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bSetting.UseVisualStyleBackColor = false;
            this.bSetting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // bFeedback
            // 
            this.bFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFeedback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bFeedback.FlatAppearance.BorderSize = 0;
            this.bFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFeedback.ForeColor = System.Drawing.Color.Black;
            this.bFeedback.Image = ((System.Drawing.Image)(resources.GetObject("bFeedback.Image")));
            this.bFeedback.Location = new System.Drawing.Point(0, 356);
            this.bFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.bFeedback.Name = "bFeedback";
            this.bFeedback.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.bFeedback.Size = new System.Drawing.Size(193, 50);
            this.bFeedback.TabIndex = 12;
            this.bFeedback.Text = " Phản hồi";
            this.bFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bFeedback.UseVisualStyleBackColor = false;
            this.bFeedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // bHelp
            // 
            this.bHelp.AutoSize = true;
            this.bHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bHelp.FlatAppearance.BorderSize = 0;
            this.bHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHelp.ForeColor = System.Drawing.Color.Black;
            this.bHelp.Image = ((System.Drawing.Image)(resources.GetObject("bHelp.Image")));
            this.bHelp.Location = new System.Drawing.Point(0, 308);
            this.bHelp.Margin = new System.Windows.Forms.Padding(0);
            this.bHelp.Name = "bHelp";
            this.bHelp.Padding = new System.Windows.Forms.Padding(0, 0, 53, 0);
            this.bHelp.Size = new System.Drawing.Size(193, 50);
            this.bHelp.TabIndex = 6;
            this.bHelp.Text = " Hỗ trợ";
            this.bHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bHelp.UseVisualStyleBackColor = false;
            this.bHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đường sắt Việt Nam";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(0, 33);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(190, 98);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
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
            this.panel_Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(973, 49);
            this.panel_Title.TabIndex = 1;
            // 
            // pNotify
            // 
            this.pNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotify.Image = ((System.Drawing.Image)(resources.GetObject("pNotify.Image")));
            this.pNotify.Location = new System.Drawing.Point(550, 0);
            this.pNotify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pNotify.Name = "pNotify";
            this.pNotify.Size = new System.Drawing.Size(42, 46);
            this.pNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pNotify.TabIndex = 4;
            this.pNotify.TabStop = false;
            this.pNotify.Click += new System.EventHandler(this.pNotify_Click);
            // 
            // pArrow
            // 
            this.pArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pArrow.Image = ((System.Drawing.Image)(resources.GetObject("pArrow.Image")));
            this.pArrow.Location = new System.Drawing.Point(911, 0);
            this.pArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pArrow.Name = "pArrow";
            this.pArrow.Size = new System.Drawing.Size(33, 49);
            this.pArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pArrow.TabIndex = 4;
            this.pArrow.TabStop = false;
            this.pArrow.Click += new System.EventHandler(this.pArrow_Click);
            // 
            // pOther
            // 
            this.pOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pOther.Image = ((System.Drawing.Image)(resources.GetObject("pOther.Image")));
            this.pOther.Location = new System.Drawing.Point(3, 0);
            this.pOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pOther.Name = "pOther";
            this.pOther.Size = new System.Drawing.Size(42, 46);
            this.pOther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOther.TabIndex = 3;
            this.pOther.TabStop = false;
            this.pOther.Click += new System.EventHandler(this.pOther_Click);
            // 
            // pTicket
            // 
            this.pTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTicket.Image = ((System.Drawing.Image)(resources.GetObject("pTicket.Image")));
            this.pTicket.Location = new System.Drawing.Point(358, 0);
            this.pTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(42, 46);
            this.pTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTicket.TabIndex = 3;
            this.pTicket.TabStop = false;
            this.pTicket.Click += new System.EventHandler(this.pTicket_Click);
            // 
            // pChat
            // 
            this.pChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pChat.Image = ((System.Drawing.Image)(resources.GetObject("pChat.Image")));
            this.pChat.Location = new System.Drawing.Point(262, 0);
            this.pChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(42, 46);
            this.pChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pChat.TabIndex = 3;
            this.pChat.TabStop = false;
            this.pChat.Click += new System.EventHandler(this.pChat_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pSchedule.Image")));
            this.pSchedule.Location = new System.Drawing.Point(453, 0);
            this.pSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(42, 46);
            this.pSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSchedule.TabIndex = 4;
            this.pSchedule.TabStop = false;
            this.pSchedule.Click += new System.EventHandler(this.pSchedule_Click);
            // 
            // pImage
            // 
            this.pImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pImage.Image = ((System.Drawing.Image)(resources.GetObject("pImage.Image")));
            this.pImage.Location = new System.Drawing.Point(872, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(42, 49);
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
            this.pHome.Location = new System.Drawing.Point(165, 0);
            this.pHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(42, 46);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // labelName
            // 
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(598, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(316, 49);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nguyễn Thế Đăng Hoan";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 602);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Content);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đường sắt Việt Nam";
            this.panel_Content.ResumeLayout(false);
            this.panel_User.ResumeLayout(false);
            this.panel_Other.ResumeLayout(false);
            this.panel_Other.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
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
        private System.Windows.Forms.PictureBox pOther;
        private System.Windows.Forms.PictureBox pTicket;
        private System.Windows.Forms.PictureBox pChat;
        private System.Windows.Forms.PictureBox pSchedule;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.PictureBox pNotify;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pArrow;
        private System.Windows.Forms.Panel panel_Other;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bSetting;
        private System.Windows.Forms.Button bFeedback;
    }
}