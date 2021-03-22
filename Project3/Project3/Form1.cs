using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = File.ReadAllText(ofd.FileName);
                    if (!string.IsNullOrEmpty(data))
                    {
                        // make everything lowercase
                        var newData = data.ToLower();

                        var lines = newData.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        var wl = new List<string>();

                        if (lines.Any())
                        {
                            lines.ToList().ForEach(line =>
                            {
                                var words = newData.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                                if (words.Any())
                                    wl.AddRange(words);
                            });
                        }


                        wl.Sort();


                        StringBuilder sb = new StringBuilder();

                        //wl.ForEach(w =>
                        //{
                        //    sb.AppendLine(w);
                        //});

                        sb.AppendLine($"First Word: {wl.First()}");
                        sb.AppendLine($"Last Word: {wl.Last()}");
                        sb.AppendLine($"Longest Word: {GetLongest(wl)}");
                        sb.AppendLine($"Most Vowels: {GetMostVowels(wl)}");


                        textBox1.Text = sb.ToString();


                        File.WriteAllText(Guid.NewGuid().ToString() + ".txt", $"Stats: {sb.ToString()}\r\n{newData}");

                    }
                    else
                    {
                        textBox1.Text = "No Data.";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private string GetMostVowels(List<string> wl)
        {
            string t = "";
            int h = 0;
            wl.ForEach(w =>
            {

                var l = w.Length;
                var r = 0;
                for (var i = 0; i < l; i++)
                {
                    if (w[i] == 'a' || w[i] == 'e' || w[i] == 'i' || w[i] == 'o' || w[i] == 'o')
                        r++;
                }
                if (r > h)
                {
                    h = r;
                    t = w;
                }

            });

            return t;
        }

        private string GetLongest(List<string> wl)
        {
            var t = "";

            wl.ForEach(w =>
            {
                if (w.Length > t.Length)
                    t = w;
            });

            return t;
        }
    }
}
