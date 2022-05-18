namespace pbl.View
{
    partial class qlve
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butsua = new System.Windows.Forms.Button();
            this.butsearch = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butdat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butxoave = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.process1 = new System.Diagnostics.Process();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbHourDes = new System.Windows.Forms.ComboBox();
            this.cbbMinuteDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 257);
            this.dataGridView1.TabIndex = 100;
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Location = new System.Drawing.Point(550, 469);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(97, 35);
            this.butsua.TabIndex = 99;
            this.butsua.Text = "Sửa vé";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butsearch
            // 
            this.butsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsearch.Location = new System.Drawing.Point(760, 67);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(87, 35);
            this.butsearch.TabIndex = 98;
            this.butsearch.Text = "Tìm kiếm";
            this.butsearch.UseVisualStyleBackColor = false;
            // 
            // butthem
            // 
            this.butthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthem.Location = new System.Drawing.Point(266, 469);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(148, 35);
            this.butthem.TabIndex = 97;
            this.butthem.Text = "Thêm vé mới";
            this.butthem.UseVisualStyleBackColor = false;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butdat
            // 
            this.butdat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdat.Location = new System.Drawing.Point(44, 469);
            this.butdat.Name = "butdat";
            this.butdat.Size = new System.Drawing.Size(132, 35);
            this.butdat.TabIndex = 117;
            this.butdat.Text = "Đặt vé";
            this.butdat.UseVisualStyleBackColor = false;
            this.butdat.Click += new System.EventHandler(this.butdat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Ga đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Ga đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Thời gian đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Thời gian đến";
            // 
            // dateDep
            // 
            this.dateDep.CustomFormat = "dd/MM/yyyy";
            this.dateDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDep.Location = new System.Drawing.Point(174, 67);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(200, 22);
            this.dateDep.TabIndex = 107;
            // 
            // dateDes
            // 
            this.dateDes.CustomFormat = "dd/MM/yyyy";
            this.dateDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDes.Location = new System.Drawing.Point(510, 68);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(208, 22);
            this.dateDes.TabIndex = 108;
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(174, 108);
            this.cbbHourDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(70, 24);
            this.cbbHourDep.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Giờ đi";
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(266, 108);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(59, 24);
            this.cbbMinuteDep.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = ":";
            // 
            // butxoave
            // 
            this.butxoave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butxoave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoave.Location = new System.Drawing.Point(760, 469);
            this.butxoave.Name = "butxoave";
            this.butxoave.Size = new System.Drawing.Size(95, 35);
            this.butxoave.TabIndex = 118;
            this.butxoave.Text = "Xóa  vé";
            this.butxoave.UseVisualStyleBackColor = false;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(174, 20);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(200, 24);
            this.cbbDep.TabIndex = 119;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(510, 20);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(208, 24);
            this.cbbDes.TabIndex = 120;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 124;
            this.label9.Text = "Giờ đến:";
            // 
            // cbbHourDes
            // 
            this.cbbHourDes.FormattingEnabled = true;
            this.cbbHourDes.Location = new System.Drawing.Point(510, 117);
            this.cbbHourDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDes.Name = "cbbHourDes";
            this.cbbHourDes.Size = new System.Drawing.Size(70, 24);
            this.cbbHourDes.TabIndex = 125;
            // 
            // cbbMinuteDes
            // 
            this.cbbMinuteDes.FormattingEnabled = true;
            this.cbbMinuteDes.Location = new System.Drawing.Point(602, 117);
            this.cbbMinuteDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDes.Name = "cbbMinuteDes";
            this.cbbMinuteDes.Size = new System.Drawing.Size(59, 24);
            this.cbbMinuteDes.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = ":";
            // 
            // cbbook
            // 
            this.cbbook.FormattingEnabled = true;
            this.cbbook.Location = new System.Drawing.Point(174, 151);
            this.cbbook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbook.Name = "cbbook";
            this.cbbook.Size = new System.Drawing.Size(208, 24);
            this.cbbook.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 129;
            this.label5.Text = "Trạng Thái vé";

            // 
            // qlve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(915, 533);
            this.Controls.Add(this.cbbook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMinuteDes);
            this.Controls.Add(this.cbbHourDes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.butxoave);
            this.Controls.Add(this.butdat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMinuteDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbHourDep);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butsearch);
            this.Controls.Add(this.butthem);
            this.Name = "qlve";
            this.Text = "quản lý vé";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butdat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butxoave;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMinuteDes;
        private System.Windows.Forms.ComboBox cbbHourDes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbook;
        private System.Windows.Forms.Label label5;
    }
}