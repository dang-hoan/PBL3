namespace pbl
{
    partial class GUIOption
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.dateDep = new System.Windows.Forms.DateTimePicker();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(440, 178);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 32);
            this.bCancel.TabIndex = 30;
            this.bCancel.Text = "Huỷ";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(219, 178);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(104, 32);
            this.bAccept.TabIndex = 29;
            this.bAccept.Text = "Chấp nhận";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hình thức";
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(506, 127);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(234, 26);
            this.dateDes.TabIndex = 26;
            // 
            // dateDep
            // 
            this.dateDep.Location = new System.Drawing.Point(136, 126);
            this.dateDep.Name = "dateDep";
            this.dateDep.Size = new System.Drawing.Size(225, 26);
            this.dateDep.TabIndex = 25;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(506, 38);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(234, 26);
            this.txtDes.TabIndex = 24;
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(128, 35);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(225, 26);
            this.txtDep.TabIndex = 23;
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Location = new System.Drawing.Point(319, 84);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(87, 24);
            this.rbRound.TabIndex = 22;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "Khứ hồi";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(138, 84);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(103, 24);
            this.rbOne.TabIndex = 21;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "Một chiều";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thời gian đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Thời gian đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ga đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ga đi";
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 234);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.dateDep);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.rbRound);
            this.Controls.Add(this.rbOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Option";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.DateTimePicker dateDep;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.RadioButton rbRound;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}