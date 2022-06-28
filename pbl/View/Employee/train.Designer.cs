namespace pbl.View
{
    partial class train
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttrain = new System.Windows.Forms.Button();
            this.butall = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateToDes = new System.Windows.Forms.DateTimePicker();
            this.dateToDep = new System.Windows.Forms.DateTimePicker();
            this.dateFromDes = new System.Windows.Forms.DateTimePicker();
            this.dateFromDep = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dateToDes);
            this.panel1.Controls.Add(this.dateToDep);
            this.panel1.Controls.Add(this.dateFromDes);
            this.panel1.Controls.Add(this.dateFromDep);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.buttrain);
            this.panel1.Controls.Add(this.butall);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 693);
            this.panel1.TabIndex = 0;
            // 
            // buttrain
            // 
            this.buttrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttrain.Location = new System.Drawing.Point(438, 626);
            this.buttrain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttrain.Name = "buttrain";
            this.buttrain.Size = new System.Drawing.Size(174, 41);
            this.buttrain.TabIndex = 174;
            this.buttrain.Text = "Thêm chuyến tàu";
            this.buttrain.UseVisualStyleBackColor = false;
            this.buttrain.Click += new System.EventHandler(this.buttrain_Click_1);
            // 
            // butall
            // 
            this.butall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butall.Location = new System.Drawing.Point(139, 626);
            this.butall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(144, 41);
            this.butall.TabIndex = 168;
            this.butall.Text = "Xem tất cả";
            this.butall.UseVisualStyleBackColor = false;
            this.butall.Click += new System.EventHandler(this.butall_Click_1);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(777, 626);
            this.bDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(169, 41);
            this.bDelete.TabIndex = 167;
            this.bDelete.Text = "Xoá chuyến tàu";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(947, 359);
            this.dataGridView1.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 250;
            this.label1.Text = "Lọc theo:";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(71, 149);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 61);
            this.checkBox1.TabIndex = 249;
            this.checkBox1.Text = "Tìm kiếm theo thời gian";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateToDes
            // 
            this.dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDes.Location = new System.Drawing.Point(634, 188);
            this.dateToDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDes.Name = "dateToDes";
            this.dateToDes.Size = new System.Drawing.Size(206, 26);
            this.dateToDes.TabIndex = 248;
            // 
            // dateToDep
            // 
            this.dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDep.Location = new System.Drawing.Point(634, 145);
            this.dateToDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDep.Name = "dateToDep";
            this.dateToDep.Size = new System.Drawing.Size(206, 26);
            this.dateToDep.TabIndex = 247;
            // 
            // dateFromDes
            // 
            this.dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDes.Location = new System.Drawing.Point(340, 189);
            this.dateFromDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDes.Name = "dateFromDes";
            this.dateFromDes.Size = new System.Drawing.Size(206, 26);
            this.dateFromDes.TabIndex = 246;
            // 
            // dateFromDep
            // 
            this.dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDep.Location = new System.Drawing.Point(340, 145);
            this.dateFromDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDep.Name = "dateFromDep";
            this.dateFromDep.Size = new System.Drawing.Size(206, 26);
            this.dateFromDep.TabIndex = 245;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 244;
            this.label9.Text = "Đến:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 243;
            this.label11.Text = "Từ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(585, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 242;
            this.label12.Text = "Đến:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 241;
            this.label13.Text = "Từ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 240;
            this.label14.Text = "Ngày đến:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 239;
            this.label15.Text = "Ngày đi:";
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(538, 84);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 237;
            this.cbbDes.Click += new System.EventHandler(this.cbbDes_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(451, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 235;
            this.label16.Text = "Ga đến:";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(902, 171);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(116, 44);
            this.bSearch.TabIndex = 238;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click_1);
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(146, 84);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 236;
            this.cbbDep.Click += new System.EventHandler(this.cbbDep_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(70, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 234;
            this.label17.Text = "Ga đi:";
            // 
            // train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 693);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "train";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttrain;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateToDes;
        private System.Windows.Forms.DateTimePicker dateToDep;
        private System.Windows.Forms.DateTimePicker dateFromDes;
        private System.Windows.Forms.DateTimePicker dateFromDep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label17;
    }
}