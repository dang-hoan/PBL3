namespace pbl.View.Employee
{
    partial class doanhthu
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbmonth = new System.Windows.Forms.ComboBox();
            this.cbbyear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btdoanhthu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // cbbmonth
            // 
            this.cbbmonth.FormattingEnabled = true;
            this.cbbmonth.Location = new System.Drawing.Point(293, 27);
            this.cbbmonth.Name = "cbbmonth";
            this.cbbmonth.Size = new System.Drawing.Size(139, 24);
            this.cbbmonth.TabIndex = 2;
            // 
            // cbbyear
            // 
            this.cbbyear.FormattingEnabled = true;
            this.cbbyear.Location = new System.Drawing.Point(542, 27);
            this.cbbyear.Name = "cbbyear";
            this.cbbyear.Size = new System.Drawing.Size(139, 24);
            this.cbbyear.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 483);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "In báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdoanhthu
            // 
            this.btdoanhthu.Location = new System.Drawing.Point(744, 27);
            this.btdoanhthu.Name = "btdoanhthu";
            this.btdoanhthu.Size = new System.Drawing.Size(92, 32);
            this.btdoanhthu.TabIndex = 6;
            this.btdoanhthu.Text = "Xem ";
            this.btdoanhthu.UseVisualStyleBackColor = true;
            this.btdoanhthu.Click += new System.EventHandler(this.btdoanhthu_Click);
            // 
            // doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(912, 697);
            this.Controls.Add(this.btdoanhthu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbyear);
            this.Controls.Add(this.cbbmonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doanhthu";
            this.Text = "doanhthu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbmonth;
        private System.Windows.Forms.ComboBox cbbyear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btdoanhthu;
    }
}