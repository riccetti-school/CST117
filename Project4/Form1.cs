using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // we'll run the simulation here
            int[,] grid = new int[3, 3];

            // initialize all to off
            for (int x = 0; x < grid.GetLength(0); x++)
                for (int y = 0; y < grid.GetLength(1); y++)
                    grid[x, y] = -1;

            var player = 1;
            while (true)
            {

                while (true)
                {
                    var x = new Random().Next(grid.GetLength(0));
                    var y = new Random().Next(grid.GetLength(1));
                    if (grid[x, y] == -1)
                    {
                        // player turn
                        if (player == 1)
                        {
                            player = 2;
                            grid[x, y] = 1;

                        }
                        else
                        {
                            player = 1;
                            grid[x, y] = 2;
                        }

                        break;
                    }

                }
                DrawGrid(grid);

                // check end game
                var endgame = true;
                for (int x = 0; x < grid.GetLength(0); x++)
                    for (int y = 0; y < grid.GetLength(1); y++)
                    {
                        if (grid[x, y] == -1)
                            endgame = false;
                    }

                if (endgame)
                    break;

            }

        }

        private void DrawGrid(int[,] grid)
        {
            var i = 1;
            for (int y = 0; y < grid.GetLength(1); y++)
                for (int x = 0; x < grid.GetLength(0); x++)
                {

                    var xoro = grid[x, y] == 1 ? "X" : "O";

                    switch (i)
                    {
                        case 1:
                            label1.Text = xoro;
                            break;
                        case 2:
                            label2.Text = xoro;
                            break;
                        case 3:
                            label3.Text = xoro;
                            break;
                        case 4:
                            label4.Text = xoro;
                            break;
                        case 5:
                            label5.Text = xoro;
                            break;
                        case 6:
                            label6.Text = xoro;
                            break;
                        case 7:
                            label7.Text = xoro;
                            break;
                        case 8:
                            label8.Text = xoro;
                            break;
                        case 9:
                            label9.Text = xoro;
                            break;

                    }


                    i++;

                }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }
    }
}
