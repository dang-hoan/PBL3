namespace pbl.View
{
    partial class trainve
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
            this.butve = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butve
            // 
            this.butve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butve.Location = new System.Drawing.Point(831, 585);
            this.butve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butve.Name = "butve";
            this.butve.Size = new System.Drawing.Size(146, 82);
            this.butve.TabIndex = 168;
            this.butve.Text = "Chọn";
            this.butve.UseVisualStyleBackColor = false;
            this.butve.Click += new System.EventHandler(this.butve_Click);
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(426, 58);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 161;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 157;
            this.label2.Text = "Ga đến:";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(834, 64);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(144, 61);
            this.bSearch.TabIndex = 162;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(36, 57);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 160;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 156;
            this.label10.Text = "Ga đi:";
            // 
            // butall
            // 
            this.butall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butall.Location = new System.Drawing.Point(834, 151);
            this.butall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(144, 59);
            this.butall.TabIndex = 155;
            this.butall.Text = "Xem tất cả";
            this.butall.UseVisualStyleBackColor = false;
            this.butall.Click += new System.EventHandler(this.butall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 328);
            this.dataGridView1.TabIndex = 153;
            // 
            // dateToDes
            // 
            this.dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDes.Location = new System.Drawing.Point(455, 157);
            this.dateToDes.Name = "dateToDes";
            this.dateToDes.Size = new System.Drawing.Size(207, 26);
            this.dateToDes.TabIndex = 178;
            // 
            // dateToDep
            // 
            this.dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDep.Location = new System.Drawing.Point(455, 114);
            this.dateToDep.Name = "dateToDep";
            this.dateToDep.Size = new System.Drawing.Size(207, 26);
            this.dateToDep.TabIndex = 177;
            // 
            // dateFromDes
            // 
            this.dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDes.Location = new System.Drawing.Point(161, 158);
            this.dateFromDes.Name = "dateFromDes";
            this.dateFromDes.Size = new System.Drawing.Size(207, 26);
            this.dateFromDes.TabIndex = 176;
            // 
            // dateFromDep
            // 
            this.dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDep.Location = new System.Drawing.Point(161, 114);
            this.dateFromDep.Name = "dateFromDep";
            this.dateFromDep.Size = new System.Drawing.Size(207, 26);
            this.dateFromDep.TabIndex = 175;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 174;
            this.label7.Text = "Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 173;
            this.label8.Text = "Từ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 172;
            this.label6.Text = "Đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 171;
            this.label5.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 170;
            this.label4.Text = "Ngày đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "Ngày đi:";
            // 
            // trainve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 688);
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
            this.Controls.Add(this.butve);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.butall);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "trainve";
            this.Text = "trainve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butve;
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
    }
}