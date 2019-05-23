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
    public partial class Search : Form
    {
        
        Dictionary dic=new Dictionary();
        public Search()
        {
            InitializeComponent();
            lb_unit_name.Hide();
            lb_mean_word.Hide();
          
        }

 

        private void textbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_unit_name.Show();
                lb_mean_word.Show();
                if (dic.FindAnyWord(textbox_search.Text) != null)
                {
                    Word result = dic.FindAnyWord(textbox_search.Text);
                    hienthianh.Image = result.getAnh();
                    lb_unit_name.Text = dic.GetNameOfUnitByNumber(result.NameUnit).Replace("_"," ");
                    lb_mean_word.Text = result.GetMeanWord().Replace("_"," ");
                }
                else
                {
                    MessageBoxCustoms mess = new MessageBoxCustoms("Không tìm thấy từ yêu cầu", TypeMessageEnum.THONGBAO);
                }
                textbox_search.ResetText();
               
            }
        }

        private void textbox_search_Click(object sender, EventArgs e)
        {
            textbox_search.ResetText();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBoxCustoms mess = new MessageBoxCustoms("Nhận từ cần tìm kiếm vào ô\nLưu ý nên nhập đúng và đầy đủ từ", TypeMessageEnum.THONGBAO);
        }

       
       
    }
}
