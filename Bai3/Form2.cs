using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai3
{
     
    public partial class Form2 : Form
    {
        Image avatar;
        Image background;
        public Image OpenImageData(string name)
        {
            string n=name+".dat";
            Image img=Image.FromStream(new MemoryStream(File.ReadAllBytes(n)));
            return img;
        }
        public void SaveImageData(Image img, string namefile)
        {
            string n = namefile + ".dat";
            img.Save( n,System.Drawing.Imaging.ImageFormat.Png);
        }
        public Form2()
        {
            InitializeComponent();
           
        }
        public Image ImageCrop(Image img,int s,Color c)
        {
            int circleDiameter;
            Bitmap bm = new Bitmap(img);
            if (bm.Height > bm.Width)
            {
                circleDiameter = bm.Width;
            }
            else
            {
                circleDiameter = bm.Height;
            }
            Rectangle crop = new Rectangle(0, 0, circleDiameter, circleDiameter);
            bm = bm.Clone(crop,bm.PixelFormat);
            TextureBrush tb = new TextureBrush(bm);
            Bitmap final = new Bitmap(circleDiameter, circleDiameter);
            Graphics gp = Graphics.FromImage(final);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gp.FillEllipse(tb, 0, 0, circleDiameter, circleDiameter);
            gp.DrawEllipse(new Pen(c,(float)(s)),s/2,s/2,circleDiameter-s,circleDiameter-s);
            return final;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        avatar = Image.FromFile(openFileDialog1.FileName);
                        pictureBox1.Image = ImageCrop(avatar,8,Color.White);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveImageData(pictureBox1.Image, "avatar");
            MessageBox.Show("Thanh Cong");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = OpenImageData("avatar");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        background = Image.FromFile(openFileDialog1.FileName);
                        pictureBox2. BackgroundImage =background;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
