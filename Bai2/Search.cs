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
            tb_search.text = "";
        }

        private void tb_search_KeyPress(object sender, EventArgs e)
        {
            KeyPressEventArgs k = e as KeyPressEventArgs;
            if (k != null)
            {
                if (k.KeyChar == 13)
                {
                   
                    if (dic.FindWord(tb_search.text) != null)
                    {
                        hienthianh.Image = dic.FindWord(tb_search.text).getAnh();                                            
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy từ yêu cầu", "THÔNG BÁO");
                    }
                    tb_search.text = ""; 
                                    
                }
            }
           
        }
    }
}
