namespace pbl
{
    partial class GUIFeedback
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
            this.labelStar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.bDeleteAll = new System.Windows.Forms.Button();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStar
            // 
            this.labelStar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.Location = new System.Drawing.Point(232, 199);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(175, 35);
            this.labelStar.TabIndex = 2;
            this.labelStar.Text = "Đánh giá của bạn:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ý kiến cá nhân:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(224, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hãy cho chúng tôi biết ý kiến của bạn để chúng tôi làm cho sản phẩm ngày càng hoà" +
    "n thiện hơn!";
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSend.Location = new System.Drawing.Point(346, 560);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(99, 38);
            this.bSend.TabIndex = 6;
            this.bSend.Text = "Gửi";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bDeleteAll
            // 
            this.bDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bDeleteAll.Location = new System.Drawing.Point(484, 560);
            this.bDeleteAll.Name = "bDeleteAll";
            this.bDeleteAll.Size = new System.Drawing.Size(146, 38);
            this.bDeleteAll.TabIndex = 7;
            this.bDeleteAll.Text = "Xoá hết phản hồi";
            this.bDeleteAll.UseVisualStyleBackColor = false;
            this.bDeleteAll.Click += new System.EventHandler(this.bDeleteAll_Click);
            // 
            // txtOpinion
            // 
            this.txtOpinion.Location = new System.Drawing.Point(236, 319);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.Size = new System.Drawing.Size(588, 214);
            this.txtOpinion.TabIndex = 8;
            // 
            // GUIFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 673);
            this.Controls.Add(this.txtOpinion);
            this.Controls.Add(this.bDeleteAll);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStar);
            this.Name = "GUIFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẢN HỒI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bDeleteAll;
        private System.Windows.Forms.TextBox txtOpinion;
    }
}