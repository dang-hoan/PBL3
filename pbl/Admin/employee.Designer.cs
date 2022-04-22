namespace pbl
{
    partial class employee
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(50, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 464);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(549, 14);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(142, 33);
            this.txttimkiem.TabIndex = 5;
            // 
            // bttimkiem
            // 
            this.bttimkiem.BackColor = System.Drawing.Color.Aqua;
            this.bttimkiem.Location = new System.Drawing.Point(737, 14);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(147, 33);
            this.bttimkiem.TabIndex = 6;
            this.bttimkiem.Text = "TÌM KIẾM";
            this.bttimkiem.UseVisualStyleBackColor = false;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.bttimkiem);
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 694);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(803, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Location = new System.Drawing.Point(589, 590);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 33);
            this.button7.TabIndex = 9;
            this.button7.Text = "XÓA";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Location = new System.Drawing.Point(322, 590);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 33);
            this.button6.TabIndex = 8;
            this.button6.Text = "SỬA";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Aqua;
            this.btAdd.Location = new System.Drawing.Point(50, 590);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(147, 33);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(968, 697);
            this.Controls.Add(this.panel2);
            this.Name = "employee";
            this.Text = "employee";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}