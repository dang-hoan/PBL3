﻿namespace pbl
{
    partial class GUIBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bShow = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.bShow);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 611);
            this.panel1.TabIndex = 0;
            // 
            // bShow
            // 
            this.bShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShow.Location = new System.Drawing.Point(377, 537);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(170, 40);
            this.bShow.TabIndex = 59;
            this.bShow.Text = "Hiển thị";
            this.bShow.UseVisualStyleBackColor = false;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // pSave
            // 
            this.pSave.BackColor = System.Drawing.Color.Green;
            this.pSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSave.Image = ((System.Drawing.Image)(resources.GetObject("pSave.Image")));
            this.pSave.Location = new System.Drawing.Point(28, 540);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 33);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 58;
            this.pSave.TabStop = false;
            // 
            // labelBooked
            // 
            this.labelBooked.AutoSize = true;
            this.labelBooked.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooked.ForeColor = System.Drawing.Color.Red;
            this.labelBooked.Location = new System.Drawing.Point(659, 70);
            this.labelBooked.Name = "labelBooked";
            this.labelBooked.Size = new System.Drawing.Size(61, 68);
            this.labelBooked.TabIndex = 13;
            this.labelBooked.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số vé đã bán của tàu";
            // 
            // labelCarriage
            // 
            this.labelCarriage.AutoSize = true;
            this.labelCarriage.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarriage.Location = new System.Drawing.Point(455, 83);
            this.labelCarriage.Name = "labelCarriage";
            this.labelCarriage.Size = new System.Drawing.Size(36, 40);
            this.labelCarriage.TabIndex = 10;
            this.labelCarriage.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn toa";
            // 
            // pLeft
            // 
            this.pLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLeft.Image = ((System.Drawing.Image)(resources.GetObject("pLeft.Image")));
            this.pLeft.Location = new System.Drawing.Point(412, 81);
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
            this.pRight.Location = new System.Drawing.Point(507, 81);
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
            this.cbbTrain.Location = new System.Drawing.Point(205, 43);
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
            this.bBack.Location = new System.Drawing.Point(772, 537);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(170, 40);
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
            this.bBook.Location = new System.Drawing.Point(577, 537);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(170, 40);
            this.bBook.TabIndex = 3;
            this.bBook.Text = "Đặt vé";
            this.bBook.UseVisualStyleBackColor = false;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 173);
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
            this.pictureBox4.Location = new System.Drawing.Point(205, 53);
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
            this.Name = "GUIBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUIBook";
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
        private System.Windows.Forms.Button bShow;
    }
}