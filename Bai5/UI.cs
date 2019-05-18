using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai5
{
    public partial class UI : Form
    {
        
        public UI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 30;      // Grip size
        private const int cCaption = 30;   // Caption bar height;


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        // cac ham su ly giao dien nguoi dung
        // su ly nut exit
        private void pb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // su ly nut thu nho
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_fullscreen_Click(object sender, EventArgs e)
        {
            if (WindowState ==FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
                WindowState = FormWindowState.Maximized;
        }
        ToolTip t1 = new ToolTip();
        private void pb_exit_MouseHover(object sender, EventArgs e)
        {        
            t1.Show("   Exit", pb_exit);
        }

        private void pb_fullscreen_MouseHover(object sender, EventArgs e)
        {
            t1.Show("   Fullscreen", pb_fullscreen);
        }

        private void pb_minimize_MouseHover(object sender, EventArgs e)
        {
            t1.Show("   Minimize", pb_minimize);
        }

        private void pb_home_MouseHover(object sender, EventArgs e)
        {
            t1.Show("   Home", pb_home);
            pb_home.Image=Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\home_s.png");
           
        }

        private void pb_home_MouseLeave(object sender, EventArgs e)
        {
            pb_home.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\home.png");
        }

        private void pb_learn_MouseHover(object sender, EventArgs e)
        {
            t1.Show("   Learn", pb_learn);
            pb_learn.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\learn_s.png");
        }

        private void pb_learn_MouseLeave(object sender, EventArgs e)
        {
            pb_learn.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\learn.png");
        }

        private void pb_test_MouseHover(object sender, EventArgs e)
        {
            pb_test.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\test_s.png");
        }

        private void pb_test_MouseLeave(object sender, EventArgs e)
        {
            pb_test.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\test.png");
        }

        private void pb_setting_MouseHover(object sender, EventArgs e)
        {
            pb_setting.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\setting_s.png");
        }

        private void pb_setting_MouseLeave(object sender, EventArgs e)
        {
            pb_setting.Image = Image.FromFile(@"C:\Users\Welcome\Desktop\DATA\BAI TAP\C Sharp\Tuan1\Tuan1\Bai5\icon\setting.png");
        }

    }
}
