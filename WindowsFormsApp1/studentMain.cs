﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class studentMain : Form
    {
        public studentMain()
        {
            InitializeComponent();
        }

        private void sst_Click(object sender, EventArgs e)
        {
            Schedule sc = new Schedule();
            sc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
