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
    public partial class InputPass : Form
    {
        public delegate void MyDel(string ConfirmPass, bool Get);
        public MyDel GetConfirmPass;
        public InputPass()
        {
            InitializeComponent();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            GetConfirmPass(txtConfirmPass.Text, true);
            this.Close();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            GetConfirmPass(txtConfirmPass.Text, false);
            this.Close();
        }

        private void cbViewPass_Click(object sender, EventArgs e)
        {
            if (cbViewPass.Checked) txtConfirmPass.PasswordChar = '\0';
            else txtConfirmPass.PasswordChar = '*';
        }

        private void InputPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bAccept_Click(sender, e);
            }
        }
    }
}
