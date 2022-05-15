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
            this.cbbshow = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butdel
            // 
            this.butdel.BackColor = System.Drawing.Color.Aqua;
            this.butdel.Location = new System.Drawing.Point(639, 439);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(147, 40);
            this.butdel.TabIndex = 15;
            this.butdel.Text = "XÓA";
            this.butdel.UseVisualStyleBackColor = false;
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.Color.Aqua;
            this.butsua.Location = new System.Drawing.Point(370, 439);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(147, 40);
            this.butsua.TabIndex = 14;
            this.butsua.Text = "SỬA";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Aqua;
            this.btAdd.Location = new System.Drawing.Point(70, 439);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(147, 40);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "THÊM";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // butshow
            // 
            this.butshow.BackColor = System.Drawing.Color.Aqua;
            this.butshow.Location = new System.Drawing.Point(695, 26);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(147, 43);
            this.butshow.TabIndex = 12;
            this.butshow.Text = "XEM";
            this.butshow.UseVisualStyleBackColor = false;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 318);
            this.dataGridView1.TabIndex = 16;
            // 
            // cbbshow
            // 
            this.cbbshow.FormattingEnabled = true;
            this.cbbshow.Location = new System.Drawing.Point(490, 40);
            this.cbbshow.Name = "cbbshow";
            this.cbbshow.Size = new System.Drawing.Size(184, 24);
            this.cbbshow.TabIndex = 17;
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(915, 533);
            this.Controls.Add(this.cbbshow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butdel);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.butshow);
            this.Name = "khachhang";
            this.Text = "infor";
            this.AutoSizeChanged += new System.EventHandler(this.btAdd_Click);
            this.TextChanged += new System.EventHandler(this.khachhang_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butdel;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbshow;
    }
}