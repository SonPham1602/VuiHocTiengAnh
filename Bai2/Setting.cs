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
    public partial class Setting : Form
    {
        HamCanThiet f;
        private Color c=new Color();
        private Size s = new Size();
        public event EventSuccess change = null;
        public Setting()
        {
            InitializeComponent();
            c = Color.FromArgb(133, 203, 248);
            s = new Size(60, 60);
            f = new HamCanThiet();
            SetToolTips();
        }

        public void SetData(Size s,Color c)// ham nay tao set data
        {
            if (s == new Size(1000, 800))
            {
                SizeOfMainForm.selectedIndex = 0;
            }
            else if (s == new Size(1280, 720))
            {
                SizeOfMainForm.selectedIndex = 1;
            }
            else if (s == new Size(1228,842))
            {
                SizeOfMainForm.selectedIndex = 2;
            }
            else if (s == new Size(1600, 900))
            {
                SizeOfMainForm.selectedIndex = 3;
            }
            else
            {
                SizeOfMainForm.selectedIndex = 4;
            }
        }

    
        private void ResetColorSelect()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            pb_color1.Image = (System.Drawing.Image)(resources.GetObject("pb_color1.Image"));
            pb_color2.Image = (System.Drawing.Image)(resources.GetObject("pb_color2.Image"));
            pb_color3.Image = (System.Drawing.Image)(resources.GetObject("pb_color3.Image"));
            pb_color4.Image = (System.Drawing.Image)(resources.GetObject("pb_color4.Image"));
            pb_color5.Image = (System.Drawing.Image)(resources.GetObject("pb_color5.Image"));
            pb_color6.Image = (System.Drawing.Image)(resources.GetObject("pb_color6.Image"));
        }
        Color select = Color.DimGray;
        private void pb_color1_Click(object sender, EventArgs e)// mau xanh 
        {
            ResetColorSelect();
            pb_color1.Image = f.ImageCrop(pb_color1.Image, 100, select);
            c = Color.FromArgb(0, 114, 188);
        }

        private void pb_color2_Click(object sender, EventArgs e)// mau xam
        {
            ResetColorSelect();
            pb_color2.Image = f.ImageCrop(pb_color2.Image, 100, select);
            c = Color.FromArgb(106, 106, 106);      
        }

        private void pb_color3_Click(object sender, EventArgs e)// may cam
        {
            ResetColorSelect();
            pb_color3.Image = f.ImageCrop(pb_color3.Image, 100, select);
            c= Color.FromArgb(188, 73, 0);
        }

        private void pb_color4_Click(object sender, EventArgs e)// mau tim
        {
            ResetColorSelect();
            pb_color4.Image = f.ImageCrop(pb_color4.Image, 100, select);
            c= Color.FromArgb(57, 0, 188);
        }

        private void pb_color5_Click(object sender, EventArgs e)// mau do
        {
            ResetColorSelect();
            pb_color5.Image = f.ImageCrop(pb_color5.Image, 100, select);
            c= Color.FromArgb(219, 36, 46);           
        }

        private void pb_color6_Click(object sender, EventArgs e)// mau xanh la
        {
            ResetColorSelect();
            pb_color6.Image = f.ImageCrop(pb_color6.Image, 100, select);
            c = Color.FromArgb(0, 188, 123);
        }

        private void reset_option_Click(object sender, EventArgs e)
        {
            MessageBoxYesNoCustom mess = new MessageBoxYesNoCustom("Quay lại cài đặc mặc định ?");
            if (mess.Check == true)
            {
                ResetColorSelect();
                change(this, new ChangeUI { size = new Size(1228, 842), color = Color.FromArgb(133, 203, 248) });
                c = Color.FromArgb(133, 203, 248);
                SizeOfMainForm.selectedIndex = 2;
            }
           
        }
        private void SetToolTips()
        {
            toolTip.SetToolTip(this.reset_option,"Cài lại mặc định cho chương trình");
            toolTip.SetToolTip(this.SizeOfMainForm, "Cài lại kích thước chương trình");
            toolTip.SetToolTip(this.reset_option, "Cài lại mặc định cho chương trình");
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (SizeOfMainForm.selectedValue == "1000 x 800")
            {
                change(this, new ChangeUI { size = new Size(1000, 800), color = c });
            }
            else if (SizeOfMainForm.selectedValue == "1280 x 720")
            {
                change(this, new ChangeUI { size = new Size(1280, 720), color = c });
            }
            else if (SizeOfMainForm.selectedValue == "1228 x 842")
            {
                change(this, new ChangeUI { size = new Size(1228, 842), color = c });
            }
            else if (SizeOfMainForm.selectedValue == "1600 x 900")
            {
                change(this, new ChangeUI { size = new Size(1600, 900), color = c });
            }
            else if (SizeOfMainForm.selectedValue == "Fullscreen")
            {
                int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height - nTaskBarHeight;
                change(this, new ChangeUI { size = new Size(w, h), color = c });
            }
            if (File.Exists(@"user_data\setting.dat"))
            {
                File.Delete(@"user_data\setting.dat");

            }
            f.SetPropertiesUser(SizeOfMainForm.selectedValue, c.R.ToString(), c.G.ToString(), c.B.ToString());
           
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pickcolor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                c = Color.FromArgb(cld.Color.ToArgb());
                MessageBoxCustoms mess = new MessageBoxCustoms("Màu đã được chọn nhấn nút OK để thay đổi", TypeMessageEnum.THONGBAO);

            }
        }
    }
}
