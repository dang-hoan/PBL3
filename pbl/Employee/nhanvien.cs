﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class nhanvien : Form
    {
        Form login;
        public nhanvien(Form login)
        {
            InitializeComponent();
            this.login = login;

        }
        Form form = null;
        private void showform(Form subform)
        {
            if (form != null) form.Close();
            form = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            pnxuly.Controls.Add(subform);
            pnxuly.Tag = subform;
            subform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showform(new infor());
        }

<<<<<<< HEAD
       
=======
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            showform(new lichtrinh());
        }

>>>>>>> 56189591597c8ac2502b753db62da6211e9cbcad
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showform(new ticket());
        }
    }
}