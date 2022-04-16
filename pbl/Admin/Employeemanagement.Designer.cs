namespace pbl
{
    partial class Employeemanagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeemanagement));
            this.pAdd = new System.Windows.Forms.PictureBox();
            this.pSearch = new System.Windows.Forms.PictureBox();
            this.pEdit = new System.Windows.Forms.PictureBox();
            this.pDelete = new System.Windows.Forms.PictureBox();
            this.bBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pAdd
            // 
            this.pAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAdd.Image = ((System.Drawing.Image)(resources.GetObject("pAdd.Image")));
            this.pAdd.Location = new System.Drawing.Point(70, 66);
            this.pAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(240, 222);
            this.pAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAdd.TabIndex = 0;
            this.pAdd.TabStop = false;
            this.pAdd.Click += new System.EventHandler(this.pAdd_Click);
            // 
            // pSearch
            // 
            this.pSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pSearch.Image = ((System.Drawing.Image)(resources.GetObject("pSearch.Image")));
            this.pSearch.Location = new System.Drawing.Point(364, 66);
            this.pSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(240, 222);
            this.pSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pSearch.TabIndex = 1;
            this.pSearch.TabStop = false;
            // 
            // pEdit
            // 
            this.pEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pEdit.Image = ((System.Drawing.Image)(resources.GetObject("pEdit.Image")));
            this.pEdit.Location = new System.Drawing.Point(70, 324);
            this.pEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(240, 222);
            this.pEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEdit.TabIndex = 2;
            this.pEdit.TabStop = false;
            // 
            // pDelete
            // 
            this.pDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDelete.Image = ((System.Drawing.Image)(resources.GetObject("pDelete.Image")));
            this.pDelete.Location = new System.Drawing.Point(364, 324);
            this.pDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pDelete.Name = "pDelete";
            this.pDelete.Size = new System.Drawing.Size(240, 222);
            this.pDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pDelete.TabIndex = 3;
            this.pDelete.TabStop = false;
            // 
            // bBack
            // 
            this.bBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBack.Location = new System.Drawing.Point(559, 567);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(84, 41);
            this.bBack.TabIndex = 4;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // Employeemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(677, 641);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.pDelete);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.pAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employeemanagement";
            this.Text = "Employee management";
            ((System.ComponentModel.ISupportInitialize)(this.pAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pAdd;
        private System.Windows.Forms.PictureBox pSearch;
        private System.Windows.Forms.PictureBox pEdit;
        private System.Windows.Forms.PictureBox pDelete;
        private System.Windows.Forms.Button bBack;
    }
}