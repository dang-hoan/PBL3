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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hourdes = new System.Windows.Forms.ComboBox();
            this.cbbMinuteDes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.daydes = new System.Windows.Forms.DateTimePicker();
            this.hourdep = new System.Windows.Forms.ComboBox();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daydep = new System.Windows.Forms.DateTimePicker();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(512, 486);
            this.bTOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(80, 41);
            this.bTOK.TabIndex = 3;
            this.bTOK.Text = "Add";
            this.bTOK.UseVisualStyleBackColor = true;
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.hourdes);
            this.panel1.Controls.Add(this.cbbMinuteDes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.daydes);
            this.panel1.Controls.Add(this.hourdep);
            this.panel1.Controls.Add(this.cbbMinuteDep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.daydep);
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Location = new System.Drawing.Point(96, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 464);
            this.panel1.TabIndex = 2;
            // 
            // hourdes
            // 
            this.hourdes.FormattingEnabled = true;
            this.hourdes.Location = new System.Drawing.Point(212, 388);
            this.hourdes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourdes.Name = "hourdes";
            this.hourdes.Size = new System.Drawing.Size(118, 28);
            this.hourdes.TabIndex = 44;
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(399, 388);
            this.cbbMinuteDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(96, 28);
            this.cbbMinuteDes.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "GIỜ ĐẾN :";
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(212, 19);
            this.schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(284, 26);
            this.schedule.TabIndex = 40;
            this.schedule.TextChanged += new System.EventHandler(this.schedule_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "ScheduleID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "NGÀY ĐẾN :";
            // 
            // daydes
            // 
            this.daydes.CustomFormat = "dd/MM/yyyy";
            this.daydes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydes.Location = new System.Drawing.Point(212, 254);
            this.daydes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydes.Name = "daydes";
            this.daydes.Size = new System.Drawing.Size(284, 26);
            this.daydes.TabIndex = 35;
            // 
            // hourdep
            // 
            this.hourdep.FormattingEnabled = true;
            this.hourdep.Location = new System.Drawing.Point(212, 321);
            this.hourdep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourdep.Name = "hourdep";
            this.hourdep.Size = new System.Drawing.Size(118, 28);
            this.hourdep.TabIndex = 30;
            this.hourdep.SelectedIndexChanged += new System.EventHandler(this.hourdep_SelectedIndexChanged);
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(399, 321);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(96, 28);
            this.cbbMinuteDep.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "GIỜ ĐI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // daydep
            // 
            this.daydep.CustomFormat = "dd/MM/yyyy";
            this.daydep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydep.Location = new System.Drawing.Point(212, 199);
            this.daydep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydep.Name = "daydep";
            this.daydep.Size = new System.Drawing.Size(284, 26);
            this.daydep.TabIndex = 21;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(212, 141);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(284, 28);
            this.cbbDes.TabIndex = 20;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(212, 76);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(284, 28);
            this.cbbDep.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Huy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addlichtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bTOK);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addlichtrinh";
            this.Text = "addlichtrinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox hourdep;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker daydep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox schedule;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker daydes;
        private System.Windows.Forms.ComboBox hourdes;
        private System.Windows.Forms.ComboBox cbbMinuteDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}