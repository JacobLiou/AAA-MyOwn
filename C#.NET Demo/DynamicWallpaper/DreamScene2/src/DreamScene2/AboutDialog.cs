﻿using System;
using System.Windows.Forms;

namespace DreamScene2
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            this.Icon = DreamScene2.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.OpenLink("https://github.com/he55/DreamScene2");
        }
    }
}
