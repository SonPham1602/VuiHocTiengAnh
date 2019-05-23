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
    public enum TypeMessageEnum
    {
        ERROR,THONGBAO,KETQUA
    }
    public partial class MessageBoxCustoms : Form
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
        Timer t1 = new Timer();
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
          public MessageBoxCustoms(string noidung,TypeMessageEnum type)
        {
            InitializeComponent();
              if(type == TypeMessageEnum.ERROR)
              {
                  TypeMessage.Text = "Lỗi";
              }
              else if (type == TypeMessageEnum.KETQUA) 
              {
                  TypeMessage.Text = "Kết quả";
                  this.Size = new Size(525, 325);
              }
              else if (type == TypeMessageEnum.THONGBAO)
              {
                  TypeMessage.Text = "Thông báo";
              }
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

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.09;
        }
        private void MessageBoxCustoms_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0
            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void MessageBoxCustoms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
       
    }
}
