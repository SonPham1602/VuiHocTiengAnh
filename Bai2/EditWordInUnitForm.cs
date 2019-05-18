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
        int numberWord;
        Dictionary dic;
        public EditWordInUnitForm()
        {
            InitializeComponent();
        }
        public EditWordInUnitForm(int numberword)
        {
            InitializeComponent();
            numberWord = numberword;
        }


        private void SetWordWhenAwake()
        {
            pb_show.Image = dic.getImageWordByNumber(numberWord);
            txtName.Text = dic.GetMeanWord(numberWord);
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
            MessageBoxCustoms mess = new MessageBoxCustoms("hello");
           
        }
    }
}
