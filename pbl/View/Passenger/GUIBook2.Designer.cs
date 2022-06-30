namespace pbl
{
    partial class GUIBook2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIBook2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUnbooked = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bShowAll = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.pSave = new System.Windows.Forms.PictureBox();
            this.labelBooked = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCarriage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pLeft = new System.Windows.Forms.PictureBox();
            this.pRight = new System.Windows.Forms.PictureBox();
            this.cbbTrain = new System.Windows.Forms.ComboBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelUnbooked);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bShowAll);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.pSave);
            this.panel1.Controls.Add(this.labelBooked);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelCarriage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pLeft);
            this.panel1.Controls.Add(this.pRight);
            this.panel1.Controls.Add(this.cbbTrain);
            this.panel1.Controls.Add(this.bBack);
            this.panel1.Controls.Add(this.bBook);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 611);
            this.panel1.TabIndex = 0;
            // 
            // labelUnbooked
            // 
            this.labelUnbooked.AutoSize = true;
            this.labelUnbooked.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnbooked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelUnbooked.Location = new System.Drawing.Point(667, 65);
            this.labelUnbooked.Name = "labelUnbooked";
            this.labelUnbooked.Size = new System.Drawing.Size(61, 68);
            this.labelUnbooked.TabIndex = 62;
            this.labelUnbooked.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Số vé chưa bán";
            // 
            // bShowAll
            // 
            this.bShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowAll.Location = new System.Drawing.Point(568, 538);
            this.bShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(129, 40);
            this.bShowAll.TabIndex = 60;
            this.bShowAll.Text = "Xem tất cả";
            this.bShowAll.UseVisualStyleBackColor = false;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(827, 98);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(115, 40);
            this.bSearch.TabIndex = 59;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.Green;
            this.pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSave.Image = ((System.Drawing.Image)(resources.GetObject("pSave.Image")));
            this.pSave.Location = new System.Drawing.Point(28, 540);
            this.pSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 32);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 58;
            this.pSave.TabStop = false;
            this.pSave.Click += new System.EventHandler(this.pSave_Click);
            // 
            // labelBooked
            // 
            this.labelBooked.AutoSize = true;
            this.labelBooked.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooked.ForeColor = System.Drawing.Color.Red;
            this.labelBooked.Location = new System.Drawing.Point(507, 65);
            this.labelBooked.Name = "labelBooked";
            this.labelBooked.Size = new System.Drawing.Size(61, 68);
            this.labelBooked.TabIndex = 13;
            this.labelBooked.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số vé đã bán";
            // 
            // labelCarriage
            // 
            this.labelCarriage.AutoSize = true;
            this.labelCarriage.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarriage.Location = new System.Drawing.Point(338, 80);
            this.labelCarriage.Name = "labelCarriage";
            this.labelCarriage.Size = new System.Drawing.Size(36, 40);
            this.labelCarriage.TabIndex = 10;
            this.labelCarriage.Text = "1";
            this.labelCarriage.Click += new System.EventHandler(this.labelCarriage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn toa";
            // 
            // pLeft
            // 
            this.pLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLeft.Image = ((System.Drawing.Image)(resources.GetObject("pLeft.Image")));
            this.pLeft.Location = new System.Drawing.Point(295, 78);
            this.pLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(25, 50);
            this.pLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLeft.TabIndex = 8;
            this.pLeft.TabStop = false;
            this.pLeft.Click += new System.EventHandler(this.pLeft_Click);
            // 
            // pRight
            // 
            this.pRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pRight.Image = ((System.Drawing.Image)(resources.GetObject("pRight.Image")));
            this.pRight.Location = new System.Drawing.Point(390, 78);
            this.pRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(25, 50);
            this.pRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pRight.TabIndex = 7;
            this.pRight.TabStop = false;
            this.pRight.Click += new System.EventHandler(this.pRight_Click);
            // 
            // cbbTrain
            // 
            this.cbbTrain.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrain.FormattingEnabled = true;
            this.cbbTrain.Location = new System.Drawing.Point(88, 40);
            this.cbbTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTrain.Name = "cbbTrain";
            this.cbbTrain.Size = new System.Drawing.Size(138, 27);
            this.cbbTrain.TabIndex = 6;
            this.cbbTrain.Text = "Chọn một tàu";
            this.cbbTrain.SelectedIndexChanged += new System.EventHandler(this.cbbTrain_SelectedIndexChanged);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(828, 538);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(114, 40);
            this.bBack.TabIndex = 4;
            this.bBack.Text = "Quay lại";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bBook
            // 
            this.bBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.Location = new System.Drawing.Point(703, 538);
            this.bBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(119, 40);
            this.bBook.TabIndex = 3;
            this.bBook.Text = "Đặt vé";
            this.bBook.UseVisualStyleBackColor = false;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(88, 50);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(138, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // GUIBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 616);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUIBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT VÉ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ComboBox cbbTrain;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCarriage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pLeft;
        private System.Windows.Forms.PictureBox pRight;
        private System.Windows.Forms.Label labelBooked;
        private System.Windows.Forms.PictureBox pSave;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bShowAll;
        private System.Windows.Forms.Label labelUnbooked;
        private System.Windows.Forms.Label label6;
    }
}