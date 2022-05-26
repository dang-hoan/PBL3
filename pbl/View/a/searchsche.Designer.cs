namespace pbl.View.Admin
{
    partial class searchsche
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateToDep = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateToDes = new System.Windows.Forms.DateTimePicker();
            this.dateFromDep = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateFromDes = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bTOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(34, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(339, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Welcome to DNtrain";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 241);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateToDep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateToDes);
            this.panel1.Controls.Add(this.dateFromDep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateFromDes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bTOK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Location = new System.Drawing.Point(31, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 234);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 117;
            this.label1.Text = "Ngày đi:";
            // 
            // dateToDep
            // 
            this.dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDep.Location = new System.Drawing.Point(457, 109);
            this.dateToDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDep.Name = "dateToDep";
            this.dateToDep.Size = new System.Drawing.Size(165, 22);
            this.dateToDep.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Đến:";
            // 
            // dateToDes
            // 
            this.dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDes.Location = new System.Drawing.Point(457, 175);
            this.dateToDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToDes.Name = "dateToDes";
            this.dateToDes.Size = new System.Drawing.Size(165, 22);
            this.dateToDes.TabIndex = 126;
            // 
            // dateFromDep
            // 
            this.dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDep.Location = new System.Drawing.Point(119, 109);
            this.dateFromDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDep.Name = "dateFromDep";
            this.dateFromDep.Size = new System.Drawing.Size(165, 26);
            this.dateFromDep.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Từ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 122;
            this.label7.Text = "Đến:";
            // 
            // dateFromDes
            // 
            this.dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDes.Location = new System.Drawing.Point(119, 176);
            this.dateFromDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFromDes.Name = "dateFromDes";
            this.dateFromDes.Size = new System.Drawing.Size(165, 26);
            this.dateFromDes.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ngày đến:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 121;
            this.label9.Text = "Từ:";
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(748, 194);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(75, 23);
            this.bTOK.TabIndex = 1;
            this.bTOK.Text = "Tìm kiếm";
            this.bTOK.UseVisualStyleBackColor = true;
            this.bTOK.TextChanged += new System.EventHandler(this.cbbDep_TextChanged);
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "GA ĐẾN :";
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(457, 19);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(172, 24);
            this.cbbDes.TabIndex = 20;
            this.cbbDes.TextChanged += new System.EventHandler(this.cbbDes_TextChanged);
            // 
            // cbbDep
            // 
            this.cbbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(118, 24);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(172, 28);
            this.cbbDep.TabIndex = 19;
            this.cbbDep.TextChanged += new System.EventHandler(this.cbbDep_TextChanged);
            // 
            // searchsche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(913, 590);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "searchsche";
            this.Text = "searchsche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateToDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateToDes;
        private System.Windows.Forms.DateTimePicker dateFromDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateFromDes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}