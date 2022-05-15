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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgridemploy = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btsort = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridemploy)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtgridemploy);
            this.panel1.Location = new System.Drawing.Point(50, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 464);
            this.panel1.TabIndex = 0;
            // 
            // dtgridemploy
            // 
            this.dtgridemploy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridemploy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridemploy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridemploy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridemploy.ColumnHeadersHeight = 30;
            this.dtgridemploy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridemploy.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridemploy.Location = new System.Drawing.Point(0, 0);
            this.dtgridemploy.Name = "dtgridemploy";
            this.dtgridemploy.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridemploy.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridemploy.RowHeadersVisible = false;
            this.dtgridemploy.RowHeadersWidth = 51;
            this.dtgridemploy.RowTemplate.Height = 24;
            this.dtgridemploy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridemploy.Size = new System.Drawing.Size(834, 461);
            this.dtgridemploy.TabIndex = 0;
            this.dtgridemploy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridemploy_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(549, 14);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(142, 33);
            this.txtsearch.TabIndex = 5;
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
            this.panel2.Controls.Add(this.btsort);
            this.panel2.Controls.Add(this.btxoa);
            this.panel2.Controls.Add(this.btsua);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.bttimkiem);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 694);
            this.panel2.TabIndex = 1;
            // 
            // btsort
            // 
            this.btsort.BackColor = System.Drawing.Color.Aqua;
            this.btsort.Location = new System.Drawing.Point(693, 590);
            this.btsort.Name = "btsort";
            this.btsort.Size = new System.Drawing.Size(145, 33);
            this.btsort.TabIndex = 10;
            this.btsort.Text = "SẮP XẾP";
            this.btsort.UseVisualStyleBackColor = false;
            this.btsort.Click += new System.EventHandler(this.btsort_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Aqua;
            this.btxoa.Location = new System.Drawing.Point(453, 590);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(147, 33);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.Color.Aqua;
            this.btsua.Location = new System.Drawing.Point(249, 590);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(147, 33);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "SỬA";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgridemploy)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dtgridemploy;
        private System.Windows.Forms.Button btsort;
    }
}