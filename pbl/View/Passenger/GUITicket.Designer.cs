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
            this.bShowAll = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.pSave = new System.Windows.Forms.PictureBox();
            this.cbbTrain = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
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
            this.panel_Content.Controls.Add(this.bShowAll);
            this.panel_Content.Controls.Add(this.bSearch);
            this.panel_Content.Controls.Add(this.pSave);
            this.panel_Content.Controls.Add(this.cbbTrain);
            this.panel_Content.Controls.Add(this.bCancel);
            this.panel_Content.Controls.Add(this.labelSchedule);
            this.panel_Content.Controls.Add(this.pOption);
            this.panel_Content.Controls.Add(this.dataGridView1);
            this.panel_Content.Location = new System.Drawing.Point(3, 2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1093, 692);
            this.panel_Content.TabIndex = 0;
            // 
            // bShowAll
            // 
            this.bShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowAll.Location = new System.Drawing.Point(751, 622);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(139, 40);
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
            this.bSearch.Location = new System.Drawing.Point(896, 43);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(139, 40);
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
            this.pSave.Location = new System.Drawing.Point(54, 622);
            this.pSave.Name = "pSave";
            this.pSave.Size = new System.Drawing.Size(53, 31);
            this.pSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSave.TabIndex = 58;
            this.pSave.TabStop = false;
            this.pSave.Click += new System.EventHandler(this.pSave_Click);
            // 
            // cbbTrain
            // 
            this.cbbTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTrain.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrain.FormattingEnabled = true;
            this.cbbTrain.Location = new System.Drawing.Point(731, 52);
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
            this.bCancel.Location = new System.Drawing.Point(896, 622);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(138, 40);
            this.bCancel.TabIndex = 48;
            this.bCancel.Text = "Huỷ vé";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSchedule.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchedule.Location = new System.Drawing.Point(49, 67);
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
            this.pOption.Location = new System.Drawing.Point(71, 28);
            this.pOption.Name = "pOption";
            this.pOption.Size = new System.Drawing.Size(45, 36);
            this.pOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOption.TabIndex = 44;
            this.pOption.TabStop = false;
            this.pOption.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ComboBox cbbTrain;
        private System.Windows.Forms.PictureBox pSave;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bShowAll;
    }
}