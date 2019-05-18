using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows;


namespace Bai3
{

    public partial class MainForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect, // x-coordinate of upper-left corner
        //    int nTopRect, // y-coordinate of upper-left corner
        //    int nRightRect, // x-coordinate of lower-right corner
        //    int nBottomRect, // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        // );

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        //[DllImport("dwmapi.dll")]
        //public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        //private bool m_aeroEnabled;                     // variables for box shadow
        //private const int CS_DROPSHADOW = 0x00020000;
        //private const int WM_NCPAINT = 0x0085;
        //private const int WM_ACTIVATEAPP = 0x001C;

        //public struct MARGINS                           // struct for box shadow
        //{
        //    public int leftWidth;
        //    public int rightWidth;
        //    public int topHeight;
        //    public int bottomHeight;
        //}

        //private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        //private const int HTCLIENT = 0x1;
        //private const int HTCAPTION = 0x2;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        m_aeroEnabled = CheckAeroEnabled();

        //        CreateParams cp = base.CreateParams;
        //        if (!m_aeroEnabled)
        //            cp.ClassStyle |= CS_DROPSHADOW;

        //        return cp;
        //    }
        //}

        //private bool CheckAeroEnabled()
        //{
        //    if (Environment.OSVersion.Version.Major >= 6)
        //    {
        //        int enabled = 0;
        //        DwmIsCompositionEnabled(ref enabled);
        //        return (enabled == 1) ? true : false;
        //    }
        //    return false;
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCPAINT:                        // box shadow
        //            if (m_aeroEnabled)
        //            {
        //                var v = 2;
        //                DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                MARGINS margins = new MARGINS()
        //                {
        //                    bottomHeight = 1,
        //                    leftWidth = 1,
        //                    rightWidth = 1,
        //                    topHeight = 1
        //                };
        //                DwmExtendFrameIntoClientArea(this.Handle, ref margins);

        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    base.WndProc(ref m);

        //    if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
        //        m.Result = (IntPtr)HTCAPTION;

        //}

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

        private void dropShadow(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        
        public MainForm()
        {
        
            InitializeComponent();
           // panel1.Paint += dropShadow;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            


        }
  
        private void Form3_Load(object sender, EventArgs e)
        {

          
         
          
        }

        private void Form3_LocationChanged(object sender, EventArgs e)
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);

            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
           
        }
        public event EventHandler PerformForm1Click;
        public event EventHandler PerformForm2Click;
        private void panel1_LocationChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EventHandler handler = this.PerformForm2Click;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_cancel_60__1_;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icons8_cancel_60;
        }

    }
}
