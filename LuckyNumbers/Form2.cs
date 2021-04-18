using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class Form2 : Form
    {

        private int n = 0;

        public Form2(int number)
        {
            n = number;
            InitializeComponent();

            label2.Text = n.ToString();
        }

    }
}
