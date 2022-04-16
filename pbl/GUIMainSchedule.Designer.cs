namespace pbl
{
    partial class GUIMainSchedule
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
            this.SuspendLayout();
            // 
            // bList
            // 
            this.bList.Location = new System.Drawing.Point(91, 601);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(115, 34);
            this.bList.TabIndex = 45;
            this.bList.Text = "Detailed list";
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // bCalendar
            // 
            this.bCalendar.Location = new System.Drawing.Point(3, 601);
            this.bCalendar.Name = "bCalendar";
            this.bCalendar.Size = new System.Drawing.Size(88, 34);
            this.bCalendar.TabIndex = 44;
            this.bCalendar.Text = "Calendar";
            this.bCalendar.UseVisualStyleBackColor = true;
            this.bCalendar.Click += new System.EventHandler(this.bCalendar_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.White;
            this.panel_Content.Location = new System.Drawing.Point(3, 2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1096, 593);
            this.panel_Content.TabIndex = 0;
            // 
            // GUIMainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 640);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.bCalendar);
            this.Controls.Add(this.bList);
            this.Name = "GUIMainSchedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.Button bCalendar;
        private System.Windows.Forms.Panel panel_Content;
    }
}