namespace pbl
{
    partial class GUIChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAgree = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.cbViewPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Nhập mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(219, 73);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(290, 26);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // bAgree
            // 
            this.bAgree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAgree.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgree.Location = new System.Drawing.Point(177, 183);
            this.bAgree.Name = "bAgree";
            this.bAgree.Size = new System.Drawing.Size(84, 36);
            this.bAgree.TabIndex = 3;
            this.bAgree.Text = "Đồng ý";
            this.bAgree.UseVisualStyleBackColor = false;
            this.bAgree.Click += new System.EventHandler(this.bAgree_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bBack.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.Location = new System.Drawing.Point(306, 183);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(84, 36);
            this.bBack.TabIndex = 4;
            this.bBack.Text = "Quay lại";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(219, 121);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(290, 26);
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.Leave += new System.EventHandler(this.txtConfirmPass_Leave);
            // 
            // cbViewPass
            // 
            this.cbViewPass.AutoSize = true;
            this.cbViewPass.BackColor = System.Drawing.Color.Transparent;
            this.cbViewPass.ForeColor = System.Drawing.Color.White;
            this.cbViewPass.Location = new System.Drawing.Point(350, 153);
            this.cbViewPass.Name = "cbViewPass";
            this.cbViewPass.Size = new System.Drawing.Size(159, 24);
            this.cbViewPass.TabIndex = 5;
            this.cbViewPass.Text = "Hiển thị mật khẩu";
            this.cbViewPass.UseVisualStyleBackColor = false;
            this.cbViewPass.Click += new System.EventHandler(this.cbViewPass_Click);
            // 
            // GUIChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 242);
            this.Controls.Add(this.cbViewPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bAgree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "GUIChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUIChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAgree;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.CheckBox cbViewPass;
    }
}