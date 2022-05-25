namespace pbl
{
    partial class InputPass
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
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.bAccept = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.cbViewPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hãy nhập mật khẩu của bạn để xác nhận bạn là chủ tài khoản!";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(148, 61);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(250, 26);
            this.txtConfirmPass.TabIndex = 1;
            // 
            // bAccept
            // 
            this.bAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAccept.Location = new System.Drawing.Point(155, 123);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(129, 36);
            this.bAccept.TabIndex = 2;
            this.bAccept.Text = "Chấp nhận";
            this.bAccept.UseVisualStyleBackColor = false;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBack.Location = new System.Drawing.Point(295, 123);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(88, 36);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "Quay lại";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // cbViewPass
            // 
            this.cbViewPass.AutoSize = true;
            this.cbViewPass.BackColor = System.Drawing.Color.Transparent;
            this.cbViewPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewPass.ForeColor = System.Drawing.Color.Black;
            this.cbViewPass.Location = new System.Drawing.Point(234, 93);
            this.cbViewPass.Name = "cbViewPass";
            this.cbViewPass.Size = new System.Drawing.Size(164, 24);
            this.cbViewPass.TabIndex = 4;
            this.cbViewPass.Text = "Hiển thị mật khẩu";
            this.cbViewPass.UseVisualStyleBackColor = false;
            this.cbViewPass.Click += new System.EventHandler(this.cbViewPass_Click);
            // 
            // InputPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 181);
            this.Controls.Add(this.cbViewPass);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label1);
            this.Name = "InputPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÁC NHẬN DANH TÍNH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.CheckBox cbViewPass;
    }
}