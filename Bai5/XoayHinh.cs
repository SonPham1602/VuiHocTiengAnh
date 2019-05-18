using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;

namespace Bai5
{
    
    public partial class XoayHinh : Form
    {
        public Bitmap Blur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (Int32 x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (Int32 y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (Int32 x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (Int32 y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }
       
        public Image ImageCropsdf(Image img, int s)
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
            bm = bm.Clone(crop, bm.PixelFormat);
            TextureBrush tb = new TextureBrush(bm);
            Bitmap final = new Bitmap(circleDiameter, circleDiameter);
            Graphics gp = Graphics.FromImage(final);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gp.FillEllipse(tb, 0, 0, circleDiameter, circleDiameter);
            //  gp.DrawEllipse(new Pen(c, (float)(s)), s / 2, s / 2, circleDiameter - s, circleDiameter - s);
            return final;
        }

        public XoayHinh()
        {
            InitializeComponent();
           




        }




        private void button1_Click(object sender, EventArgs e)
        {
            animator1.Show(pictureBox1,false);
            pictureBox1.Refresh();
            //animator1.BeginUpdate(pictureBox1, true); 
            //animator1.EndUpdate(pictureBox1);

        }

        private void XoayHinh_Load(object sender, EventArgs e)
        {
            //Bitmap bitmap = new Bitmap(@"C:\Users\Welcome\Desktop\my.jpg");
            //bitmap = Blur(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 10);
            //this.BackgroundImage = bitmap;
          //  img = ImageCropsdf(pictureBox1.Image, 0);
          //  pictureBox1.Image = img;
        }
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new Bitmap(open.FileName);
                    img = bitmap;
                    pb_image.Image = bitmap;
                   

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }

            //timer.Start();
           
         
        }
        Image img = Image.FromFile(@"C:\Users\Welcome\Desktop\Load.png");
        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            i=i+20;
            pb_image.Image = RotateImage(img, i);
            pb_image.Refresh();
        }
    }
}
