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
    public partial class Game4 : Form
    {
        Dictionary dic =new Dictionary();
        int Score;
        int nTrue;
        int nFalse;
        int DemGiay, DemPhut;
        HamCanThiet f=new HamCanThiet();
        Timer time = new Timer();
        int n;
        string word = string.Empty;
        public Game4()
        {
            InitializeComponent();
          
        }
        private void time_Tick(object sender, EventArgs e)
        {
            HienThiThoiGian();
            DemGiay++;
        }
        private void HideAnswers()
        {
            pb_audio.Hide();
            answerA.Hide();
            answerB.Hide();
            answerC.Hide();
            answerD.Hide();
            pb_answerA.Hide();
            pb_answerB.Hide();
            pb_answerC.Hide();
            pb_answerD.Hide();
        }
        private void ShowAnswers()
        {
            pb_audio.Show();
            answerA.Show();
            answerB.Show();
            answerC.Show();
            answerD.Show();
            pb_answerA.Show();
            pb_answerB.Show();
            pb_answerC.Show();
            pb_answerD.Show();
        }
        private void ResetAnswers()// tra tất cả button về false
        {
            answerA.Checked = false;
            answerB.Checked = false;
            answerC.Checked = false;
            answerD.Checked = false;
        }
        private string GetAnswer()// lấy câu trả lời đc chọn
        {
            if (answerA.Checked == true)
            {
                return answerA.Text;
            }
            else if (answerB.Checked == true)
            {
                return answerB.Text;
            }
            else if (answerC.Checked == true)
            {
                return answerC.Text;
            }
            else if (answerD.Checked == true)
            {
                return answerD.Text;
            }
            else
            {
                return "";
            }
        }
        Image img1, img2, img3, img4;
        int rand;
        string TrueAnswer = string.Empty;

        private void SetAnswers(int number)//tao cau hoi
        {

            dic.CreateAnswers(ref n, ref img1, ref img2, ref img3, ref img4, 0, dic.getNumberList());
            word = dic.GetMeanWord(n);
            Random r = new Random();
            rand = r.Next(1, 4);
            if (rand == 1)
            {
                TrueAnswer = "A";
                pb_answerA.Image = img1;
                pb_answerB.Image = img2;
                pb_answerC.Image = img3;
                pb_answerD.Image = img4;
            }
            else if (rand == 2)
            {
                TrueAnswer = "B";
                pb_answerA.Image = img2;
                pb_answerB.Image = img1;
                pb_answerC.Image = img3;
                pb_answerD.Image = img4;
            }
            else if (rand == 3)
            {
                TrueAnswer = "C";
                pb_answerA.Image = img3;
                pb_answerB.Image = img2;
                pb_answerC.Image = img1;
                pb_answerD.Image = img4;
            }
            else if (rand == 4)
            {
                TrueAnswer = "D";
                pb_answerA.Image = img4;
                pb_answerB.Image = img2;
                pb_answerC.Image = img3;
                pb_answerD.Image = img1;
            }
        }
        private void ProcessGame(string TrueAnswer)// xử lý điểm trong game
        {
            //MessageBox.Show("/" + GetAnswer() + "/");
            // MessageBox.Show("/" + TrueAnswer + "/");
            if (GetAnswer() == TrueAnswer)
            {
                // MessageBox.Show("dung");
                f.PlaySoundEffect("data\\true.wav");
                Score++;
                nTrue++;
            }
            else
            {
                f.PlaySoundEffect("data\\false.wav");
                Score--;
                nFalse++;
            }
            lb_score.Text = Score.ToString();
            number_false.Text = nFalse.ToString();
            number_true.Text = nTrue.ToString();
        }
        private void bt_start_Click(object sender, EventArgs e)
        {
            Score = 0;
            nTrue = 0;
            nFalse = 0;
            ResetAnswers();
            SetAnswers(n);
            ShowAnswers();
            time.Start();
            pb_next_qt.Show();
          
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pb_answerA_Click(object sender, EventArgs e)
        {
            answerA.Checked = true;
        }

        private void pb_answerC_Click(object sender, EventArgs e)
        {
            answerC.Checked = true;
        }

        private void pb_answerB_Click(object sender, EventArgs e)
        {
            answerB.Checked = true;
        }

        private void pb_answerD_Click(object sender, EventArgs e)
        {
            answerD.Checked = true;
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

        private void pb_next_qt_Click(object sender, EventArgs e)
        {
            if (GetAnswer() == "")
            {
                MessageBox.Show("Bạn chưa nhập câu trả lời", "THÔNG BÁO");
            }
            else
            {
               
                ProcessGame(TrueAnswer);
                ResetAnswers();
                SetAnswers(n);                    
                f.AudioVoice(word, 100, 0);
            }
            
        }

        private void pb_audio_Click(object sender, EventArgs e)
        {
            f.AudioVoice(word, 100, 0);
        }
      

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 

        private void Game4_Load(object sender, EventArgs e)
        {
           
            time.Tick += time_Tick;
            time.Interval = 1000;
            pb_next_qt.Hide();
            HideAnswers();
        }
    }
}
