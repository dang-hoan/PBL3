namespace pbl
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
            this.label1 = new System.Windows.Forms.Label();
            this.themlt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMinuteDep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // themlt
            // 
            this.themlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themlt.Location = new System.Drawing.Point(248, 430);
            this.themlt.Name = "themlt";
            this.themlt.Size = new System.Drawing.Size(148, 23);
            this.themlt.TabIndex = 8;
            this.themlt.Text = "Thêm lịch trình";
            this.themlt.UseVisualStyleBackColor = true;
            this.themlt.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(652, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(455, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 94;
            this.label9.Text = "Giờ đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 92;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbbMinuteDep
            // 
            this.cbbMinuteDep.FormattingEnabled = true;
            this.cbbMinuteDep.Location = new System.Drawing.Point(279, 132);
            this.cbbMinuteDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMinuteDep.Name = "cbbMinuteDep";
            this.cbbMinuteDep.Size = new System.Drawing.Size(67, 24);
            this.cbbMinuteDep.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Giờ đi";
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(146, 89);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(200, 22);
            this.dateDep.TabIndex = 86;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(576, 46);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(208, 22);
            this.txtDes.TabIndex = 85;
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(146, 40);
            this.txtDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(200, 22);
            this.txtDep.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Thời gian đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ga đến";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Ga đi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 207);
            this.dataGridView1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Thời gian đến";
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(576, 94);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(208, 22);
            this.dateDes.TabIndex = 87;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 97;
            this.button1.Text = "Thêm vé";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 132);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 24);
            this.comboBox3.TabIndex = 98;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 132);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 24);
            this.comboBox1.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = ":";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(709, 132);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(67, 24);
            this.comboBox2.TabIndex = 99;
            // 
            // lichtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 533);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbMinuteDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.themlt);
            this.Controls.Add(this.label1);
            this.Name = "lichtrinh";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button themlt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMinuteDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}