namespace pbl.View
{
    partial class Form1
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
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFromDep = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateToDep = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFromDes = new System.Windows.Forms.DateTimePicker();
            this.dateToDes = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbbDes
            // 
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(518, 26);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(234, 28);
            this.cbbDes.TabIndex = 57;
            // 
            // cbbDep
            // 
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(130, 26);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(234, 28);
            this.cbbDep.TabIndex = 56;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(443, 176);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 32);
            this.bCancel.TabIndex = 47;
            this.bCancel.Text = "Huỷ";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(212, 176);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(104, 32);
            this.bAccept.TabIndex = 46;
            this.bAccept.Text = "Chấp nhận";
            this.bAccept.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Thời gian đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Thời gian đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ga đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ga đi";
            // 
            // dateFromDep
            // 
            this.dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDep.Location = new System.Drawing.Point(226, 80);
            this.dateFromDep.Name = "dateFromDep";
            this.dateFromDep.Size = new System.Drawing.Size(200, 26);
            this.dateFromDep.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Từ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Đến:";
            // 
            // dateToDep
            // 
            this.dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDep.Location = new System.Drawing.Point(509, 80);
            this.dateToDep.Name = "dateToDep";
            this.dateToDep.Size = new System.Drawing.Size(200, 26);
            this.dateToDep.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Từ:";
            // 
            // dateFromDes
            // 
            this.dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateFromDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFromDes.Location = new System.Drawing.Point(226, 126);
            this.dateFromDes.Name = "dateFromDes";
            this.dateFromDes.Size = new System.Drawing.Size(200, 26);
            this.dateFromDes.TabIndex = 66;
            // 
            // dateToDes
            // 
            this.dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateToDes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateToDes.Location = new System.Drawing.Point(509, 126);
            this.dateToDes.Name = "dateToDes";
            this.dateToDes.Size = new System.Drawing.Size(200, 26);
            this.dateToDes.TabIndex = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 225);
            this.Controls.Add(this.dateToDes);
            this.Controls.Add(this.dateFromDes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateToDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFromDep);
            this.Controls.Add(this.cbbDes);
            this.Controls.Add(this.cbbDep);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFromDep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateToDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFromDes;
        private System.Windows.Forms.DateTimePicker dateToDes;
    }
}