namespace pbl.Admin
{
    partial class addschedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datengaydi = new System.Windows.Forms.DateTimePicker();
            this.cbbgaden = new System.Windows.Forms.ComboBox();
            this.cbbgadi = new System.Windows.Forms.ComboBox();
            this.bTOK = new System.Windows.Forms.Button();
            this.datengayden = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.datengayden);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datengaydi);
            this.panel1.Controls.Add(this.cbbgaden);
            this.panel1.Controls.Add(this.cbbgadi);
            this.panel1.Location = new System.Drawing.Point(27, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 286);
            this.panel1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(118, 231);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(172, 22);
            this.txtid.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "TÀU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "GA ĐI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "GA ĐẾN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "NGÀY ĐI :";
            // 
            // datengaydi
            // 
            this.datengaydi.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datengaydi.Location = new System.Drawing.Point(118, 122);
            this.datengaydi.Name = "datengaydi";
            this.datengaydi.Size = new System.Drawing.Size(253, 22);
            this.datengaydi.TabIndex = 21;
            // 
            // cbbgaden
            // 
            this.cbbgaden.FormattingEnabled = true;
            this.cbbgaden.Location = new System.Drawing.Point(118, 76);
            this.cbbgaden.Name = "cbbgaden";
            this.cbbgaden.Size = new System.Drawing.Size(172, 24);
            this.cbbgaden.TabIndex = 20;
            // 
            // cbbgadi
            // 
            this.cbbgadi.FormattingEnabled = true;
            this.cbbgadi.Location = new System.Drawing.Point(118, 24);
            this.cbbgadi.Name = "cbbgadi";
            this.cbbgadi.Size = new System.Drawing.Size(172, 24);
            this.cbbgadi.TabIndex = 19;
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(367, 343);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(75, 23);
            this.bTOK.TabIndex = 1;
            this.bTOK.Text = "OK";
            this.bTOK.UseVisualStyleBackColor = true;
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // datengayden
            // 
            this.datengayden.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datengayden.Location = new System.Drawing.Point(118, 180);
            this.datengayden.Name = "datengayden";
            this.datengayden.Size = new System.Drawing.Size(253, 22);
            this.datengayden.TabIndex = 27;
            // 
            // addschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(485, 387);
            this.Controls.Add(this.bTOK);
            this.Controls.Add(this.panel1);
            this.Name = "addschedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addschedule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datengaydi;
        private System.Windows.Forms.ComboBox cbbgaden;
        private System.Windows.Forms.ComboBox cbbgadi;
        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.DateTimePicker datengayden;
    }
}