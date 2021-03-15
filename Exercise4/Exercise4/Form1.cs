using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var val = textBox1.Text;
            try
            {
                int i = int.Parse(val);

                if (i < 60)
                {
                    textBox2.Text = $"{i} seconds";
                }
                else if (i == 60 || i < 3600) {
                    var u = i / 60;
                    textBox2.Text = $"{u} minutes";
                }
                else if(i==3600 || i < 86400)
                {
                    var u = i / 60;
                    var h = u / 60;
                    textBox2.Text = $"{h} hours";
                }
                else if(i==86400 || i > 86400)
                {
                    var u = i / 60;
                    var h = u / 60;
                    var d = h / 24;
                    textBox2.Text = $"{d} days";
                }
            }
            catch (Exception)
            {
                textBox2.Text = "Invalid";
            }
        }
    }
}
