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
    public partial class EditUnitForm : Form
    {
        int numberUnit;
        Dictionary dic;
        public EditUnitForm()
        {
            InitializeComponent();
        }
        public EditUnitForm(int n)
        {
            numberUnit = n;
            InitializeComponent();
        }
        //Create Showdown Form
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.Black))
            {
                //g.DrawRectangle(selPen, 0, 0, this.Width, this.Height);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUnitForm_Load(object sender, EventArgs e)
        {
            dic = new Dictionary();
            tb_noidung.ScrollBars = ScrollBars.Both;
            tb_name.Text = dic.GetNameOfUnitByNumber(numberUnit);
            tb_noidung.Text = dic.ReadUnit(tb_name.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

    }
}
