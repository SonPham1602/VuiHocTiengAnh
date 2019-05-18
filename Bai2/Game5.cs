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
    public partial class Game5 : Form
    {
        Dictionary dic = new Dictionary();
        int Score;
        int nTrue;
        int nFalse;
        int DemGiay, DemPhut;
        HamCanThiet f;
        Timer time = new Timer();
        int n;
        string word = string.Empty;
        public Game5()
        {
            InitializeComponent();
            f = new HamCanThiet();
            time.Tick += time_Tick;
            time.Interval = 1000;
            pb_next_qt.Hide();
            HideControl();
        }

        private void HideControl()
        {
            lb_hint.Hide();
            tb_input_word.Hide();
            pb_hint.Hide();
        }

        private void ShowControl()
        {
            lb_hint.Show();
            tb_input_word.Show();
            pb_hint.Show();
        }

        private void SetAnswer()
        {
            Random r = new Random();
            n = r.Next(0, dic.getNumberList());
            word = dic.GetMeanWord(n);
            pb_show.Image = dic.getImageWordByNumber(n);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            HienThiThoiGian();
            DemGiay++;
        }
        private void ResetAnswer()
        {
            lb_hint.Text = "";
            tb_input_word.Text = "";
               
        }

        private void bt_close_Click(object sender, EventArgs e)// tat game
        {
            this.Close();
        }

        private void bt_start_Click(object sender, EventArgs e)// bat dau
        {
            pb_next_qt.Show();
            ShowControl();
            ResetAnswer();
            SetAnswer();
        }

        private void ProcessGame(string TrueAnswer)// xử lý điểm trong game
        {
            //MessageBox.Show("/" + GetAnswer() + "/");
            // MessageBox.Show("/" + TrueAnswer + "/");
            if (word == TrueAnswer)// dung 
            {
                f.PlaySoundEffect("data\\true.wav");
                // MessageBox.Show("dung");
                Score++;
                nTrue++;
            }
            else// sai 
            {
                f.PlaySoundEffect("data\\false.wav");
                Score--;
                nFalse++;
            }
            lb_score.Text = Score.ToString();
            number_false.Text = nFalse.ToString();
            number_true.Text = nTrue.ToString();
        }

        private void pb_next_qt_Click(object sender, EventArgs e)//cau hoi tiep theo
        {
            ProcessGame(tb_input_word.Text);
            ResetAnswer();
            SetAnswer();
        }

        private void HienThiThoiGian()// ham hien thi thoi gian cho client
        {

            string hienthigiay, hienthiphut;

            if (DemGiay == 60)
            {
                DemPhut++;
                DemGiay = 0;
            }
            if (DemGiay <= 9)// tạo ra kí tự 00:00
            {
                hienthigiay = "0" + DemGiay.ToString();
            }
            else
            {
                hienthigiay = DemGiay.ToString();
            }
            if (DemPhut <= 9)// tạo ra kí tự 00:00
            {
                hienthiphut = "0" + DemPhut.ToString();
            }
            else
            {
                hienthiphut = DemPhut.ToString();
            }
            hien_thi_tg.Text = hienthiphut + ":" + hienthigiay;
        }

        private void tb_input_word_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (Char.IsDigit(c))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ", "Thông báo");

            }
        }

        private string HintWord(string str)
        {
            if (str == word)
            {
                return str;
            }
            if (str == "")
            {
                return word[0].ToString();
            }
            int pos=new int();// vi tri tu sai
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != word[i])
                {
                    pos = i;
                    break;
                }
                if (i == str.Length - 1)
                {
                    pos = str.Length;
                }
            }
            string hint = string.Empty;
            for (int i = 0; i < pos; i++)
            {
                hint = word.Substring(0, pos + 1);
            }
            return hint;
        }

        private void pb_hint_Click(object sender, EventArgs e)
        {
            lb_hint.Text = HintWord(tb_input_word.Text);
        }

    }
}
