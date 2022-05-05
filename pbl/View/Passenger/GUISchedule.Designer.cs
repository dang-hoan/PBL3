namespace pbl
{
    partial class GUISchedule
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.bPrivate = new System.Windows.Forms.Button();
            this.bSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(1, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1116, 642);
            this.panel_Main.TabIndex = 0;
            // 
            // bPrivate
            // 
            this.bPrivate.BackColor = System.Drawing.Color.Gray;
            this.bPrivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrivate.Location = new System.Drawing.Point(1, 644);
            this.bPrivate.Name = "bPrivate";
            this.bPrivate.Size = new System.Drawing.Size(158, 35);
            this.bPrivate.TabIndex = 1;
            this.bPrivate.Text = "Lịch trình cá nhân";
            this.bPrivate.UseVisualStyleBackColor = false;
            this.bPrivate.Click += new System.EventHandler(this.bPrivate_Click);
            // 
            // bSystem
            // 
            this.bSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSystem.Location = new System.Drawing.Point(156, 644);
            this.bSystem.Name = "bSystem";
            this.bSystem.Size = new System.Drawing.Size(169, 35);
            this.bSystem.TabIndex = 2;
            this.bSystem.Text = "Lịch trình hệ thống";
            this.bSystem.UseVisualStyleBackColor = true;
            this.bSystem.Click += new System.EventHandler(this.bSystem_Click);
            // 
            // GUISchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 691);
            this.Controls.Add(this.bSystem);
            this.Controls.Add(this.bPrivate);
            this.Controls.Add(this.panel_Main);
            this.Name = "GUISchedule";
            this.Text = "MainSchedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button bPrivate;
        private System.Windows.Forms.Button bSystem;
    }
}