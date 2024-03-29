﻿namespace pbl.View
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.pArrow = new System.Windows.Forms.PictureBox();
            this.pTicket = new System.Windows.Forms.PictureBox();
            this.pSchedule = new System.Windows.Forms.PictureBox();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel_Content.SuspendLayout();
            this.panel_User.SuspendLayout();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Controls.Add(this.panel_User);
            this.panel_Content.Location = new System.Drawing.Point(2, 61);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1096, 689);
            this.panel_Content.TabIndex = 0;
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_User.Controls.Add(this.labelLogOut);
            this.panel_User.Controls.Add(this.labelPersonal);
            this.panel_User.Location = new System.Drawing.Point(848, 2);
            this.panel_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(245, 104);
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
            this.labelLogOut.Size = new System.Drawing.Size(239, 50);
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
            this.labelPersonal.Size = new System.Drawing.Size(239, 50);
            this.labelPersonal.TabIndex = 12;
            this.labelPersonal.Text = "Hồ sơ cá nhân";
            this.labelPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPersonal.Click += new System.EventHandler(this.CallInfoForm);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Title.Controls.Add(this.pArrow);
            this.panel_Title.Controls.Add(this.pTicket);
            this.panel_Title.Controls.Add(this.pSchedule);
            this.panel_Title.Controls.Add(this.pImage);
            this.panel_Title.Controls.Add(this.pHome);
            this.panel_Title.Controls.Add(this.labelName);
            this.panel_Title.Location = new System.Drawing.Point(2, 2);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1095, 61);
            this.panel_Title.TabIndex = 1;
            // 
            // pArrow
            // 
            this.pArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pArrow.Image = ((System.Drawing.Image)(resources.GetObject("pArrow.Image")));
            this.pArrow.Location = new System.Drawing.Point(1025, 0);
            this.pArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pArrow.Name = "pArrow";
            this.pArrow.Size = new System.Drawing.Size(37, 61);
            this.pArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pArrow.TabIndex = 4;
            this.pArrow.TabStop = false;
            this.pArrow.Click += new System.EventHandler(this.pArrow_Click);
            // 
            // pTicket
            // 
            this.pTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTicket.Image = ((System.Drawing.Image)(resources.GetObject("pTicket.Image")));
            this.pTicket.Location = new System.Drawing.Point(388, 3);
            this.pTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(47, 58);
            this.pTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTicket.TabIndex = 3;
            this.pTicket.TabStop = false;
            this.pTicket.Click += new System.EventHandler(this.pTicket_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pSchedule.Image")));
            this.pSchedule.Location = new System.Drawing.Point(550, 3);
            this.pSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(47, 58);
            this.pSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSchedule.TabIndex = 4;
            this.pSchedule.TabStop = false;
            this.pSchedule.Click += new System.EventHandler(this.pSchedule_Click);
            // 
            // pImage
            // 
            this.pImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pImage.Image = ((System.Drawing.Image)(resources.GetObject("pImage.Image")));
            this.pImage.Location = new System.Drawing.Point(981, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(47, 61);
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
            this.pHome.Location = new System.Drawing.Point(227, 3);
            this.pHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(47, 58);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // labelName
            // 
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(673, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(308, 61);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Tên khách hàng";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐƯỜNG SẮT VIỆT NAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_FormClosed);
            this.panel_Content.ResumeLayout(false);
            this.panel_User.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.PictureBox pTicket;
        private System.Windows.Forms.PictureBox pSchedule;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pArrow;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label labelPersonal;
    }
}