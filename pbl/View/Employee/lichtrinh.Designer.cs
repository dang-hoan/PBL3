namespace pbl.View
{
    partial class lichtrinh
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
            this.themlt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butmuave = new System.Windows.Forms.Button();
            this.butdelte = new System.Windows.Forms.Button();
            this.butall = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMinuteDes = new System.Windows.Forms.ComboBox();
            this.cbbHourDes = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // themlt
            // 
            this.themlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themlt.Location = new System.Drawing.Point(512, 441);
            this.themlt.Name = "themlt";
            this.themlt.Size = new System.Drawing.Size(128, 33);
            this.themlt.TabIndex = 8;
            this.themlt.Text = "Thêm lịch trình";
            this.themlt.UseVisualStyleBackColor = true;
            this.themlt.Click += new System.EventHandler(this.themlt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 239);
            this.dataGridView1.TabIndex = 77;
            // 
            // butmuave
            // 
            this.butmuave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmuave.Location = new System.Drawing.Point(79, 441);
            this.butmuave.Name = "butmuave";
            this.butmuave.Size = new System.Drawing.Size(130, 33);
            this.butmuave.TabIndex = 97;
            this.butmuave.Text = "mua  vé";
            this.butmuave.UseVisualStyleBackColor = true;
            // 
            // butdelte
            // 
            this.butdelte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelte.Location = new System.Drawing.Point(740, 441);
            this.butdelte.Name = "butdelte";
            this.butdelte.Size = new System.Drawing.Size(117, 33);
            this.butdelte.TabIndex = 111;
            this.butdelte.Text = "xóa lịch trình";
            this.butdelte.UseVisualStyleBackColor = true;
            this.butdelte.Click += new System.EventHandler(this.butdelte_Click);
            // 
            // butall
            // 
            this.butall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butall.Location = new System.Drawing.Point(298, 441);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(128, 33);
            this.butall.TabIndex = 112;
            this.butall.Text = "Xem tất cả";
            this.butall.UseVisualStyleBackColor = true;
            this.butall.Click += new System.EventHandler(this.butall_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(662, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 114;
            this.label10.Text = "Ga đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 115;
            this.label2.Text = "Ga đến:";
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(676, 106);
            this.cbbMinuteDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(44, 24);
            this.cbbMinuteDes.TabIndex = 126;
            // 
            // cbbHourDes
            // 
            this.cbbHourDes.FormattingEnabled = true;
            this.cbbHourDes.Location = new System.Drawing.Point(616, 106);
            this.cbbHourDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDes.Name = "cbbHourDes";
            this.cbbHourDes.Size = new System.Drawing.Size(44, 24);
            this.cbbHourDes.TabIndex = 124;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.White;
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(778, 75);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(84, 49);
            this.bSearch.TabIndex = 130;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(18, 51);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(208, 24);
            this.cbbDep.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 125;
            this.label9.Text = "Giờ đến:";
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(676, 47);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(44, 24);
            this.cbbMinuteDep.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 121;
            this.label6.Text = "Giờ đi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Thời gian đến:";
            // 
            // dateDep
            // 
            this.dateDep.CustomFormat = "dd/MM/yyyy";
            this.dateDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDep.Location = new System.Drawing.Point(271, 49);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(210, 22);
            this.dateDep.TabIndex = 118;
            // 
            // dateDes
            // 
            this.dateDes.CustomFormat = "dd/MM/yyyy";
            this.dateDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDes.Location = new System.Drawing.Point(271, 108);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(210, 22);
            this.dateDes.TabIndex = 119;
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(616, 47);
            this.cbbHourDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(44, 24);
            this.cbbHourDep.TabIndex = 120;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(18, 110);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(208, 24);
            this.cbbDes.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Thời gian đi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = ":";
            // 
            // lichtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 533);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbbHourDes);
            this.Controls.Add(this.cbbMinuteDes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMinuteDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbHourDep);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butall);
            this.Controls.Add(this.butdelte);
            this.Controls.Add(this.butmuave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.themlt);
            this.Name = "lichtrinh";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button themlt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butmuave;
        private System.Windows.Forms.Button butdelte;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMinuteDes;
        private System.Windows.Forms.ComboBox cbbHourDes;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}