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
    public partial class Form3 : Form
    {
         public void SaveImageData(Image img, string namefile)// lưu ảnh cần save dưới dạng file nhị phân
        {
            namefile=namefile.Remove(namefile.LastIndexOf("."));
            string n = namefile + ".dat";
            img.Save(n);
        }

         private void btn_xulianh_Click(object sender, EventArgs e)
         {
             
         }
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_xulianh_Click_1(object sender, EventArgs e)
        {
            //Image background;
            OpenFileDialog openfiledialog = new OpenFileDialog();

            List<Bitmap> images = new List<Bitmap>();
            openfiledialog.Multiselect = true;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int i=0;
                    string[] nfile=openfiledialog.SafeFileNames;
                    string[] file = openfiledialog.FileNames;
                    foreach (string fileName in file)
                    {
                      
                        SaveImageData(new Bitmap(fileName),nfile[i]);
                        i++;
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
