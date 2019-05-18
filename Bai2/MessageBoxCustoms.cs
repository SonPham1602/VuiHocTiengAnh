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
    public partial class MessageBoxCustoms : Form
    {
        public  MessageBoxCustoms()
        {
            InitializeComponent();
         
               
              
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    Graphics g = e.Graphics;
        //    using (Pen selPen = new Pen(Color.Black))
        //    {
        //        //g.DrawRectangle(selPen, 0, 0, this.Width, this.Height);
        //        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 2, Height - 2));
        //    }
        //}
        public MessageBoxCustoms(string noidung)
        {
            InitializeComponent();
            lb_noidung.Text = noidung;
            this.Paint += new PaintEventHandler(PaintBox);
            this.ShowDialog();
            
        }

        void PaintBox(object sender, PaintEventArgs pea)
        {
            // Draw nice Sun and detailed grass
            using (Pen selPen = new Pen(Color.Black))
            {
                //g.DrawRectangle(selPen, 0, 0, this.Width, this.Height);
                pea.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 2, Height - 2));
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
