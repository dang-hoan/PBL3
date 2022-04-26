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
            this.bShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(288, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(855, 20);
            this.label11.TabIndex = 111;
            this.label11.Text = "Dự báo trong thời gian sắp tới nhiều chuyến tàu có thể bị huỷ vì ảnh hưởng của bã" +
    "o và lũ lụt ở nhiều nơi vùng trũng thấp...";
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(22, 208);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ga đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Thời gian đến:";
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(24, 452);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(234, 26);
            this.dateDes.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 100;
            this.label8.Text = ":";
            // 
            // cbbHourDes
            // 
            this.cbbHourDes.FormattingEnabled = true;
            this.cbbHourDes.Location = new System.Drawing.Point(106, 550);
            this.cbbHourDes.Name = "cbbHourDes";
            this.cbbHourDes.Size = new System.Drawing.Size(49, 28);
            this.cbbHourDes.TabIndex = 97;
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(173, 550);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(49, 28);
            this.cbbMinuteDes.TabIndex = 99;
            // 
            // bBook
            // 
            this.bBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBook.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.Location = new System.Drawing.Point(970, 601);
            this.bBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(102, 35);
            this.bBook.TabIndex = 109;
            this.bBook.Text = "Đặt vé";
            this.bBook.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 522);
            this.dataGridView1.TabIndex = 107;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(22, 137);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = ":";
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.Green;
            this.pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSave.Image = ((System.Drawing.Image)(resources.GetObject("pSave.Image")));
            this.pSave.Location = new System.Drawing.Point(312, 605);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 31);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 108;
            this.pSave.TabStop = false;
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(173, 505);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(49, 28);
            this.cbbMinuteDep.TabIndex = 95;
            // 
            // bShow
            // 
            this.bShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShow.Location = new System.Drawing.Point(876, 601);
            this.bShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(95, 35);
            this.bShow.TabIndex = 106;
            this.bShow.Text = "Hiển thị";
            this.bShow.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 640);
            this.panel1.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Giờ đến:";
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Location = new System.Drawing.Point(37, 310);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(87, 24);
            this.rbRound.TabIndex = 89;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Khứ hồi";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(106, 505);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(49, 28);
            this.cbbHourDep.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Hình thức:";
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(21, 379);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(237, 26);
            this.dateDep.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 79);
            this.label1.TabIndex = 82;
            this.label1.Text = "TÌM KIẾM LỊCH TRÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(37, 280);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(103, 24);
            this.rbOne.TabIndex = 88;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "Một chiều";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Ga đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Thời gian đi:";
            // 
            // GUISystemSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 644);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pSave);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
    }
}