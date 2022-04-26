namespace pbl.Passenger
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
            this.bBook = new System.Windows.Forms.Button();
            this.pSave = new System.Windows.Forms.PictureBox();
            this.bShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.cbbMinuteDes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbHourDes = new System.Windows.Forms.ComboBox();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBook
            // 
            this.bBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBook.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.Location = new System.Drawing.Point(997, 507);
            this.bBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(84, 35);
            this.bBook.TabIndex = 103;
            this.bBook.Text = "Đặt vé";
            this.bBook.UseVisualStyleBackColor = false;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.Green;
            this.pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSave.Image = ((System.Drawing.Image)(resources.GetObject("pSave.Image")));
            this.pSave.Location = new System.Drawing.Point(310, 511);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 31);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 83;
            this.pSave.TabStop = false;
            // 
            // bShow
            // 
            this.bShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShow.Location = new System.Drawing.Point(897, 505);
            this.bShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(84, 35);
            this.bShow.TabIndex = 80;
            this.bShow.Text = "Hiển thị";
            this.bShow.UseVisualStyleBackColor = false;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 443);
            this.dataGridView1.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thời gian đi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Ga đi:";
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(36, 230);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(103, 24);
            this.rbOne.TabIndex = 88;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "Một chiều";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "Lọc theo:";
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Location = new System.Drawing.Point(36, 260);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(87, 24);
            this.rbRound.TabIndex = 89;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Khứ hồi";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Giờ đến:";
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(17, 325);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(234, 26);
            this.dateDep.TabIndex = 90;
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(172, 491);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(49, 28);
            this.cbbMinuteDes.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Hình thức:";
            // 
            // cbbHourDes
            // 
            this.cbbHourDes.FormattingEnabled = true;
            this.cbbHourDes.Location = new System.Drawing.Point(105, 491);
            this.cbbHourDes.Name = "cbbHourDes";
            this.cbbHourDes.Size = new System.Drawing.Size(49, 28);
            this.cbbHourDes.TabIndex = 97;
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(105, 446);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(49, 28);
            this.cbbHourDep.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 100;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 94;
            this.label6.Text = "Giờ đi:";
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(20, 398);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(234, 26);
            this.dateDes.TabIndex = 91;
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(172, 446);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(49, 28);
            this.cbbMinuteDep.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Thời gian đến:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = ":";
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(21, 90);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 101;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ga đến:";
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(21, 159);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 102;
            this.cbbDes.SelectedIndexChanged += new System.EventHandler(this.cbbDes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateDes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbbHourDes);
            this.panel1.Controls.Add(this.cbbMinuteDes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rbRound);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbMinuteDep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbHourDep);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateDep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbOne);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 558);
            this.panel1.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(297, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(855, 20);
            this.label11.TabIndex = 105;
            this.label11.Text = "Dự báo trong thời gian sắp tới nhiều chuyến tàu có thể bị huỷ vì ảnh hưởng của bã" +
    "o và lũ lụt ở nhiều nơi vùng trũng thấp...";
            // 
            // GUISystemSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 559);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.pSave);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Name = "GUISystemSchedule";
            this.Text = "GUISystemSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.PictureBox pSave;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.ComboBox cbbMinuteDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbHourDes;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}