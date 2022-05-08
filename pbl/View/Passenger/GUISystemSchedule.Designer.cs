namespace pbl
{
    partial class GUISystemSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUISystemSchedule));
            this.label11 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbHourDes = new System.Windows.Forms.ComboBox();
            this.cbbMinuteDes = new System.Windows.Forms.ComboBox();
            this.bBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pSave = new System.Windows.Forms.PictureBox();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(256, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(705, 16);
            this.label11.TabIndex = 111;
            this.label11.Text = "Dự báo trong thời gian sắp tới nhiều chuyến tàu có thể bị huỷ vì ảnh hưởng của bã" +
    "o và lũ lụt ở nhiều nơi vùng trũng thấp...";
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(20, 192);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(208, 24);
            this.cbbDes.TabIndex = 102;
            this.cbbDes.TextChanged += new System.EventHandler(this.cbbDes_TextChanged);
            this.cbbDes.Leave += new System.EventHandler(this.cbbStation_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ga đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Thời gian đến:";
            // 
            // dateDes
            // 
            this.dateDes.CustomFormat = "dd/MM/yyyy";
            this.dateDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDes.Location = new System.Drawing.Point(20, 313);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(210, 22);
            this.dateDes.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = ":";
            // 
            // cbbHourDes
            // 
            this.cbbHourDes.FormattingEnabled = true;
            this.cbbHourDes.Location = new System.Drawing.Point(94, 384);
            this.cbbHourDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDes.Name = "cbbHourDes";
            this.cbbHourDes.Size = new System.Drawing.Size(44, 24);
            this.cbbHourDes.TabIndex = 97;
            this.cbbHourDes.Leave += new System.EventHandler(this.cbbHour_Leave);
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(154, 384);
            this.cbbMinuteDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(44, 24);
            this.cbbMinuteDes.TabIndex = 99;
            this.cbbMinuteDes.Leave += new System.EventHandler(this.cbbMinute_Leave);
            // 
            // bBook
            // 
            this.bBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBook.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.Location = new System.Drawing.Point(862, 481);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(91, 28);
            this.bBook.TabIndex = 109;
            this.bBook.Text = "Đặt vé";
            this.bBook.UseVisualStyleBackColor = false;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 418);
            this.dataGridView1.TabIndex = 107;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(20, 135);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(208, 24);
            this.cbbDep.TabIndex = 101;
            this.cbbDep.TextChanged += new System.EventHandler(this.cbbDep_TextChanged);
            this.cbbDep.Leave += new System.EventHandler(this.cbbStation_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = ":";
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.Green;
            this.pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSave.Image = ((System.Drawing.Image)(resources.GetObject("pSave.Image")));
            this.pSave.Location = new System.Drawing.Point(277, 484);
            this.pSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(47, 25);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 108;
            this.pSave.TabStop = false;
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(154, 348);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(44, 24);
            this.cbbMinuteDep.TabIndex = 95;
            this.cbbMinuteDep.Leave += new System.EventHandler(this.cbbMinute_Leave);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(69, 444);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(84, 28);
            this.bSearch.TabIndex = 106;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Giờ đi:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateDes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.cbbHourDes);
            this.panel1.Controls.Add(this.cbbMinuteDes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbMinuteDep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbHourDep);
            this.panel1.Controls.Add(this.dateDep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 512);
            this.panel1.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 98;
            this.label9.Text = "Giờ đến:";
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(94, 348);
            this.cbbHourDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(44, 24);
            this.cbbHourDep.TabIndex = 93;
            this.cbbHourDep.Leave += new System.EventHandler(this.cbbHour_Leave);
            // 
            // dateDep
            // 
            this.dateDep.CustomFormat = "dd/MM/yyyy";
            this.dateDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDep.Location = new System.Drawing.Point(20, 247);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(210, 22);
            this.dateDep.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 87);
            this.label1.TabIndex = 82;
            this.label1.Text = "TÌM KIẾM LỊCH TRÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "Ga đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thời gian đi:";
            // 
            // bShowAll
            // 
            this.bShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowAll.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowAll.Location = new System.Drawing.Point(755, 481);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(102, 28);
            this.bShowAll.TabIndex = 112;
            this.bShowAll.Text = "Xem tất cả";
            this.bShowAll.UseVisualStyleBackColor = false;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // GUISystemSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 515);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pSave);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUISystemSchedule";
            this.Text = "GUISystemSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbHourDes;
        private System.Windows.Forms.ComboBox cbbMinuteDes;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pSave;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bShowAll;
    }
}