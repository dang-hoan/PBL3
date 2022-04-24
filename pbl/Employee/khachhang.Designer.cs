namespace pbl
{
    partial class khachhang
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
            this.butdel = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.Color.Aqua;
            this.butdel.Location = new System.Drawing.Point(872, 363);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(147, 33);
            this.butdel.TabIndex = 15;
            this.butdel.Text = "XÓA";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.Color.Aqua;
            this.butsua.Location = new System.Drawing.Point(644, 363);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(147, 33);
            this.butsua.TabIndex = 14;
            this.butsua.Text = "SỬA";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Aqua;
            this.btAdd.Location = new System.Drawing.Point(394, 363);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(147, 33);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.BackColor = System.Drawing.Color.Aqua;
            this.buttimkiem.Location = new System.Drawing.Point(872, 75);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(147, 33);
            this.buttimkiem.TabIndex = 12;
            this.buttimkiem.Text = "TÌM KIẾM";
            this.buttimkiem.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(701, 75);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(142, 33);
            this.txtsearch.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 215);
            this.dataGridView1.TabIndex = 16;
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1125, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.txtsearch);
            this.Name = "khachhang";
            this.Text = "infor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}