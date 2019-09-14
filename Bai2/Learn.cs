using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;

namespace Bai2
{
    public partial class Learn : Form
    {
        private bool MarkWord;
        public void SetDefault()// ham set tat ca trag thai font label ve kich thuoc mac dinh
        {
            Font f = new Font("Circle", 14.25F, FontStyle.Italic);
            Size s = new Size(196, 37);
            Size s1=new Size(196, 45);
            lb1.Font = f;
            lb2.Font = f;
            lb3.Font = f;
            lb4.Font = f;
            select_unit.Size = s;
            Select_voice.Size = s;
            volume_voice.Size = s1;
            speed_voice.Size = s1; 

        }
        public void SetSizeLable(int s)//hàm set kích thước của label 
        {
            Font f = new Font("Circle", s, FontStyle.Italic);
            lb1.Font = f;
            lb2.Font = f;
            lb3.Font = f;
            lb4.Font = f;
        }
        public void SetSizeControl(int s)// set kích thước của các control
        {
            Size size = new Size(s, 37);
            Size s1 = new Size(s, 45);
            select_unit.Size = size;
            Select_voice.Size = size;
            volume_voice.Size = s1;
            speed_voice.Size = s1; 

        }
        string XulyChuoi(string s)// thay thế "_" thành " "
        {
            while (s.IndexOf("_") != -1)
            {
                s = s.Replace("_"," ");
            }
            return s;
        }
        int temp_start;
        int start;
        int end;
       
        public Learn()
        {
            InitializeComponent();
            lb_mean_word.Hide();
            pb_mark.Hide();
            SetDataListUnit();

        }
        bool checkSelectUnit()
        {
            if (select_unit.CanSelect)
            {
                return false;
            }
            return true;
        }
        private void pb_next_Click(object sender, EventArgs e)
        {
  
            if (select_unit.selectedIndex!=-1)
            {
                if (temp_start == end)
                {
                    temp_start = start;
                }
                else
                {
                    temp_start++;
                }
                if (ProfileUser.CheckWordOnList(Mainform.Dic.getWordByNumber(temp_start).getTu()) == true)
                {
                    pb_mark.Image = Properties.Resources.star;
                }
                else
                {
                    pb_mark.Image = Properties.Resources.star1;
                }

                if (Mainform.Dic.getWordByNumber(temp_start).checkImageExist() == true)
                {
                    hienthianh.Image = Mainform.Dic.getWordByNumber(temp_start).getAnh();
                }
                else
                {
                    hienthianh.Image = Image.FromFile(@"data/emptyImage.png");
                }
            
                lb_mean_word.Text = XulyChuoi(Mainform.Dic.GetMeanWord(temp_start));
            }
            else
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Chưa chọn bài chọn",TypeMessageEnum.THONGBAO);
            }
           

        }
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        private void pb_audio_Click(object sender, EventArgs e)
        {
            
            string s = lb_mean_word.Text;
            //if (speechSynthesizer == null)
            //{
               
            //}
            //foreach (InstalledVoice voice in speechSynthesizer.GetInstalledVoices())
            //{
            //    VoiceInfo info = voice.VoiceInfo;

            //   MessageBox.Show(" Name:          " + info.Name);
            //    MessageBox.Show(" Culture:       " + info.Culture);
            //    MessageBox.Show(" Age:           " + info.Age);
            //    MessageBox.Show(" Gender:        " + info.Gender);
            //    MessageBox.Show(" Description:   " + info.Description);
            //    Console.WriteLine(" ID:            " + info.Id);
            //}
            if (select_unit.selectedIndex != -1)
            {
                if (Select_voice.selectedValue == "Male")
                {
                    speechSynthesizer.SelectVoice("Microsoft David Desktop");
                    //speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                }
                if (Select_voice.selectedValue == "Female")
                {
                    speechSynthesizer.SelectVoice("Microsoft Zira Desktop");
                    //speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
                }

                speechSynthesizer.Volume = volume_voice.Value;  // 0...100  
                speechSynthesizer.Rate = speed_voice.Value;
                speechSynthesizer.SpeakAsync(s); 
            }
            else
            {
                 MessageBoxCustoms mess = new MessageBoxCustoms("Chưa chọn bài học",TypeMessageEnum.THONGBAO);
              
            }
             
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            if (select_unit.selectedIndex != -1)
            {
                if (temp_start == start)
                {
                    temp_start = end;
                }
                else
                {
                    temp_start--;
                }
                if (ProfileUser.CheckWordOnList(Mainform.Dic.getWordByNumber(temp_start).getTu()) == true)
                {
                    pb_mark.Image = Properties.Resources.star;
                }
                else
                {
                    pb_mark.Image = Properties.Resources.star1;
                }
                if (Mainform.Dic.getWordByNumber(temp_start).checkImageExist() == true)
                {
                    hienthianh.Image = Mainform.Dic.getWordByNumber(temp_start).getAnh();
                }
                else
                {
                    hienthianh.Image = Image.FromFile(@"data/emptyImage.png");
                }
                lb_mean_word.Text = XulyChuoi(Mainform.Dic.GetMeanWord(temp_start));
            }
            else
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Chưa chọn bài học", TypeMessageEnum.THONGBAO);
            }
        }
        int GetUnitNumber(string str)
        {
            int result;
             if (str[6] == ' ')
            {
                result = str[5] - 48;
            }
            else
            {
                int n = (str[5] - 48) * 10 + str[6] - 48;
                result= n;
            }
            return result;
        }
        private void select_unit_onItemSelected(object sender, EventArgs e)
        {
            
            int Selected_unit=select_unit.selectedIndex+1;
            //MessageBox.Show(Selected_unit.ToString());
            Mainform.Dic.getStartEndUnit(ref start, ref end, Selected_unit);// luu y la phai them ref neu ham co ref
            temp_start = start;
            if (Mainform.Dic.getWordByNumber(temp_start).checkImageExist() == true)
            {
                hienthianh.Image = Mainform.Dic.getWordByNumber(temp_start).getAnh();
            }
            else
            {
                hienthianh.Image = Image.FromFile(@"data/emptyImage.png");
            }
            
            lb_mean_word.Text = XulyChuoi(Mainform.Dic.GetMeanWord(temp_start));
            lb_mean_word.Show();
            pb_mark.Show();

        }

      

        private void pb_reset_Click(object sender, EventArgs e)
        {
            volume_voice.Value = 100;  // 0...100  
            speed_voice.Value = 0;
            

        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBoxCustoms mess = new MessageBoxCustoms("Chọn Unit cần học ở thanh bên trái. Bạn có thể lưu những từ vựng cần chú ý bằng cách đánh dấu sao", TypeMessageEnum.THONGBAO);
        }

        private void pb_mark_Click(object sender, EventArgs e)
        {
            MarkWord = !MarkWord;
            if (MarkWord==true)
            {
                ProfileUser.DsChuaThuoc.Add(Mainform.Dic.getWordByNumber(temp_start).getTu());
                pb_mark.Image = Properties.Resources.star;
            }
            else
            {
                pb_mark.Image = Properties.Resources.star1;
            }
            
        }
        private void SetDataListUnit()
        {
            select_unit.Clear();
            for (int i = 0; i < Mainform.Dic.getNumberOfUnit(); i++)
            {
                select_unit.AddItem(Mainform.Dic.GetNameOfUnitByNumber(i+1));
            }
        }

    }
}
