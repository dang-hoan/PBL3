namespace pbl.View
{
    partial class qlve
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butsearch = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butxoave = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.process1 = new System.Diagnostics.Process();
            this.cbbook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butmuave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 321);
            this.dataGridView1.TabIndex = 100;
            // 
            // butsearch
            // 
            this.butsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsearch.Location = new System.Drawing.Point(855, 84);
            this.butsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(98, 44);
            this.butsearch.TabIndex = 98;
            this.butsearch.Text = "Tìm kiếm";
            this.butsearch.UseVisualStyleBackColor = false;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // butthem
            // 
            this.butthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthem.Location = new System.Drawing.Point(411, 586);
            this.butthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(166, 44);
            this.butthem.TabIndex = 97;
            this.butthem.Text = "Thêm vé mới";
            this.butthem.UseVisualStyleBackColor = false;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Ga đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Ga đến";
            // 
            // butxoave
            // 
            this.butxoave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butxoave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoave.Location = new System.Drawing.Point(855, 586);
            this.butxoave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butxoave.Name = "butxoave";
            this.butxoave.Size = new System.Drawing.Size(107, 44);
            this.butxoave.TabIndex = 118;
            this.butxoave.Text = "Xóa  vé";
            this.butxoave.UseVisualStyleBackColor = false;
            this.butxoave.Click += new System.EventHandler(this.butxoave_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(196, 25);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(224, 28);
            this.cbbDep.TabIndex = 119;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(574, 25);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 120;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            this.process1.Exited += new System.EventHandler(this.process1_Exited);
            // 
            // cbbook
            // 
            this.cbbook.FormattingEnabled = true;
            this.cbbook.Location = new System.Drawing.Point(196, 98);
            this.cbbook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbook.Name = "cbbook";
            this.cbbook.Size = new System.Drawing.Size(234, 28);
            this.cbbook.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Trạng Thái vé";
            // 
            // butmuave
            // 
            this.butmuave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butmuave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmuave.Location = new System.Drawing.Point(36, 589);
            this.butmuave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butmuave.Name = "butmuave";
            this.butmuave.Size = new System.Drawing.Size(146, 41);
            this.butmuave.TabIndex = 131;
            this.butmuave.Text = "mua  vé";
            this.butmuave.UseVisualStyleBackColor = false;
            this.butmuave.Click += new System.EventHandler(this.butmuave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(789, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 132;
            this.button1.Text = "Xem Tất cả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qlve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1029, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butmuave);
            this.Controls.Add(this.cbbook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.butxoave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butsearch);
            this.Controls.Add(this.butthem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "qlve";
            this.Text = "quản lý vé";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butxoave;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ComboBox cbbook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butmuave;
        private System.Windows.Forms.Button button1;
    }
}