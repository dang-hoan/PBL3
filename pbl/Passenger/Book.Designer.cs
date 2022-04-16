namespace pbl
{
    partial class Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.bBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Destination time";
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(154, 121);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(96, 24);
            this.rbOne.TabIndex = 4;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "One-way";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Location = new System.Drawing.Point(335, 121);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(109, 24);
            this.rbRound.TabIndex = 5;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Round-trip";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(144, 72);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(225, 26);
            this.txtDep.TabIndex = 6;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(504, 75);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(234, 26);
            this.txtDes.TabIndex = 7;
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(178, 164);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(225, 26);
            this.dateDep.TabIndex = 8;
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(542, 164);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(234, 26);
            this.dateDes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(43, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Choose your schedule!";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(113, 215);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(90, 32);
            this.bSearch.TabIndex = 12;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(581, 215);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(90, 32);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bBook
            // 
            this.bBook.Location = new System.Drawing.Point(268, 215);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(90, 32);
            this.bBook.TabIndex = 14;
            this.bBook.Text = "Book";
            this.bBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(747, 216);
            this.dataGridView1.TabIndex = 15;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(422, 215);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 32);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.rbRound);
            this.Controls.Add(this.rbOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.Text = "Book new ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCancel;
    }
}