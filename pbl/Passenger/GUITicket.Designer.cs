namespace pbl
{
    partial class GUITicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUITicket));
            this.panel_Content = new System.Windows.Forms.Panel();
            this.bShow = new System.Windows.Forms.Button();
            this.pSave = new System.Windows.Forms.PictureBox();
            this.cbbTrain = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bBook = new System.Windows.Forms.Button();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.pOption = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Controls.Add(this.bShow);
            this.panel_Content.Controls.Add(this.pSave);
            this.panel_Content.Controls.Add(this.cbbTrain);
            this.panel_Content.Controls.Add(this.bCancel);
            this.panel_Content.Controls.Add(this.bBook);
            this.panel_Content.Controls.Add(this.labelSchedule);
            this.panel_Content.Controls.Add(this.pOption);
            this.panel_Content.Controls.Add(this.dataGridView1);
            this.panel_Content.Location = new System.Drawing.Point(3, 2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1096, 689);
            this.panel_Content.TabIndex = 0;
            // 
            // bShow
            // 
            this.bShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShow.Location = new System.Drawing.Point(537, 63);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(139, 40);
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
            this.pSave.Location = new System.Drawing.Point(997, 648);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 31);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 58;
            this.pSave.TabStop = false;
            // 
            // cbbTrain
            // 
            this.cbbTrain.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrain.FormattingEnabled = true;
            this.cbbTrain.Location = new System.Drawing.Point(167, 50);
            this.cbbTrain.Name = "cbbTrain";
            this.cbbTrain.Size = new System.Drawing.Size(138, 27);
            this.cbbTrain.TabIndex = 49;
            this.cbbTrain.Text = "Tìm theo tàu";
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(898, 63);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(138, 40);
            this.bCancel.TabIndex = 48;
            this.bCancel.Text = "Huỷ vé";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bBook
            // 
            this.bBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBook.Location = new System.Drawing.Point(702, 63);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(170, 40);
            this.bBook.TabIndex = 47;
            this.bBook.Text = "Đặt vé mới";
            this.bBook.UseVisualStyleBackColor = false;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSchedule.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(50, 80);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(93, 23);
            this.labelSchedule.TabIndex = 45;
            this.labelSchedule.Text = "Lịch trình";
            this.labelSchedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // pOption
            // 
            this.pOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pOption.Image = ((System.Drawing.Image)(resources.GetObject("pOption.Image")));
            this.pOption.Location = new System.Drawing.Point(72, 41);
            this.pOption.Name = "pOption";
            this.pOption.Size = new System.Drawing.Size(45, 36);
            this.pOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOption.TabIndex = 44;
            this.pOption.TabStop = false;
            this.pOption.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 490);
            this.dataGridView1.TabIndex = 37;
            // 
            // GUITicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 693);
            this.Controls.Add(this.panel_Content);
            this.Name = "GUITicket";
            this.Text = "GUITicket";
            this.panel_Content.ResumeLayout(false);
            this.panel_Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.PictureBox pOption;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ComboBox cbbTrain;
        private System.Windows.Forms.PictureBox pSave;
        private System.Windows.Forms.Button bShow;
    }
}