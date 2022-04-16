namespace pbl
{
    partial class Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger));
            this.pInfor = new System.Windows.Forms.PictureBox();
            this.pTicket = new System.Windows.Forms.PictureBox();
            this.pSchedule = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pInfor
            // 
            this.pInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pInfor.Image = ((System.Drawing.Image)(resources.GetObject("pInfor.Image")));
            this.pInfor.Location = new System.Drawing.Point(298, 54);
            this.pInfor.Name = "pInfor";
            this.pInfor.Size = new System.Drawing.Size(197, 171);
            this.pInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pInfor.TabIndex = 0;
            this.pInfor.TabStop = false;
            this.pInfor.Click += new System.EventHandler(this.pInfor_Click);
            // 
            // pTicket
            // 
            this.pTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTicket.Image = ((System.Drawing.Image)(resources.GetObject("pTicket.Image")));
            this.pTicket.Location = new System.Drawing.Point(418, 247);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(195, 172);
            this.pTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pTicket.TabIndex = 1;
            this.pTicket.TabStop = false;
            this.pTicket.Click += new System.EventHandler(this.pTicket_Click);
            // 
            // pSchedule
            // 
            this.pSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSchedule.Image = ((System.Drawing.Image)(resources.GetObject("pSchedule.Image")));
            this.pSchedule.Location = new System.Drawing.Point(534, 54);
            this.pSchedule.Name = "pSchedule";
            this.pSchedule.Size = new System.Drawing.Size(195, 171);
            this.pSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSchedule.TabIndex = 2;
            this.pSchedule.TabStop = false;
            this.pSchedule.Click += new System.EventHandler(this.pSchedule_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 214);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(54, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO DA NANG RAILWAY";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(635, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "họ và tên";
            // 
            // bLogOut
            // 
            this.bLogOut.Location = new System.Drawing.Point(717, 15);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(71, 30);
            this.bLogOut.TabIndex = 7;
            this.bLogOut.Text = "Log out";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pSchedule);
            this.Controls.Add(this.pTicket);
            this.Controls.Add(this.pInfor);
            this.Name = "Passenger";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pInfor;
        private System.Windows.Forms.PictureBox pTicket;
        private System.Windows.Forms.PictureBox pSchedule;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button bLogOut;
    }
}

