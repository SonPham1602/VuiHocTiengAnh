using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2
{
    public partial class SelectGame : Form
    {      
      
        public SelectGame()
        {          
            InitializeComponent();
        }
        private void CreateGame1()// tao game 1 
        {
            Game1 game1 = new Game1();
            pn_show.Hide();
            game1.TopLevel = false;
            pn_show.Controls.Add(game1);
            game1.Dock = DockStyle.Fill;
            game1.Show();
            game1.BringToFront();
            pn_show.Show();
        }
        private void CreateGame2()// tao game 2
        {
            Game2 game2= new Game2();
            pn_show.Hide();
            game2.TopLevel = false;
            pn_show.Controls.Add(game2);
            game2.Dock = DockStyle.Fill;
            game2.Show();
            game2.BringToFront();
            pn_show.Show();
        }
        private void CreateGame3()// tao game 3
        {
            Game3 game3 = new Game3();
            pn_show.Hide();         
            game3.TopLevel = false;
            pn_show.Controls.Add(game3);
            game3.Dock = DockStyle.Fill;
            game3.Show();
            game3.BringToFront();
            pn_show.Show();
        }
        private void CreateGame4()// tao game 4
        {
            Game4 game4  = new Game4();
            pn_show.Hide();
            game4.TopLevel = false;
            pn_show.Controls.Add(game4);
            game4.Dock = DockStyle.Fill;
            game4.Show();
            game4.BringToFront();
            pn_show.Show();
        }

        private void CreateGame5()// tao game 4
        {
            Game5 game5  = new Game5();
            pn_show.Hide();
            game5.TopLevel = false;
            pn_show.Controls.Add(game5);
            game5.Dock = DockStyle.Fill;
            game5.Show();
            game5.BringToFront();
            pn_show.Show();
        }
        private void pn_game1_MouseClick(object sender, MouseEventArgs e)
        {
            CreateGame1();
        }

        private void pn_game1_MouseClick(object sender, EventArgs e)
        {
            CreateGame1();
        }

        private void pn_game2_Click(object sender, EventArgs e)
        {
            CreateGame2();
        }

        private void lb_game2_Click(object sender, EventArgs e)
        {
            CreateGame2();
        }

        private void SelectGame_Shown(object sender, EventArgs e)
        {
           
        }

        private void lb_game3_Click(object sender, EventArgs e)
        {
            CreateGame3();
        }

        private void pn_game3_Click(object sender, EventArgs e)
        {
            CreateGame3();
        }

        private void lb_game4_Click(object sender, EventArgs e)
        {
            CreateGame4();
        }

        private void pn_game4_Click(object sender, EventArgs e)
        {
            CreateGame4();
        }

        private void lb_game5_Click(object sender, EventArgs e)
        {
            CreateGame5();
        }

        private void pn_game5_Click(object sender, EventArgs e)
        {
            CreateGame5();
        }

        private void pn_game6_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 

        private void pn_show_Paint(object sender, PaintEventArgs e)
        {
                           
        }

       
       
    }
}
