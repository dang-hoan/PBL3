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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbseat = new System.Windows.Forms.ComboBox();
            this.cbbmave = new System.Windows.Forms.ComboBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pChat)).BeginInit();
            this.SuspendLayout();
            // 
            // butadd
            // 
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(482, 384);
            this.butadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(100, 38);
            this.butadd.TabIndex = 100;
            this.butadd.Text = "Thêm";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butcancel
            // 
            this.butcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcancel.Location = new System.Drawing.Point(368, 384);
            this.butcancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(100, 38);
            this.butcancel.TabIndex = 123;
            this.butcancel.Text = "Hủy";
            this.butcancel.UseVisualStyleBackColor = true;
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 126;
            this.label8.Text = "Mã ghế";
            // 
            // txtgiave
            // 
            this.txtgiave.Enabled = false;
            this.txtgiave.Location = new System.Drawing.Point(269, 336);
            this.txtgiave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgiave.Name = "txtgiave";
            this.txtgiave.Size = new System.Drawing.Size(317, 26);
            this.txtgiave.TabIndex = 132;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 131;
            this.label12.Text = "Giá vé:";
            // 
            // txtsotau
            // 
            this.txtsotau.Location = new System.Drawing.Point(266, 241);
            this.txtsotau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsotau.Name = "txtsotau";
            this.txtsotau.Size = new System.Drawing.Size(317, 26);
            this.txtsotau.TabIndex = 134;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 133;
            this.label13.Text = "Số toa:";
            // 
            // pChat
            // 
            this.pChat.BackColor = System.Drawing.Color.LightCyan;
            this.pChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pChat.Image = ((System.Drawing.Image)(resources.GetObject("pChat.Image")));
            this.pChat.Location = new System.Drawing.Point(91, 96);
            this.pChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pChat.Name = "pChat";
            this.pChat.Size = new System.Drawing.Size(102, 110);
            this.pChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pChat.TabIndex = 135;
            this.pChat.TabStop = false;
            this.pChat.Click += new System.EventHandler(this.pChat_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 59);
            this.label2.TabIndex = 136;
            this.label2.Text = "Chọn một chuyến tàu trước khi thêm (kích chuột vào hình chuyến tàu)!";
            // 
            // txttrainid
            // 
            this.txttrainid.Location = new System.Drawing.Point(374, 126);
            this.txttrainid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttrainid.Name = "txttrainid";
            this.txttrainid.Size = new System.Drawing.Size(209, 26);
            this.txttrainid.TabIndex = 139;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Mã tàu";
            // 
            // txtschedule
            // 
            this.txtschedule.Location = new System.Drawing.Point(374, 81);
            this.txtschedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtschedule.Name = "txtschedule";
            this.txtschedule.Size = new System.Drawing.Size(209, 26);
            this.txtschedule.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 141;
            this.label1.Text = "Mã lịch trình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 143;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 145;
            this.label4.Text = "Tên tàu";
            // 
            // cbbseat
            // 
            this.cbbseat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbseat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbseat.FormattingEnabled = true;
            this.cbbseat.Location = new System.Drawing.Point(266, 288);
            this.cbbseat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbseat.Name = "cbbseat";
            this.cbbseat.Size = new System.Drawing.Size(317, 28);
            this.cbbseat.TabIndex = 146;
            this.cbbseat.SelectedIndexChanged += new System.EventHandler(this.cbbseat_SelectedIndexChanged);
            // 
            // cbbmave
            // 
            this.cbbmave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbmave.FormattingEnabled = true;
            this.cbbmave.Location = new System.Drawing.Point(184, 288);
            this.cbbmave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbmave.Name = "cbbmave";
            this.cbbmave.Size = new System.Drawing.Size(56, 28);
            this.cbbmave.TabIndex = 147;
            this.cbbmave.SelectedIndexChanged += new System.EventHandler(this.cbbmave_SelectedIndexChanged);
            // 
            // cbbName
            // 
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(368, 183);
            this.cbbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(214, 28);
            this.cbbName.TabIndex = 148;
            // 
            // addve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.cbbName);
            this.Controls.Add(this.cbbmave);
            this.Controls.Add(this.cbbseat);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbseat;
        private System.Windows.Forms.ComboBox cbbmave;
        private System.Windows.Forms.ComboBox cbbName;
    }
}