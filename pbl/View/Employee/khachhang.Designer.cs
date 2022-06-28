namespace pbl.View
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
            this.butshow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbshow = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butdel.Location = new System.Drawing.Point(790, 612);
            this.butdel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(131, 40);
            this.butdel.TabIndex = 15;
            this.butdel.Text = "XÓA";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butsua.Location = new System.Drawing.Point(487, 612);
            this.butsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(131, 40);
            this.butsua.TabIndex = 14;
            this.butsua.Text = "SỬA";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAdd.Location = new System.Drawing.Point(150, 612);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(131, 40);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // butshow
            // 
            this.butshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butshow.Location = new System.Drawing.Point(99, 42);
            this.butshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(165, 54);
            this.butshow.TabIndex = 12;
            this.butshow.Text = "Tìm kiếm";
            this.butshow.UseVisualStyleBackColor = false;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 398);
            this.dataGridView1.TabIndex = 16;
            // 
            // cbbshow
            // 
            this.cbbshow.FormattingEnabled = true;
            this.cbbshow.Location = new System.Drawing.Point(110, 109);
            this.cbbshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbshow.Name = "cbbshow";
            this.cbbshow.Size = new System.Drawing.Size(154, 28);
            this.cbbshow.TabIndex = 21;
            this.cbbshow.SelectedIndexChanged += new System.EventHandler(this.cbbshow_SelectedIndexChanged_1);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(354, 109);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(247, 26);
            this.txtsearch.TabIndex = 27;
            this.txtsearch.Text = "nhập thông tin bạn muốn tìm kiếm";
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 693);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cbbshow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.butshow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infor";
            this.AutoSizeChanged += new System.EventHandler(this.btAdd_Click);
            this.TextChanged += new System.EventHandler(this.khachhang_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbshow;
        private System.Windows.Forms.TextBox txtsearch;
    }
}