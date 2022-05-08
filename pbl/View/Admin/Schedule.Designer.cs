namespace pbl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbgadi = new System.Windows.Forms.ComboBox();
            this.cbbgaden = new System.Windows.Forms.ComboBox();
            this.thoigiandi = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btaddschedule = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.thoigianden = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbbgadi
            // 
            this.cbbgadi.FormattingEnabled = true;
            this.cbbgadi.Location = new System.Drawing.Point(130, 26);
            this.cbbgadi.Name = "cbbgadi";
            this.cbbgadi.Size = new System.Drawing.Size(121, 24);
            this.cbbgadi.TabIndex = 1;
            // 
            // cbbgaden
            // 
            this.cbbgaden.FormattingEnabled = true;
            this.cbbgaden.Location = new System.Drawing.Point(130, 75);
            this.cbbgaden.Name = "cbbgaden";
            this.cbbgaden.Size = new System.Drawing.Size(121, 24);
            this.cbbgaden.TabIndex = 2;
            // 
            // thoigiandi
            // 
            this.thoigiandi.CustomFormat = "dd/MM/yyyy HH:mm";
            this.thoigiandi.Location = new System.Drawing.Point(446, 73);
            this.thoigiandi.Name = "thoigiandi";
            this.thoigiandi.Size = new System.Drawing.Size(240, 22);
            this.thoigiandi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(745, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "TÌM KIẾM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "GA ĐI :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(301, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "XÓA LỊCH TRÌNH";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btaddschedule
            // 
            this.btaddschedule.BackColor = System.Drawing.Color.Cyan;
            this.btaddschedule.Location = new System.Drawing.Point(64, 501);
            this.btaddschedule.Name = "btaddschedule";
            this.btaddschedule.Size = new System.Drawing.Size(177, 38);
            this.btaddschedule.TabIndex = 10;
            this.btaddschedule.Text = "THÊM LỊCH TRÌNH";
            this.btaddschedule.UseVisualStyleBackColor = false;
            this.btaddschedule.Click += new System.EventHandler(this.btaddschedule_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(755, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // thoigianden
            // 
            this.thoigianden.CustomFormat = "dd/MM/yyyy HH:mm";
            this.thoigianden.Location = new System.Drawing.Point(446, 23);
            this.thoigianden.Name = "thoigianden";
            this.thoigianden.Size = new System.Drawing.Size(240, 22);
            this.thoigianden.TabIndex = 20;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(953, 606);
            this.Controls.Add(this.thoigianden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btaddschedule);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thoigiandi);
            this.Controls.Add(this.cbbgaden);
            this.Controls.Add(this.cbbgadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbgadi;
        private System.Windows.Forms.ComboBox cbbgaden;
        private System.Windows.Forms.DateTimePicker thoigiandi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btaddschedule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker thoigianden;
    }
}