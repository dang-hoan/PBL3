namespace pbl.View
{
    partial class addve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addve));
            this.butadd = new System.Windows.Forms.Button();
            this.butcancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgiave = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsotau = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pChat = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttrainid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtschedule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbseat = new System.Windows.Forms.ComboBox();
            this.cbbmave = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pChat)).BeginInit();
            this.SuspendLayout();
            // 
            // butadd
            // 
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(659, 369);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(89, 30);
            this.butadd.TabIndex = 100;
            this.butadd.Text = "Thêm";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butcancel
            // 
            this.butcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcancel.Location = new System.Drawing.Point(531, 369);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(89, 30);
            this.butcancel.TabIndex = 123;
            this.butcancel.Text = "Hủy";
            this.butcancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 126;
            this.label8.Text = "Seatno";
            // 
            // txtgiave
            // 
            this.txtgiave.Location = new System.Drawing.Point(163, 289);
            this.txtgiave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgiave.Name = "txtgiave";
            this.txtgiave.Size = new System.Drawing.Size(208, 22);
            this.txtgiave.TabIndex = 132;
            this.txtgiave.TextChanged += new System.EventHandler(this.txtgiave_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 131;
            this.label12.Text = "Giá vé:";
            // 
            // txtsotau
            // 
            this.txtsotau.Location = new System.Drawing.Point(163, 213);
            this.txtsotau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsotau.Name = "txtsotau";
            this.txtsotau.Size = new System.Drawing.Size(208, 22);
            this.txtsotau.TabIndex = 134;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 133;
            this.label13.Text = "số toa tàu";
            // 
            // pChat
            // 
            this.pChat.BackColor = System.Drawing.Color.LightCyan;
            this.pChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pChat.Image = ((System.Drawing.Image)(resources.GetObject("pChat.Image")));
            this.pChat.Location = new System.Drawing.Point(158, 63);
            this.pChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(91, 88);
            this.pChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pChat.TabIndex = 135;
            this.pChat.TabStop = false;
            this.pChat.Click += new System.EventHandler(this.pChat_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 34);
            this.label2.TabIndex = 136;
            this.label2.Text = "chọn lịch trình đặt vé";
            // 
            // txttrainid
            // 
            this.txttrainid.Location = new System.Drawing.Point(442, 32);
            this.txttrainid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttrainid.Name = "txttrainid";
            this.txttrainid.Size = new System.Drawing.Size(200, 22);
            this.txttrainid.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Train id";
            // 
            // txtschedule
            // 
            this.txtschedule.Location = new System.Drawing.Point(442, 139);
            this.txtschedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtschedule.Name = "txtschedule";
            this.txtschedule.Size = new System.Drawing.Size(200, 22);
            this.txtschedule.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 141;
            this.label1.Text = "Scheduleid";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(442, 92);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 143;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Train name";
            // 
            // cbbseat
            // 
            this.cbbseat.FormattingEnabled = true;
            this.cbbseat.Location = new System.Drawing.Point(531, 213);
            this.cbbseat.Name = "cbbseat";
            this.cbbseat.Size = new System.Drawing.Size(217, 24);
            this.cbbseat.TabIndex = 146;
            this.cbbseat.SelectedIndexChanged += new System.EventHandler(this.cbbseat_SelectedIndexChanged);
            // 
            // cbbmave
            // 
            this.cbbmave.FormattingEnabled = true;
            this.cbbmave.Location = new System.Drawing.Point(489, 213);
            this.cbbmave.Name = "cbbmave";
            this.cbbmave.Size = new System.Drawing.Size(36, 24);
            this.cbbmave.TabIndex = 147;
            this.cbbmave.SelectedIndexChanged += new System.EventHandler(this.cbbmave_SelectedIndexChanged);
            // 
            // addve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbmave);
            this.Controls.Add(this.cbbseat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtschedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttrainid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pChat);
            this.Controls.Add(this.txtsotau);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtgiave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butcancel);
            this.Controls.Add(this.butadd);
            this.Name = "addve";
            this.Text = "addve";
            this.Load += new System.EventHandler(this.addve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butcancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgiave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsotau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttrainid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtschedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbseat;
        private System.Windows.Forms.ComboBox cbbmave;
    }
}