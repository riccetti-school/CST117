using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";

            try
            {
                int g = int.Parse(textBox1.Text);
                float f = 3.0f;
                float pi = 4.0f;
                int j = 3;

                while (f < g)
                {
                    if(j % 2 != 0)
                    {
                        pi -= (float)(4 / f);
                        j++;
                    }
                    else
                    {
                        pi += (float)(4 / f);
                        j++;
                    }
                    f += 2;
                }

                label2.Text = $"Approximate value of pi after {g} terms";
                label3.Text = $"= {pi}";
            }
            catch (Exception)
            {
                label3.Text = "Invalid term value";
            }
        }
    }
}
