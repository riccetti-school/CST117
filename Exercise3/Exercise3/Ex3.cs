﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var val = textBox1.Text;

            try
            {
                var f = float.Parse(val);
                textBox2.Text = (f / 2f).ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
