namespace pbl.View.Admin
{
    partial class Notice
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bConfirm = new pbl.RJButton();
            this.bNew = new pbl.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIÊU ĐỀ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NỘI DUNG";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(53, 195);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1228, 305);
            this.txtContent.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(53, 97);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1228, 51);
            this.txtTitle.TabIndex = 3;
            // 
            // bConfirm
            // 
            this.bConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.bConfirm.FlatAppearance.BorderSize = 0;
            this.bConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirm.ForeColor = System.Drawing.Color.White;
            this.bConfirm.Location = new System.Drawing.Point(365, 525);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(150, 40);
            this.bConfirm.TabIndex = 4;
            this.bConfirm.Text = "Xác nhận";
            this.bConfirm.UseVisualStyleBackColor = false;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bNew
            // 
            this.bNew.BackColor = System.Drawing.Color.SeaGreen;
            this.bNew.FlatAppearance.BorderSize = 0;
            this.bNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNew.ForeColor = System.Drawing.Color.White;
            this.bNew.Location = new System.Drawing.Point(808, 525);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(150, 40);
            this.bNew.TabIndex = 5;
            this.bNew.Text = "Tạo cái mới";
            this.bNew.UseVisualStyleBackColor = false;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(507, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "VIẾT THÔNG BÁO";
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 607);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Notice";
            this.Text = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private RJButton bConfirm;
        private RJButton bNew;
        private System.Windows.Forms.Label label3;
    }
}