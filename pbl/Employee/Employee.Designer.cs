namespace pbl
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pInfor = new System.Windows.Forms.PictureBox();
            this.pSchedule = new System.Windows.Forms.PictureBox();
            this.pTicket = new System.Windows.Forms.PictureBox();
            this.pPassenger = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pInfor
            // 
            this.pInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pInfor.Image = ((System.Drawing.Image)(resources.GetObject("pInfor.Image")));
            this.pInfor.Location = new System.Drawing.Point(425, 77);
            this.pInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pInfor.Name = "pInfor";
            this.pInfor.Size = new System.Drawing.Size(260, 250);
            this.pInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pInfor.TabIndex = 1;
            this.pInfor.TabStop = false;
            this.pInfor.Click += new System.EventHandler(this.pInfor_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pSchedule.Image")));
            this.pSchedule.Location = new System.Drawing.Point(711, 77);
            this.pSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(260, 250);
            this.pSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSchedule.TabIndex = 2;
            this.pSchedule.TabStop = false;
            this.pSchedule.Click += new System.EventHandler(this.pSchedule_Click);
            // 
            // pTicket
            // 
            this.pTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTicket.Image = ((System.Drawing.Image)(resources.GetObject("pTicket.Image")));
            this.pTicket.Location = new System.Drawing.Point(425, 353);
            this.pTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(260, 250);
            this.pTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pTicket.TabIndex = 3;
            this.pTicket.TabStop = false;
            this.pTicket.Click += new System.EventHandler(this.pTicket_Click);
            // 
            // pPassenger
            // 
            this.pPassenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pPassenger.Image = ((System.Drawing.Image)(resources.GetObject("pPassenger.Image")));
            this.pPassenger.Location = new System.Drawing.Point(711, 353);
            this.pPassenger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pPassenger.Name = "pPassenger";
            this.pPassenger.Size = new System.Drawing.Size(260, 250);
            this.pPassenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPassenger.TabIndex = 4;
            this.pPassenger.TabStop = false;
            this.pPassenger.Click += new System.EventHandler(this.pPassenger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME TO DA NANG RAILWAY";
            // 
            // bLogOut
            // 
            this.bLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogOut.Location = new System.Drawing.Point(902, 15);
            this.bLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(84, 29);
            this.bLogOut.TabIndex = 7;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(815, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 30);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Họ và tên";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1013, 697);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pPassenger);
            this.Controls.Add(this.pTicket);
            this.Controls.Add(this.pSchedule);
            this.Controls.Add(this.pInfor);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPassenger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pInfor;
        private System.Windows.Forms.PictureBox pSchedule;
        private System.Windows.Forms.PictureBox pTicket;
        private System.Windows.Forms.PictureBox pPassenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Label labelName;
    }
}