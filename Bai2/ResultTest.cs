using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Bai2
{
    public partial class ResultTest : Form
    {
        private string CheckTrueOrFalse(string str, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (str == arr[i])
                {
                    return "False";
                }
            }
            return "True";
        }
        public ResultTest(string time,int n_true,int n_false,string [] listflase,string[] allword)
        {          
            InitializeComponent();
            if (listflase == null)
            {
                for (int i = 0; i < allword.Length; i++)
                {
                    lv_ShowResult.Items.Add(AddItemListView((i + 1).ToString(), allword[i],"True"));
                }
            }
            else
            {
                for (int i = 0; i < allword.Length; i++)
                {

                    lv_ShowResult.Items.Add(AddItemListView((i + 1).ToString(), allword[i], CheckTrueOrFalse(allword[i], listflase)));
                }
            }
         
            SoundPlayer clap = new SoundPlayer("data\\applause.wav");
            clap.Play();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            label_false.Text = "False:" + n_false.ToString();
            label_true.Text = "True:" + n_true.ToString();
            label_time.Text = "Time:  " + time + "  seconds";
           // picture_teacher.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private ListViewItem AddItemListView(string stt,string word,string status)
        {
            
            ListViewItem itm = new ListViewItem(stt);
            itm.SubItems.Add(word);
            itm.SubItems.Add(status);
            if (status == "True")
            {
                itm.ForeColor = Color.Green;
            }
            else
            {
                itm.ForeColor = Color.Red;
            }
            return itm;

        }
        private void ResultTest_Load(object sender, EventArgs e)
        {
        }


        private void lv_ShowResult_DoubleClick(object sender, EventArgs e)
        {
            if (lv_ShowResult.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_ShowResult.SelectedItems;

                ListViewItem lvItem = items[0];
                string image = lvItem.SubItems[1].Text;
                ShowImageTestResult form = new ShowImageTestResult(image);
                form.Show();

            }
        }
    }
}
