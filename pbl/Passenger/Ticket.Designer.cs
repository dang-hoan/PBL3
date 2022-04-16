namespace pbl
{
    partial class Ticket
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bBook = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(396, 31);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(128, 39);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel ticket";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bBook
            // 
            this.bBook.Location = new System.Drawing.Point(667, 31);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(141, 39);
            this.bBook.TabIndex = 2;
            this.bBook.Text = "Book new ticket";
            this.bBook.UseVisualStyleBackColor = true;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(948, 31);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(141, 39);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your booked tickets:";
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(142, 104);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(117, 28);
            this.cbbDep.TabIndex = 6;
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(404, 104);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(121, 28);
            this.cbbDes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Departure:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(298, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destination:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(561, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departure time";
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(136, 31);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(128, 39);
            this.bShow.TabIndex = 13;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(896, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destination time:";
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(684, 106);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(176, 26);
            this.dateDep.TabIndex = 16;
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(1023, 104);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(166, 26);
            this.dateDes.TabIndex = 17;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 500);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ticket";
            this.Text = "Ticket management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.DateTimePicker dateDes;
    }
}