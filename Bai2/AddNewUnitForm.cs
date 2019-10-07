using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai2
{
    public partial class AddNewUnitForm : Form
    {
        Dictionary dic = Mainform.Dic;
        public AddNewUnitForm()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.Black))
            {
                //g.DrawRectangle(selPen, 0, 0, this.Width, this.Height);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 2, Height - 2));
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Timer t1 = new Timer();
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.09;
        }
        private void AddNewUnitForm_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0
            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
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

        private void button_OK_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save ?";
            string title = "Save Window";


            if (tb_name.Text == "" || tb_noidung.Text == "")
            {
                MessageBoxCustoms mes = new MessageBoxCustoms("Không được để trống tên hoặc nội dung unit", TypeMessageEnum.THONGBAO);
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Mainform.Dic.AddListWordInNewUnit(tb_name.Text, tb_noidung.Text);
                    Mainform.Dic.ClearAllUnit();
                    Mainform.Dic.addword();
                    MessageBoxCustoms mes = new MessageBoxCustoms("Lưu thành công", TypeMessageEnum.THONGBAO);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
