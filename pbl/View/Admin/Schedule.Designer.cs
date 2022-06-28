namespace pbl.View
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelsche = new System.Windows.Forms.Panel();
            this.bShowAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Malt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelsche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsche
            // 
            this.panelsche.Controls.Add(this.bShowAll);
            this.panelsche.Controls.Add(this.pAdd);
            this.panelsche.Controls.Add(this.pSearch);
            this.panelsche.Controls.Add(this.pDelete);
            this.panelsche.Controls.Add(this.dtg);
            this.panelsche.Controls.Add(this.groupBox1);
            this.panelsche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsche.Location = new System.Drawing.Point(0, 0);
            this.panelsche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelsche.Name = "panelsche";
            this.panelsche.Size = new System.Drawing.Size(1508, 710);
            this.panelsche.TabIndex = 0;
            // 
            // bShowAll
            // 
            this.bShowAll.ActiveBorderThickness = 1;
            this.bShowAll.ActiveCornerRadius = 20;
            this.bShowAll.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bShowAll.ActiveForecolor = System.Drawing.Color.White;
            this.bShowAll.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bShowAll.BackColor = System.Drawing.Color.White;
            this.bShowAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bShowAll.BackgroundImage")));
            this.bShowAll.ButtonText = "Xem tất cả";
            this.bShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.bShowAll.IdleBorderThickness = 1;
            this.bShowAll.IdleCornerRadius = 20;
            this.bShowAll.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bShowAll.IdleForecolor = System.Drawing.Color.Black;
            this.bShowAll.IdleLineColor = System.Drawing.Color.Transparent;
            this.bShowAll.Location = new System.Drawing.Point(1109, 628);
            this.bShowAll.Margin = new System.Windows.Forms.Padding(6);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(155, 60);
            this.bShowAll.TabIndex = 53;
            this.bShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // pAdd
            // 
            this.pAdd.ActiveBorderThickness = 1;
            this.pAdd.ActiveCornerRadius = 20;
            this.pAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.pAdd.ActiveForecolor = System.Drawing.Color.White;
            this.pAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.pAdd.BackColor = System.Drawing.Color.White;
            this.pAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pAdd.BackgroundImage")));
            this.pAdd.ButtonText = "Thêm";
            this.pAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.pAdd.IdleBorderThickness = 1;
            this.pAdd.IdleCornerRadius = 20;
            this.pAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pAdd.IdleForecolor = System.Drawing.Color.Black;
            this.pAdd.IdleLineColor = System.Drawing.Color.Transparent;
            this.pAdd.Location = new System.Drawing.Point(929, 556);
            this.pAdd.Margin = new System.Windows.Forms.Padding(6);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(155, 60);
            this.pAdd.TabIndex = 45;
            this.pAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pAdd.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pSearch
            // 
            this.pSearch.ActiveBorderThickness = 1;
            this.pSearch.ActiveCornerRadius = 20;
            this.pSearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.pSearch.ActiveForecolor = System.Drawing.Color.White;
            this.pSearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.pSearch.BackColor = System.Drawing.Color.White;
            this.pSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pSearch.BackgroundImage")));
            this.pSearch.ButtonText = "Tìm kiếm";
            this.pSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.pSearch.IdleBorderThickness = 1;
            this.pSearch.IdleCornerRadius = 20;
            this.pSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pSearch.IdleForecolor = System.Drawing.Color.Black;
            this.pSearch.IdleLineColor = System.Drawing.Color.Transparent;
            this.pSearch.Location = new System.Drawing.Point(1109, 556);
            this.pSearch.Margin = new System.Windows.Forms.Padding(6);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(155, 60);
            this.pSearch.TabIndex = 46;
            this.pSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pSearch.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pDelete
            // 
            this.pDelete.ActiveBorderThickness = 1;
            this.pDelete.ActiveCornerRadius = 20;
            this.pDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.pDelete.ActiveForecolor = System.Drawing.Color.White;
            this.pDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.pDelete.BackColor = System.Drawing.Color.White;
            this.pDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pDelete.BackgroundImage")));
            this.pDelete.ButtonText = "Xoá";
            this.pDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.pDelete.IdleBorderThickness = 1;
            this.pDelete.IdleCornerRadius = 20;
            this.pDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pDelete.IdleForecolor = System.Drawing.Color.Black;
            this.pDelete.IdleLineColor = System.Drawing.Color.Transparent;
            this.pDelete.Location = new System.Drawing.Point(1289, 556);
            this.pDelete.Margin = new System.Windows.Forms.Padding(6);
            this.pDelete.Name = "pDelete";
            this.pDelete.Size = new System.Drawing.Size(155, 60);
            this.pDelete.TabIndex = 47;
            this.pDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pDelete.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // dtg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtg.DoubleBuffered = true;
            this.dtg.EnableHeadersVisualStyles = false;
            this.dtg.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtg.HeaderForeColor = System.Drawing.Color.Black;
            this.dtg.Location = new System.Drawing.Point(53, 55);
            this.dtg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidth = 51;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(836, 620);
            this.dtg.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ScheduleID";
            this.Column1.HeaderText = "Mã lịch trình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Departure";
            this.Column6.HeaderText = "Ga đi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Destination";
            this.Column7.HeaderText = "Ga đến";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DepartureTime";
            this.Column8.HeaderText = "Thời gian đi";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ArrivalTime";
            this.Column9.HeaderText = "Thời gian đến";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Controls.Add(this.dateDes);
            this.groupBox1.Controls.Add(this.cbbDes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateDep);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(929, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 465);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch trình";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "NGÀY ĐẾN :";
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(168, 45);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(284, 28);
            this.cbbDep.TabIndex = 37;
            this.cbbDep.Click += new System.EventHandler(this.cbbDep_Click);
            this.cbbDep.Leave += new System.EventHandler(this.cbbDep_Leave);
            // 
            // dateDes
            // 
            this.dateDes.CustomFormat = "dd/MM/yyyy";
            this.dateDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDes.Location = new System.Drawing.Point(168, 312);
            this.dateDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(284, 26);
            this.dateDes.TabIndex = 43;
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(168, 134);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(284, 28);
            this.cbbDes.TabIndex = 38;
            this.cbbDes.Click += new System.EventHandler(this.cbbDes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "GA ĐI :";
            // 
            // dateDep
            // 
            this.dateDep.CustomFormat = "dd/MM/yyyy";
            this.dateDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDep.Location = new System.Drawing.Point(168, 231);
            this.dateDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(284, 26);
            this.dateDep.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // Malt
            // 
            this.Malt.DataPropertyName = "ScheduleID";
            this.Malt.HeaderText = "Mã lịch trình";
            this.Malt.MinimumWidth = 6;
            this.Malt.Name = "Malt";
            this.Malt.ReadOnly = true;
            this.Malt.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Departure";
            this.Column2.HeaderText = "Ga đi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Destination";
            this.Column3.HeaderText = "Ga đến";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DepartureTime";
            this.Column4.HeaderText = "Thời gian đi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ArrivalTime";
            this.Column5.HeaderText = "Thời gian đến";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1508, 710);
            this.Controls.Add(this.panelsche);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.panelsche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelsche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Bunifu.Framework.UI.BunifuThinButton2 pDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 pSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 pAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 bShowAll;
    }
}