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
            this.lbnd1.Location = new System.Drawing.Point(18, 40);
            this.lbnd1.Name = "lbnd1";
            this.lbnd1.Size = new System.Drawing.Size(994, 119);
            this.lbnd1.TabIndex = 0;
            this.lbnd1.Text = resources.GetString("lbnd1.Text");
            // 
            // ltd1
            // 
            this.ltd1.AutoSize = true;
            this.ltd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltd1.Location = new System.Drawing.Point(18, 9);
            this.ltd1.Name = "ltd1";
            this.ltd1.Size = new System.Drawing.Size(107, 18);
            this.ltd1.TabIndex = 1;
            this.ltd1.Text = "Thông báo 1 ";
            // 
            // lbtd2
            // 
            this.lbtd2.AutoSize = true;
            this.lbtd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtd2.Location = new System.Drawing.Point(18, 167);
            this.lbtd2.Name = "lbtd2";
            this.lbtd2.Size = new System.Drawing.Size(107, 18);
            this.lbtd2.TabIndex = 3;
            this.lbtd2.Text = "Thông báo 2 ";
            // 
            // lbnd3
            // 
            this.lbnd3.Location = new System.Drawing.Point(18, 394);
            this.lbnd3.Name = "lbnd3";
            this.lbnd3.Size = new System.Drawing.Size(994, 142);
            this.lbnd3.TabIndex = 2;
            this.lbnd3.Text = resources.GetString("lbnd3.Text");
            // 
            // lbtd3
            // 
            this.lbtd3.AutoSize = true;
            this.lbtd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtd3.Location = new System.Drawing.Point(23, 361);
            this.lbtd3.Name = "lbtd3";
            this.lbtd3.Size = new System.Drawing.Size(102, 18);
            this.lbtd3.TabIndex = 5;
            this.lbtd3.Text = "Thông báo 3";
            // 
            // lbnd2
            // 
            this.lbnd2.Location = new System.Drawing.Point(18, 205);
            this.lbnd2.Name = "lbnd2";
            this.lbnd2.Size = new System.Drawing.Size(994, 132);
            this.lbnd2.TabIndex = 4;
            this.lbnd2.Text = resources.GetString("lbnd2.Text");
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 568);
            this.Controls.Add(this.lbtd3);
            this.Controls.Add(this.lbnd2);
            this.Controls.Add(this.lbtd2);
            this.Controls.Add(this.lbnd3);
            this.Controls.Add(this.ltd1);
            this.Controls.Add(this.lbnd1);
            this.Name = "note";
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