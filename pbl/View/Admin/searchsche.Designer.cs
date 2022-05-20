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
            this.bTOK = new System.Windows.Forms.Button();
            this.datengaydi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbgaden = new System.Windows.Forms.ComboBox();
            this.cbbgadi = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 332);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bTOK);
            this.panel1.Controls.Add(this.datengaydi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbgaden);
            this.panel1.Controls.Add(this.cbbgadi);
            this.panel1.Location = new System.Drawing.Point(31, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 123);
            this.panel1.TabIndex = 4;
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(703, 24);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(75, 23);
            this.bTOK.TabIndex = 1;
            this.bTOK.Text = "Tìm kiếm";
            this.bTOK.UseVisualStyleBackColor = true;
            // 
            // datengaydi
            // 
            this.datengaydi.CustomFormat = "dd/MM/yyyy";
            this.datengaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengaydi.Location = new System.Drawing.Point(118, 71);
            this.datengaydi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datengaydi.Name = "datengaydi";
            this.datengaydi.Size = new System.Drawing.Size(172, 22);
            this.datengaydi.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // cbbgaden
            // 
            this.cbbgaden.FormattingEnabled = true;
            this.cbbgaden.Location = new System.Drawing.Point(457, 19);
            this.cbbgaden.Name = "cbbgaden";
            this.cbbgaden.Size = new System.Drawing.Size(172, 24);
            this.cbbgaden.TabIndex = 20;
            // 
            // cbbgadi
            // 
            this.cbbgadi.FormattingEnabled = true;
            this.cbbgadi.Location = new System.Drawing.Point(118, 24);
            this.cbbgadi.Name = "cbbgadi";
            this.cbbgadi.Size = new System.Drawing.Size(172, 24);
            this.cbbgadi.TabIndex = 19;
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
        private System.Windows.Forms.DateTimePicker datengaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbgaden;
        private System.Windows.Forms.ComboBox cbbgadi;
    }
}