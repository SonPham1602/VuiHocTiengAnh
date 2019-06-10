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
    public partial class EditWordInUnitForm : Form
    {
        public bool ChangeCheck;
        private Image img;// this is picture, which need save
        private string pathImage = string.Empty;
        int numberChooseWord;
        Dictionary dic;
        public event EventHandler PerformForm1Click;// tao event phim ok
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                const int CS_DROPSHADOW = 0x20000;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        } 
        public EditWordInUnitForm()
        {
            InitializeComponent();
        }
        public EditWordInUnitForm(int numberword)
        {
            InitializeComponent();
            numberChooseWord = numberword;
            ChangeCheck = false;
        }


        private void SetWordWhenAwake()
        {
            pb_show.Image = dic.getImageWordByNumber(numberChooseWord);
            txtName.Text = dic.GetMeanWord(numberChooseWord);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void EditWordInUnitForm_Load(object sender, EventArgs e)
        {
            dic = new Dictionary();
            SetWordWhenAwake();
        }

        private void pb_help_Click(object sender, EventArgs e)
        {
            MessageBoxCustoms mess = new MessageBoxCustoms("Bạn có thể chọn nút Mở để chọn hình muốn đổi. Sau đó nhấn OK");
           
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
                   // txtName.Text = open.SafeFileName;
                    txtName.Text = dic.getWordByNumber(numberChooseWord).getTu();

                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (pathImage == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Bạn chưa chọn file hình ảnh", TypeMessageEnum.THONGBAO);
            }
            else
            {
                string path = @"data/images/" + dic.getWordByNumber(numberChooseWord).getTu() + ".dat"; ;
                SaveImageData(img, path);
                MessageBoxCustoms mess = new MessageBoxCustoms("Hình ảnh mới đã được cập nhật", TypeMessageEnum.THONGBAO);
                ChangeCheck = true;
                this.Close();
            }
           
        }
        public void SaveImageData(Image img, string namefile)// lưu ảnh cần save dưới dạng file nhị phân
        {
            namefile = namefile.Remove(namefile.LastIndexOf("."));
            string n = namefile + ".dat";
            img.Save(n);
        }
    }
}
