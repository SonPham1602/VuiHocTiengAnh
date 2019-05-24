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
        List<Word> result;
        public Search()
        {
            InitializeComponent();
            lb_unit_name.Hide();
            lb_mean_word.Hide();
            btn_right.Hide();
            btn_left.Hide();
            lb_search_result.Hide();
          
        }
        int pos;// Vi tri mang hinh tim kiem duoc
    

        private void textbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                if (dic.FindAnyWord(textbox_search.Text).Count!= 0)
                {
                    lb_search_result.Show();
                    lb_unit_name.Show();
                    lb_mean_word.Show();
                    result = dic.FindAnyWord(textbox_search.Text);
                    if (result.Count >= 2) 
                    {
                        btn_left.Show();
                        btn_right.Show();
                    }
                    else
                    {
                        btn_right.Hide();
                        btn_left.Hide();
                    }
                    lb_search_result.Text = "1/" + result.Count.ToString();
                    hienthianh.Image = result[0].getAnh();
                    lb_unit_name.Text = dic.GetNameOfUnitByNumber(result[0].NameUnit).Replace("_"," ");
                    lb_mean_word.Text = result[0].GetMeanWord().Replace("_"," ");
                    pos = 0;
                }
                else
                {
                    btn_right.Hide();
                    btn_left.Hide();
                    lb_search_result.Hide();
                    lb_unit_name.Hide();
                    lb_mean_word.Hide();
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

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (pos == result.Count-1)
            {
                pos = 0;
            }
            else 
            {
                pos++;
            }
           
            lb_search_result.Text = (pos + 1).ToString() + "/" + result.Count.ToString();
            hienthianh.Image = result[pos].getAnh();
            lb_unit_name.Text = dic.GetNameOfUnitByNumber(result[pos].NameUnit).Replace("_", " ");
            lb_mean_word.Text = result[pos].GetMeanWord().Replace("_", " ");
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                pos = result.Count-1;
            }
            else
            {

                pos--;
            }
                lb_search_result.Text = (pos + 1).ToString()+"/" + result.Count.ToString();
                hienthianh.Image = result[pos].getAnh();
                lb_unit_name.Text = dic.GetNameOfUnitByNumber(result[pos].NameUnit).Replace("_", " ");
                lb_mean_word.Text = result[pos].GetMeanWord().Replace("_", " ");        
        }
       
       
    }
}
