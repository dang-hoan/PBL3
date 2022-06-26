namespace pbl.View
{
    partial class addtrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addtrain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgiagoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbblaixe = new System.Windows.Forms.ComboBox();
            this.txtsotoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.schedule = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDes = new System.Windows.Forms.ComboBox();
            this.cbbDep = new System.Windows.Forms.ComboBox();
            this.lich_trinh = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bTOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lich_trinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cbbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtgiagoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbblaixe);
            this.groupBox1.Controls.Add(this.txtsotoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.schedule);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbDes);
            this.groupBox1.Controls.Add(this.cbbDep);
            this.groupBox1.Controls.Add(this.lich_trinh);
            this.groupBox1.Location = new System.Drawing.Point(56, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(590, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thêm chuyến tàu mới";
            // 
            // cbbName
            // 
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(232, 232);
            this.cbbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(284, 28);
            this.cbbName.TabIndex = 61;
            this.cbbName.SelectedIndexChanged += new System.EventHandler(this.cbbName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Chọn một lịch trình trước khi thêm (kích chuột vào hình tờ lịch)!";
            // 
            // txtgiagoc
            // 
            this.txtgiagoc.Location = new System.Drawing.Point(232, 407);
            this.txtgiagoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgiagoc.Name = "txtgiagoc";
            this.txtgiagoc.Size = new System.Drawing.Size(284, 26);
            this.txtgiagoc.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Giá vé cơ bản";
            // 
            // cbblaixe
            // 
            this.cbblaixe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbblaixe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbblaixe.FormattingEnabled = true;
            this.cbblaixe.Location = new System.Drawing.Point(232, 354);
            this.cbblaixe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbblaixe.Name = "cbblaixe";
            this.cbblaixe.Size = new System.Drawing.Size(284, 28);
            this.cbblaixe.TabIndex = 57;
            // 
            // txtsotoa
            // 
            this.txtsotoa.Enabled = false;
            this.txtsotoa.Location = new System.Drawing.Point(232, 295);
            this.txtsotoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsotoa.Name = "txtsotoa";
            this.txtsotoa.Size = new System.Drawing.Size(284, 26);
            this.txtsotoa.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tên người lái tàu";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tên tàu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số toa";
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(302, 71);
            this.schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(214, 26);
            this.schedule.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Mã lịch trình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ga đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ga đến:";
            // 
            // cbbDes
            // 
            this.cbbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDes.FormattingEnabled = true;
            this.cbbDes.Location = new System.Drawing.Point(302, 172);
            this.cbbDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDes.Name = "cbbDes";
            this.cbbDes.Size = new System.Drawing.Size(214, 28);
            this.cbbDes.TabIndex = 42;
            // 
            // cbbDep
            // 
            this.cbbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDep.FormattingEnabled = true;
            this.cbbDep.Location = new System.Drawing.Point(302, 119);
            this.cbbDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDep.Name = "cbbDep";
            this.cbbDep.Size = new System.Drawing.Size(214, 28);
            this.cbbDep.TabIndex = 41;
            // 
            // lich_trinh
            // 
            this.lich_trinh.Image = ((System.Drawing.Image)(resources.GetObject("lich_trinh.Image")));
            this.lich_trinh.Location = new System.Drawing.Point(69, 92);
            this.lich_trinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lich_trinh.Name = "lich_trinh";
            this.lich_trinh.Size = new System.Drawing.Size(98, 80);
            this.lich_trinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lich_trinh.TabIndex = 0;
            this.lich_trinh.TabStop = false;
            this.lich_trinh.Click += new System.EventHandler(this.lich_trinh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bTOK
            // 
            this.bTOK.Location = new System.Drawing.Point(437, 507);
            this.bTOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bTOK.Name = "bTOK";
            this.bTOK.Size = new System.Drawing.Size(80, 41);
            this.bTOK.TabIndex = 5;
            this.bTOK.Text = "OK";
            this.bTOK.UseVisualStyleBackColor = true;
            this.bTOK.Click += new System.EventHandler(this.bTOK_Click);
            // 
            // addtrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(704, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bTOK);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addtrain";
            this.Text = "addtrain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lich_trinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox lich_trinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox schedule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDes;
        private System.Windows.Forms.ComboBox cbbDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsotoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bTOK;
        private System.Windows.Forms.ComboBox cbblaixe;
        private System.Windows.Forms.TextBox txtgiagoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbName;
    }
}