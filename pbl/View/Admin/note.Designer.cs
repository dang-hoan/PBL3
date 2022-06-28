namespace pbl
{
    partial class note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(note));
            this.lbnd1 = new System.Windows.Forms.Label();
            this.ltd1 = new System.Windows.Forms.Label();
            this.lbtd2 = new System.Windows.Forms.Label();
            this.lbnd3 = new System.Windows.Forms.Label();
            this.lbtd3 = new System.Windows.Forms.Label();
            this.lbnd2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnd1
            // 
            this.lbnd1.Location = new System.Drawing.Point(20, 50);
            this.lbnd1.Name = "lbnd1";
            this.lbnd1.Size = new System.Drawing.Size(1118, 149);
            this.lbnd1.TabIndex = 0;
            this.lbnd1.Text = resources.GetString("lbnd1.Text");
            // 
            // ltd1
            // 
            this.ltd1.AutoSize = true;
            this.ltd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltd1.Location = new System.Drawing.Point(20, 11);
            this.ltd1.Name = "ltd1";
            this.ltd1.Size = new System.Drawing.Size(129, 22);
            this.ltd1.TabIndex = 1;
            this.ltd1.Text = "Thông báo 1 ";
            // 
            // lbtd2
            // 
            this.lbtd2.AutoSize = true;
            this.lbtd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtd2.Location = new System.Drawing.Point(20, 209);
            this.lbtd2.Name = "lbtd2";
            this.lbtd2.Size = new System.Drawing.Size(129, 22);
            this.lbtd2.TabIndex = 3;
            this.lbtd2.Text = "Thông báo 2 ";
            // 
            // lbnd3
            // 
            this.lbnd3.Location = new System.Drawing.Point(20, 492);
            this.lbnd3.Name = "lbnd3";
            this.lbnd3.Size = new System.Drawing.Size(1118, 178);
            this.lbnd3.TabIndex = 2;
            this.lbnd3.Text = resources.GetString("lbnd3.Text");
            // 
            // lbtd3
            // 
            this.lbtd3.AutoSize = true;
            this.lbtd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtd3.Location = new System.Drawing.Point(26, 451);
            this.lbtd3.Name = "lbtd3";
            this.lbtd3.Size = new System.Drawing.Size(123, 22);
            this.lbtd3.TabIndex = 5;
            this.lbtd3.Text = "Thông báo 3";
            // 
            // lbnd2
            // 
            this.lbnd2.Location = new System.Drawing.Point(20, 256);
            this.lbnd2.Name = "lbnd2";
            this.lbnd2.Size = new System.Drawing.Size(1118, 165);
            this.lbnd2.TabIndex = 4;
            this.lbnd2.Text = resources.GetString("lbnd2.Text");
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 710);
            this.Controls.Add(this.lbtd3);
            this.Controls.Add(this.lbnd2);
            this.Controls.Add(this.lbtd2);
            this.Controls.Add(this.lbnd3);
            this.Controls.Add(this.ltd1);
            this.Controls.Add(this.lbnd1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnd1;
        private System.Windows.Forms.Label ltd1;
        private System.Windows.Forms.Label lbtd2;
        private System.Windows.Forms.Label lbnd3;
        private System.Windows.Forms.Label lbtd3;
        private System.Windows.Forms.Label lbnd2;
    }
}