namespace pbl.Admin
{
    partial class addschedule
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
            this.label9 = new System.Windows.Forms.Label();
            this.daydes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daydep = new System.Windows.Forms.DateTimePicker();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.bTOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.daydes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.daydep);
            this.panel1.Controls.Add(this.cbbDes);
            this.panel1.Controls.Add(this.cbbDep);
            this.panel1.Controls.Add(this.bTOK);
            this.panel1.Location = new System.Drawing.Point(24, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 240);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "NGÀY ĐẾN :";
            // 
            // daydes
            // 
            this.daydes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.daydes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydes.Location = new System.Drawing.Point(422, 196);
            this.daydes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydes.Name = "daydes";
            this.daydes.Size = new System.Drawing.Size(284, 26);
            this.daydes.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // daydep
            // 
            this.daydep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.daydep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daydep.Location = new System.Drawing.Point(422, 141);
            this.daydep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.daydep.Name = "daydep";
            this.daydep.Size = new System.Drawing.Size(284, 26);
            this.daydep.TabIndex = 39;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(422, 82);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(284, 28);
            this.cbbDes.TabIndex = 38;
            this.cbbDes.TextChanged += new System.EventHandler(this.cbbDes_TextChanged);
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(422, 18);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(284, 28);
            this.cbbDep.TabIndex = 37;
            this.cbbDep.TextChanged += new System.EventHandler(this.cbbDep_TextChanged);
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(840, 176);
            this.bTOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(84, 29);
            this.bTOK.TabIndex = 1;
            this.bTOK.Text = "OK";
            this.bTOK.UseVisualStyleBackColor = true;
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(957, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Welcome to DNtrain";
            // 
            // addschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1027, 738);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addschedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addschedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker daydes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker daydep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
    }
}