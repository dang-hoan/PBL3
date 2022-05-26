namespace pbl.View.Admin
{
    partial class searchnv
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
            this.label10 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(28, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 39);
            this.label10.TabIndex = 23;
            this.label10.Text = "Welcome to DNtrain";
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.Cyan;
            this.btsearch.Location = new System.Drawing.Point(732, 94);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(144, 34);
            this.btsearch.TabIndex = 25;
            this.btsearch.Text = "TÌM KIẾM";
            this.btsearch.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(481, 94);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(223, 34);
            this.txtsearch.TabIndex = 24;
            this.txtsearch.Text = "Nhập tên hoặc ID nhân viên";
            // 
            // searchnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(913, 590);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "searchnv";
            this.Text = "Tìm kiếm nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtsearch;
    }
}