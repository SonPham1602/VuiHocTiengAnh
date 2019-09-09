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
    public partial class MessageBoxYesNoCustom : Form
    {
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
        void PaintBox(object sender, PaintEventArgs pea)
        {
            // Draw nice Sun and detailed grass
            using (Pen selPen = new Pen(Color.Black))
            {
                //g.DrawRectangle(selPen, 0, 0, this.Width, this.Height);
                pea.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
        public bool Check;
        public MessageBoxYesNoCustom()
        {
            InitializeComponent();
        }
        public MessageBoxYesNoCustom(string content)
        {
            InitializeComponent();
            lb_noidung.Text = content;
            this.Paint += new PaintEventHandler(PaintBox);
            this.ShowDialog();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Check = true;
            this.Close();          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Check = false;
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
