namespace pbl.View.Admin
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panelqllt = new System.Windows.Forms.Panel();
            this.btdelsche = new System.Windows.Forms.Button();
            this.btsearchsche = new System.Windows.Forms.Button();
            this.btaddsche = new System.Windows.Forms.Button();
            this.btqllt = new System.Windows.Forms.Button();
            this.panelqlnv = new System.Windows.Forms.Panel();
            this.btdelnv = new System.Windows.Forms.Button();
            this.btupdatenv = new System.Windows.Forms.Button();
            this.btaddnv = new System.Windows.Forms.Button();
            this.btqlnv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.panelqllt.SuspendLayout();
            this.panelqlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.Color.Cyan;
            this.panelmenu.Controls.Add(this.button11);
            this.panelmenu.Controls.Add(this.panelqllt);
            this.panelmenu.Controls.Add(this.btqllt);
            this.panelmenu.Controls.Add(this.panelqlnv);
            this.panelmenu.Controls.Add(this.btqlnv);
            this.panelmenu.Controls.Add(this.button1);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(330, 658);
            this.panelmenu.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 767);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(309, 71);
            this.button11.TabIndex = 8;
            this.button11.Text = "Tra cứu khách hàng";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panelqllt
            // 
            this.panelqllt.BackColor = System.Drawing.Color.Silver;
            this.panelqllt.Controls.Add(this.btdelsche);
            this.panelqllt.Controls.Add(this.btsearchsche);
            this.panelqllt.Controls.Add(this.btaddsche);
            this.panelqllt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelqllt.Location = new System.Drawing.Point(0, 559);
            this.panelqllt.Name = "panelqllt";
            this.panelqllt.Size = new System.Drawing.Size(309, 208);
            this.panelqllt.TabIndex = 7;
            // 
            // btdelsche
            // 
            this.btdelsche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btdelsche.Dock = System.Windows.Forms.DockStyle.Top;
            this.btdelsche.Location = new System.Drawing.Point(0, 133);
            this.btdelsche.Name = "btdelsche";
            this.btdelsche.Size = new System.Drawing.Size(309, 72);
            this.btdelsche.TabIndex = 2;
            this.btdelsche.Text = "Xóa lịch trình";
            this.btdelsche.UseVisualStyleBackColor = false;
            this.btdelsche.Click += new System.EventHandler(this.btdelsche_Click);
            // 
            // btsearchsche
            // 
            this.btsearchsche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btsearchsche.Dock = System.Windows.Forms.DockStyle.Top;
            this.btsearchsche.Location = new System.Drawing.Point(0, 66);
            this.btsearchsche.Name = "btsearchsche";
            this.btsearchsche.Size = new System.Drawing.Size(309, 67);
            this.btsearchsche.TabIndex = 1;
            this.btsearchsche.Text = "Tìm kiếm lịch trình";
            this.btsearchsche.UseVisualStyleBackColor = false;
            this.btsearchsche.Click += new System.EventHandler(this.btsearchsche_Click);
            // 
            // btaddsche
            // 
            this.btaddsche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btaddsche.Dock = System.Windows.Forms.DockStyle.Top;
            this.btaddsche.Location = new System.Drawing.Point(0, 0);
            this.btaddsche.Name = "btaddsche";
            this.btaddsche.Size = new System.Drawing.Size(309, 66);
            this.btaddsche.TabIndex = 0;
            this.btaddsche.Text = "Thêm lịch trình";
            this.btaddsche.UseVisualStyleBackColor = false;
            this.btaddsche.Click += new System.EventHandler(this.btaddsche_Click);
            // 
            // btqllt
            // 
            this.btqllt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btqllt.Image = ((System.Drawing.Image)(resources.GetObject("btqllt.Image")));
            this.btqllt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btqllt.Location = new System.Drawing.Point(0, 487);
            this.btqllt.Name = "btqllt";
            this.btqllt.Size = new System.Drawing.Size(309, 72);
            this.btqllt.TabIndex = 6;
            this.btqllt.Text = "Quản lí lịch trình";
            this.btqllt.UseVisualStyleBackColor = true;
            this.btqllt.Click += new System.EventHandler(this.btqllt_Click);
            // 
            // panelqlnv
            // 
            this.panelqlnv.BackColor = System.Drawing.Color.Silver;
            this.panelqlnv.Controls.Add(this.btdelnv);
            this.panelqlnv.Controls.Add(this.btupdatenv);
            this.panelqlnv.Controls.Add(this.btaddnv);
            this.panelqlnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelqlnv.Location = new System.Drawing.Point(0, 282);
            this.panelqlnv.Name = "panelqlnv";
            this.panelqlnv.Size = new System.Drawing.Size(309, 205);
            this.panelqlnv.TabIndex = 5;
            // 
            // btdelnv
            // 
            this.btdelnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btdelnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btdelnv.Image = ((System.Drawing.Image)(resources.GetObject("btdelnv.Image")));
            this.btdelnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelnv.Location = new System.Drawing.Point(0, 137);
            this.btdelnv.Name = "btdelnv";
            this.btdelnv.Size = new System.Drawing.Size(309, 68);
            this.btdelnv.TabIndex = 4;
            this.btdelnv.Text = "Xóa nhân viên";
            this.btdelnv.UseVisualStyleBackColor = false;
            this.btdelnv.Click += new System.EventHandler(this.btdelnv_Click);
            // 
            // btupdatenv
            // 
            this.btupdatenv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btupdatenv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btupdatenv.Image = ((System.Drawing.Image)(resources.GetObject("btupdatenv.Image")));
            this.btupdatenv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btupdatenv.Location = new System.Drawing.Point(0, 67);
            this.btupdatenv.Name = "btupdatenv";
            this.btupdatenv.Size = new System.Drawing.Size(309, 70);
            this.btupdatenv.TabIndex = 5;
            this.btupdatenv.Text = "Chỉnh sửa thông tin";
            this.btupdatenv.UseVisualStyleBackColor = false;
            this.btupdatenv.Click += new System.EventHandler(this.btupdatenv_Click);
            // 
            // btaddnv
            // 
            this.btaddnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btaddnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btaddnv.Image = ((System.Drawing.Image)(resources.GetObject("btaddnv.Image")));
            this.btaddnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btaddnv.Location = new System.Drawing.Point(0, 0);
            this.btaddnv.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.btaddnv.Name = "btaddnv";
            this.btaddnv.Size = new System.Drawing.Size(309, 67);
            this.btaddnv.TabIndex = 6;
            this.btaddnv.Text = "Thêm nhân viên";
            this.btaddnv.UseVisualStyleBackColor = false;
            this.btaddnv.Click += new System.EventHandler(this.btaddnv_Click);
            // 
            // btqlnv
            // 
            this.btqlnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btqlnv.Image = ((System.Drawing.Image)(resources.GetObject("btqlnv.Image")));
            this.btqlnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btqlnv.Location = new System.Drawing.Point(0, 212);
            this.btqlnv.Name = "btqlnv";
            this.btqlnv.Size = new System.Drawing.Size(309, 70);
            this.btqlnv.TabIndex = 4;
            this.btqlnv.Text = "Quản lí nhân viên";
            this.btqlnv.UseVisualStyleBackColor = true;
            this.btqlnv.Click += new System.EventHandler(this.btqlnv_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trang chủ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 21);
            this.panel1.TabIndex = 1;
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.Red;
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmain.Location = new System.Drawing.Point(330, 21);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(931, 637);
            this.panelmain.TabIndex = 2;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 658);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.Name = "Mainform";
            this.Text = "Main";
            this.panelmenu.ResumeLayout(false);
            this.panelqllt.ResumeLayout(false);
            this.panelqlnv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelqlnv;
        private System.Windows.Forms.Button btdelnv;
        private System.Windows.Forms.Button btupdatenv;
        private System.Windows.Forms.Button btaddnv;
        private System.Windows.Forms.Button btqlnv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btqllt;
        private System.Windows.Forms.Panel panelqllt;
        private System.Windows.Forms.Button btdelsche;
        private System.Windows.Forms.Button btsearchsche;
        private System.Windows.Forms.Button btaddsche;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panelmain;
    }
}