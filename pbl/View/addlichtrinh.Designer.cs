namespace pbl.View
{
    partial class addlichtrinh
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
            this.bTOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.daydes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daydep = new System.Windows.Forms.DateTimePicker();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTOK
            // 
            this.bTOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bTOK.Location = new System.Drawing.Point(161, 325);
            this.bTOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(80, 41);
            this.bTOK.TabIndex = 3;
            this.bTOK.Text = "Thêm";
            this.bTOK.UseVisualStyleBackColor = false;
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(351, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.daydes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.daydep);
            this.groupBox1.Controls.Add(this.cbbDes);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Location = new System.Drawing.Point(59, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 286);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm lịch trình mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "NGÀY ĐẾN :";
            // 
            // daydes
            // 
            this.daydes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.daydes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydes.Location = new System.Drawing.Point(194, 223);
            this.daydes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydes.Name = "daydes";
            this.daydes.Size = new System.Drawing.Size(284, 26);
            this.daydes.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // daydep
            // 
            this.daydep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.daydep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydep.Location = new System.Drawing.Point(194, 168);
            this.daydep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydep.Name = "daydep";
            this.daydep.Size = new System.Drawing.Size(284, 26);
            this.daydep.TabIndex = 39;
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(194, 110);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(284, 28);
            this.cbbDes.TabIndex = 38;
            this.cbbDes.Click += new System.EventHandler(this.cbbDes_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(194, 45);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(284, 28);
            this.cbbDep.TabIndex = 37;
            this.cbbDep.Click += new System.EventHandler(this.cbbDep_Click);
            // 
            // addlichtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bTOK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addlichtrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM LỊCH TRÌNH";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker daydes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker daydep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
    }
}