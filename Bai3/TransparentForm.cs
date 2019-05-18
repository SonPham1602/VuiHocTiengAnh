using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace Bai3
{
    public partial class TransparentForm : Form
    {
        private void btnFade_Click(object sender, EventArgs e)
        {
            int loopctr = 0;

            for (loopctr = 100; loopctr >= 5; loopctr -= 10)
            {
                this.Opacity = loopctr / 95.0;
                this.Refresh();
                Thread.Sleep(50);
            }

            this.Close();
        }
        private async void FadeIn(Form o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < 0.95)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 0.95; //make fully visible       
        }
        private async void FadeOut(Form o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible       
            o.Close();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public TransparentForm()
        {
            InitializeComponent();
            this.Opacity = 0;
        }
        MainForm f3 = new MainForm();
        public void FadeOpen(object sender, EventArgs e)
        {
            this.Opacity = 0;
            int loopctr = 0;
            for (loopctr = 0; loopctr <= 100; loopctr += 5)
            {
                this.Opacity = loopctr / 95.0;
                //this.Refresh();// khong can cai nay cung dc,Luu y: tim hieu re this.refresh 
                Thread.Sleep(10);
            }
        }
        private void TransparentForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            FadeIn(this, 10);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            f3.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            f3.PerformForm2Click += new EventHandler(closeform);
            f3.StartPosition = this.StartPosition;
           
           
            //this.Show();
           //f3.Show();

        }

        private void closeform(object sender, EventArgs e)
        {
            FadeOut(this, 10);
           
        }
        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            this.Location = f3.Location;
        }
        private void TransparentForm_LocationChanged(object sender, EventArgs e)
        {
  
        }

        private void TransparentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
