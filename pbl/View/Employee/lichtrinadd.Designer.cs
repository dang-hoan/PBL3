namespace pbl.View
{
    partial class lichtrinadd
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
            this.buttrain = new System.Windows.Forms.Button();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateToDes = new System.Windows.Forms.DateTimePicker();
            this.dateToDep = new System.Windows.Forms.DateTimePicker();
            this.dateFromDes = new System.Windows.Forms.DateTimePicker();
            this.dateFromDep = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttrain
            // 
            this.buttrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttrain.Location = new System.Drawing.Point(694, 628);
            this.buttrain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttrain.Name = "buttrain";
            this.buttrain.Size = new System.Drawing.Size(176, 41);
            this.buttrain.TabIndex = 145;
            this.buttrain.Text = "Thêm chuyến tàu";
            this.buttrain.UseVisualStyleBackColor = false;
            this.buttrain.Click += new System.EventHandler(this.buttrain_Click);
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(489, 68);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 143;
            this.cbbDes.Click += new System.EventHandler(this.cbbDes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 141;
            this.label2.Text = "Ga đến:";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(899, 155);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(124, 41);
            this.bSearch.TabIndex = 144;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(136, 68);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 142;
            this.cbbDep.SelectedIndexChanged += new System.EventHandler(this.cbbDep_SelectedIndexChanged);
            this.cbbDep.Click += new System.EventHandler(this.cbbDep_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 140;
            this.label10.Text = "Ga đi:";
            // 
            // butall
            // 
            this.butall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butall.Location = new System.Drawing.Point(217, 628);
            this.butall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(144, 41);
            this.butall.TabIndex = 139;
            this.butall.Text = "Xem tất cả";
            this.butall.UseVisualStyleBackColor = false;
            this.butall.Click += new System.EventHandler(this.butall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 389);
            this.dataGridView1.TabIndex = 137;
            // 
            // dateToDes
            // 
            this.dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDes.Location = new System.Drawing.Point(633, 170);
            this.dateToDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDes.Name = "dateToDes";
            this.dateToDes.Size = new System.Drawing.Size(206, 26);
            this.dateToDes.TabIndex = 155;
            // 
            // dateToDep
            // 
            this.dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDep.Location = new System.Drawing.Point(633, 128);
            this.dateToDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDep.Name = "dateToDep";
            this.dateToDep.Size = new System.Drawing.Size(206, 26);
            this.dateToDep.TabIndex = 154;
            // 
            // dateFromDes
            // 
            this.dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDes.Location = new System.Drawing.Point(339, 172);
            this.dateFromDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDes.Name = "dateFromDes";
            this.dateFromDes.Size = new System.Drawing.Size(206, 26);
            this.dateFromDes.TabIndex = 153;
            // 
            // dateFromDep
            // 
            this.dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDep.Location = new System.Drawing.Point(339, 128);
            this.dateFromDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDep.Name = "dateFromDep";
            this.dateFromDep.Size = new System.Drawing.Size(206, 26);
            this.dateFromDep.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 150;
            this.label8.Text = "Từ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 149;
            this.label6.Text = "Đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 148;
            this.label5.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 147;
            this.label4.Text = "Ngày đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 146;
            this.label3.Text = "Ngày đi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 156;
            this.label1.Text = "Lọc theo:";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(76, 128);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 61);
            this.checkBox1.TabIndex = 190;
            this.checkBox1.Text = "Tìm kiếm theo thời gian";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lichtrinadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 693);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateToDes);
            this.Controls.Add(this.dateToDep);
            this.Controls.Add(this.dateFromDes);
            this.Controls.Add(this.dateFromDep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttrain);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.butall);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "lichtrinadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lichtrinadd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttrain;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateToDes;
        private System.Windows.Forms.DateTimePicker dateToDep;
        private System.Windows.Forms.DateTimePicker dateFromDes;
        private System.Windows.Forms.DateTimePicker dateFromDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}