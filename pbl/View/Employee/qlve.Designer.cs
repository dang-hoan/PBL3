namespace pbl.Employee
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
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.cbbHourDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butshow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 207);
            this.dataGridView1.TabIndex = 100;
            // 
            // butsua
            // 
            this.butsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsua.Location = new System.Drawing.Point(495, 403);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(97, 35);
            this.butsua.TabIndex = 99;
            this.butsua.Text = "Sửa vé";
            this.butsua.UseVisualStyleBackColor = true;
            // 
            // butsearch
            // 
            this.butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsearch.Location = new System.Drawing.Point(678, 112);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(87, 35);
            this.butsearch.TabIndex = 98;
            this.butsearch.Text = "Tìm kiếm";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // butthem
            // 
            this.butthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthem.Location = new System.Drawing.Point(244, 403);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(148, 35);
            this.butthem.TabIndex = 97;
            this.butthem.Text = "Thêm vé mới";
            this.butthem.UseVisualStyleBackColor = true;
            // 
            // butdat
            // 
            this.butdat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdat.Location = new System.Drawing.Point(42, 403);
            this.butdat.Name = "butdat";
            this.butdat.Size = new System.Drawing.Size(132, 35);
            this.butdat.TabIndex = 117;
            this.butdat.Text = "Đặt vé";
            this.butdat.UseVisualStyleBackColor = true;
            this.butdat.Click += new System.EventHandler(this.butdat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Ga đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Ga đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Thời gian đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Thời gian đến";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(124, 19);
            this.txtDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(200, 22);
            this.txtDep.TabIndex = 105;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(555, 25);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(208, 22);
            this.txtDes.TabIndex = 106;
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(124, 68);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(200, 22);
            this.dateDep.TabIndex = 107;
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(557, 73);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(208, 22);
            this.dateDes.TabIndex = 108;
            // 
            // cbbHourDep
            // 
            this.cbbHourDep.FormattingEnabled = true;
            this.cbbHourDep.Location = new System.Drawing.Point(124, 110);
            this.cbbHourDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHourDep.Name = "cbbHourDep";
            this.cbbHourDep.Size = new System.Drawing.Size(70, 24);
            this.cbbHourDep.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Giờ đi";
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(234, 112);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(59, 24);
            this.cbbMinuteDep.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = ":";
            // 
            // butshow
            // 
            this.butshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butshow.Location = new System.Drawing.Point(660, 403);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(95, 35);
            this.butshow.TabIndex = 118;
            this.butshow.Text = "Xóa  vé";
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // qlve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.butdat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMinuteDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbHourDep);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butsearch);
            this.Controls.Add(this.butthem);
            this.Name = "qlve";
            this.Text = "ticket";
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
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.ComboBox cbbHourDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butshow;
    }
}