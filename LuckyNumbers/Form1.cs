using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setYears();

            setMonths();

            setColor();

            setDefault();
        }

        private void setDefault()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void setColor()
        {
            comboBox4.Items.Add("Red");
            comboBox4.Items.Add("Yellow");
            comboBox4.Items.Add("Green");
            comboBox4.Items.Add("Blue");

        }

        private void setMonths()
        {
            comboBox2.Items.Add("January");
            comboBox2.Items.Add("February");
            comboBox2.Items.Add("March");
            comboBox2.Items.Add("April");
            comboBox2.Items.Add("May");
            comboBox2.Items.Add("June");
            comboBox2.Items.Add("July");
            comboBox2.Items.Add("August");
            comboBox2.Items.Add("September");
            comboBox2.Items.Add("October");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("December");

        }

        private void setYears()
        {
            int maxYears = 100;
            int thisYear = DateTime.Now.Year;
            while (maxYears > 0)
            {
                comboBox1.Items.Add(thisYear.ToString());
                thisYear--;
                maxYears--;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(comboBox1.SelectedItem.ToString());
                int monthNumber = DateTime.ParseExact(comboBox2.SelectedItem.ToString(), "MMMM", CultureInfo.InvariantCulture).Month;
                int days = DateTime.DaysInMonth(year, monthNumber);

                comboBox3.Items.Clear();
                for(int i = 0; i < days; i++)
                {
                    comboBox3.Items.Add((i + 1).ToString());
                }

            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            var ln = r.Next(1000);
            Form2 f = new Form2(ln);
            f.ShowDialog();
        }
    }
}
