using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bai2
{
    public partial class AddDataForm : Form
    {
        public void FadeIn(object sender, EventArgs e)
        {
            int loopctr = 0;
            for (loopctr = 0; loopctr <= 100; loopctr += 5)
            {
                this.Opacity = loopctr / 95.0;
                this.Refresh();// khong can cai nay cung dc,Luu y: tim hieu re this.refresh 
                Thread.Sleep(10);
            }
        }
        public void FadeClose(object sender, EventArgs e)// tao hieu ung tat cho form chinh
        {
            int loopctr = 0;
            for (loopctr = 100; loopctr >= 5; loopctr -= 5)
            {
                this.Opacity = loopctr / 95.0;
                //this.Refresh();// khong can cai nay cung dc,Luu y: tim hieu re this.refresh 
                Thread.Sleep(10);
            }
            this.Close();
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
        private Image img;// this is picture, which need save
        private string pathImage=string.Empty;
        private string nameImage = string.Empty;
        private HamCanThiet f = new HamCanThiet();
        public AddDataForm()
        {
            InitializeComponent();           
        }

        private void btn_open_image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(open.FileName);
                    img = bitmap;
                    pb_show.Image = bitmap;
                    pathImage = open.FileName;
                    txtPath.Text = open.FileName;
                    txtName.Text = open.SafeFileName;

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Không được để trống tên File", "THÔNG BÁO");
            }
            else
            {
                if (img != null)
                {
                    f.SaveImageData(img, txtName.Text);
                }
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            FadeClose(sender, e);

        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            if (pathImage != "")
            {
                pb_show.Image = null;
                ProcessStartInfo Info = new ProcessStartInfo()
                {
                    FileName = "mspaint.exe",
                    WindowStyle = ProcessWindowStyle.Maximized,
                    Arguments = pathImage
                };
                Process.Start(Info);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hình ảnh", "THÔNG BÁO");
            }
        }

        private void AddDataForm_Load(object sender, EventArgs e)
        {
            FadeIn(sender, e);
        }
    }
}
