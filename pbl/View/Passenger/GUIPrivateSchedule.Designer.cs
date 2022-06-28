namespace pbl
{
    partial class GUIPrivateSchedule
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
            this.bList = new System.Windows.Forms.Button();
            this.bCalendar = new System.Windows.Forms.Button();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bList
            // 
            this.bList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bList.Location = new System.Drawing.Point(3, 167);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(178, 62);
            this.bList.TabIndex = 45;
            this.bList.Text = "Xem chi tiết";
            this.bList.UseVisualStyleBackColor = false;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // bCalendar
            // 
            this.bCalendar.BackColor = System.Drawing.Color.Green;
            this.bCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCalendar.Location = new System.Drawing.Point(3, 91);
            this.bCalendar.Name = "bCalendar";
            this.bCalendar.Size = new System.Drawing.Size(178, 59);
            this.bCalendar.TabIndex = 44;
            this.bCalendar.Text = "Xem theo lịch";
            this.bCalendar.UseVisualStyleBackColor = false;
            this.bCalendar.Click += new System.EventHandler(this.bCalendar_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Location = new System.Drawing.Point(183, 4);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(912, 640);
            this.panel_Content.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chế độ xem";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bCalendar);
            this.panel1.Controls.Add(this.bList);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 640);
            this.panel1.TabIndex = 0;
            // 
            // GUIPrivateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 645);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel1);
            this.Name = "GUIPrivateSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH TRÌNH CÁ NHÂN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.Button bCalendar;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}