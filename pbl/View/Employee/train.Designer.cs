namespace pbl.View
{
    partial class train
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
            this.buttrain = new System.Windows.Forms.Button();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butall = new System.Windows.Forms.Button();
            this.butdelte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butve = new System.Windows.Forms.Button();
            this.cbbtrangthai = new System.Windows.Forms.ComboBox();
            this.Trangthai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttrain
            // 
            this.buttrain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttrain.Location = new System.Drawing.Point(242, 452);
            this.buttrain.Name = "buttrain";
            this.buttrain.Size = new System.Drawing.Size(130, 33);
            this.buttrain.TabIndex = 151;
            this.buttrain.Text = "Thêm chuyến tàu";
            this.buttrain.UseVisualStyleBackColor = false;
            this.buttrain.Click += new System.EventHandler(this.buttrain_Click);
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(392, 47);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(208, 24);
            this.cbbDes.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Ga đến:";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearch.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(782, 47);
            this.bSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(84, 49);
            this.bSearch.TabIndex = 146;
            this.bSearch.Text = "Tìm kiếm";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(37, 46);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(208, 24);
            this.cbbDep.TabIndex = 144;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 140;
            this.label10.Text = "Ga đi:";
            // 
            // butall
            // 
            this.butall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butall.Location = new System.Drawing.Point(505, 452);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(128, 33);
            this.butall.TabIndex = 139;
            this.butall.Text = "Xem tất cả";
            this.butall.UseVisualStyleBackColor = false;
            this.butall.Click += new System.EventHandler(this.butall_Click);
            // 
            // butdelte
            // 
            this.butdelte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butdelte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelte.Location = new System.Drawing.Point(749, 452);
            this.butdelte.Name = "butdelte";
            this.butdelte.Size = new System.Drawing.Size(117, 33);
            this.butdelte.TabIndex = 138;
            this.butdelte.Text = "xóa chuyến";
            this.butdelte.UseVisualStyleBackColor = false;
            this.butdelte.Click += new System.EventHandler(this.butdelte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 275);
            this.dataGridView1.TabIndex = 137;
            // 
            // butve
            // 
            this.butve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butve.Location = new System.Drawing.Point(24, 452);
            this.butve.Name = "butve";
            this.butve.Size = new System.Drawing.Size(130, 33);
            this.butve.TabIndex = 152;
            this.butve.Text = "Thêm vé";
            this.butve.UseVisualStyleBackColor = false;
            this.butve.Click += new System.EventHandler(this.butve_Click);
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.Location = new System.Drawing.Point(37, 115);
            this.cbbtrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.Size = new System.Drawing.Size(208, 24);
            this.cbbtrangthai.TabIndex = 154;
            // 
            // Trangthai
            // 
            this.Trangthai.AutoSize = true;
            this.Trangthai.Location = new System.Drawing.Point(44, 91);
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Size = new System.Drawing.Size(79, 16);
            this.Trangthai.TabIndex = 153;
            this.Trangthai.Text = "Trạng Thái :";
            // 
            // train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(896, 554);
            this.Controls.Add(this.cbbtrangthai);
            this.Controls.Add(this.Trangthai);
            this.Controls.Add(this.butve);
            this.Controls.Add(this.buttrain);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.butall);
            this.Controls.Add(this.butdelte);
            this.Controls.Add(this.dataGridView1);
            this.Name = "train";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttrain;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.Button butdelte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butve;
        private System.Windows.Forms.ComboBox cbbtrangthai;
        private System.Windows.Forms.Label Trangthai;
    }
}