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
    public partial class Game2 : Form
    {
        private void  ShowAnswers()
        {
            answerE.Show();
            answerF.Show();
            answerG.Show();
            answerH.Show();
            pb_answerE.Show();
            pb_answerF.Show();
            pb_answerH.Show();
            pb_answerG.Show();
        }
        private void HideAnswers()
        {
            answerE.Hide();
            answerF.Hide();
            answerG.Hide();
            answerH.Hide();
            pb_answerE.Hide();
            pb_answerF.Hide();
            pb_answerH.Hide();
            pb_answerG.Hide();
        }
        // so cau hoi 
        int numberAnswer;
        int TimeOfGame;
      
        SettingGame thietlap = new SettingGame();
     
        private string ansA, ansB, ansC, ansD,ansE,ansF,ansG,ansH;
        private string  s1, s2, s3, s4,s5,s6,s7,s8;
        HamCanThiet f;
        Dictionary dic=new Dictionary();
        private int n;
        Timer time =new Timer() ;
        private string TrueAnswer = string.Empty;
        int Score;
        int nTrue;
        int nFalse;
        int DemGiay, DemPhut,DemTongGiay;
        public Game2()
        {
            InitializeComponent();        
        }

        private void time_Tick(object sender, EventArgs e)
        {

            if (DemTongGiay == thietlap.timeGame)
            {
                time.Stop();
                if (Score > ProfileUser.DiemCaoNhatDatDuocGame)
                {
                    ProfileUser.DiemCaoNhatDatDuocGame = Score;
                }
                MessageBoxCustoms mess = new MessageBoxCustoms("Hết giờ\nSố điểm: " + Score.ToString() + "\nSố câu trả lời đúng: " + nTrue.ToString() + "\nSố câu trả lời sai: " + nFalse.ToString(), TypeMessageEnum.KETQUA);
            }
            else
            {

                HienThiThoiGian();
                DemGiay++;
            }
            DemTongGiay++;
        }
        private void ResetAnswers()// tra tất cả button về false
        {
            answerA.Checked = false;
            answerB.Checked = false;
            answerC.Checked = false;
            answerD.Checked = false;
            answerE.Checked = false;
            answerF.Checked = false;
            answerG.Checked = false;
            answerH.Checked = false;
        }
        private void SetAnswers(int number)//tao cau hoi
        {
            s1 = string.Empty;
            s2 = string.Empty;
            s3 = string.Empty;
            s4 = string.Empty;
            s5 = string.Empty;
            s6 = string.Empty;
            s7 = string.Empty;
            s8 = string.Empty;
            if (numberAnswer == 4)
            {
                dic.CreateAnswers(number, ref s1, ref s2, ref s3, ref s4);
            }
            else
            {
                dic.CreateAnswers(number, ref s1, ref s2, ref s3, ref s4,ref s5,ref s6,ref s7,ref s8);
            }
            
            
            

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
            else if (answerE.Checked == true)
            {
                return answerE.Text;
            }
            else if (answerF.Checked == true)
            {
                return answerF.Text;
            }
            else if (answerG.Checked == true)
            {
                return answerG.Text;
            }
            else if (answerH.Checked == true)
            {
                return answerH.Text;
            }
            else
            {
                return "";
            }
        }
        
        private void StartVoice(int volume,int speed)
        {
            //Thread thd = new Thread(() =>
            //{
            //    Thread.Sleep(10000);
            //    MessageBox.Show("Đăng nhâp thành công! ");
            //});
            if (numberAnswer == 4)
            {
                Random r = new Random();
                n = r.Next(1, 4);
                if (n == 1)
                {
                    TrueAnswer = "A";
                    ansA = s1;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                }
                else if (n == 2)
                {
                    ansA = s2;
                    ansB = s1;
                    ansC = s3;
                    ansD = s4;
                    TrueAnswer = "B";
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                }
                else if (n == 3)
                {
                    ansA = s3;
                    ansB = s2;
                    ansC = s1;
                    ansD = s4;
                    TrueAnswer = "C";
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                }
                else if (n == 4)
                {
                    ansA = s4;
                    ansB = s2;
                    ansC = s3;
                    ansD = s1;
                    TrueAnswer = "D";
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                }
            }
            else
            {


                Random r = new Random();
                n = r.Next(1, 8);
                if (n == 1)
                {
                    TrueAnswer = "A";
                    ansA = s1;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    ansE = s5;
                    ansF = s6;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 2)
                {
                    TrueAnswer = "B";
                    ansA = s2;
                    ansB = s1;
                    ansC = s3;
                    ansD = s4;
                    ansE = s5;
                    ansF = s6;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 3)
                {
                    TrueAnswer = "C";
                    ansA = s3;
                    ansB = s2;
                    ansC = s1;
                    ansD = s4;
                    ansE = s5;
                    ansF = s6;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 4)
                {
                    TrueAnswer = "D";
                    ansA = s4;
                    ansB = s2;
                    ansC = s3;
                    ansD = s1;
                    ansE = s5;
                    ansF = s6;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 5)
                {
                    TrueAnswer = "E";
                    ansA = s5;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    ansE = s1;
                    ansF = s6;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 6)
                {
                    TrueAnswer = "F";
                    ansA = s6;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    ansE = s5;
                    ansF = s1;
                    ansG = s7;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 7)
                {
                    TrueAnswer = "G";
                    ansA = s7;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    ansE = s5;
                    ansF = s6;
                    ansG = s1;
                    ansH = s8;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                }
                else if (n == 8)
                {
                    TrueAnswer = "H";
                    ansA = s8;
                    ansB = s2;
                    ansC = s3;
                    ansD = s4;
                    ansE = s5;
                    ansF = s6;
                    ansG = s7;
                    ansH = s1;
                    f.AudioVoice("A", volume, speed);
                    f.AudioVoice(s8, volume, speed);
                    f.AudioVoice("B", volume, speed);
                    f.AudioVoice(s2, volume, speed);
                    f.AudioVoice("C", volume, speed);
                    f.AudioVoice(s3, volume, speed);
                    f.AudioVoice("D", volume, speed);
                    f.AudioVoice(s4, volume, speed);
                    f.AudioVoice("E", volume, speed);
                    f.AudioVoice(s5, volume, speed);
                    f.AudioVoice("F", volume, speed);
                    f.AudioVoice(s6, volume, speed);
                    f.AudioVoice("G", volume, speed);
                    f.AudioVoice(s7, volume, speed);
                    f.AudioVoice("H", volume, speed);
                    f.AudioVoice(s1, volume, speed);
                }
            }


           
        }
       
        private void pb_start_game_Click(object sender, EventArgs e)
        {
            TimeOfGame = thietlap.timeGame;
            numberAnswer = thietlap.numberAnswers;
            if (TimeOfGame == 0)
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Bạn chưa thiết lập dữ liệu", TypeMessageEnum.THONGBAO);
    
            }
            else
            {
                ProfileUser.SoLanChoiGame++;
                Score = 0;
                nTrue = 0;
                nFalse = 0;
                DemGiay = 0;
                DemPhut = 0;
                DemTongGiay = 0;
                lb_score.Text = Score.ToString();
                number_false.Text = nFalse.ToString();
                number_true.Text = nTrue.ToString();
                if (numberAnswer == 8)
                {
                    ShowAnswers();
                }
                else
                {
                    HideAnswers();
                }
                if (thietlap.CheckAllUnit == false)
                {
                    n = thietlap.GetQuestion();
                }
                else
                {
                    n = thietlap.GetQuestionAllUnit();
                }
               
                ResetAnswers();
               // Random r = new Random();
               // n = r.Next(0, dic.getNumberList());
                pb_show.Image = dic.getImageWordByNumber(n);
                SetAnswers(n);
                StartVoice(100, 0);
                time.Start();
                pb_next_question.Show();
            }
        }

        private void pb_answerA_Click(object sender, EventArgs e)
        {
            if (ansA != "")
            {
                f.AudioVoice(ansA,100,0);
            }
            
        }

        private void pb_answerB_Click(object sender, EventArgs e)
        {
            if (ansB != "")
            {
                f.AudioVoice(ansB, 100, 0);
            }
        }

        private void pb_answerC_Click(object sender, EventArgs e)
        {
            if (ansC != "")
            {
                f.AudioVoice(ansC, 100, 0);
            }
        }

        private void pb_answerD_Click(object sender, EventArgs e)
        {
            if (ansD != "")
            {
                f.AudioVoice(ansD, 100, 0);
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
        private void pb_next_question_Click(object sender, EventArgs e)
        {
            if (GetAnswer() == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Bạn chưa nhập câu trẳ lời", TypeMessageEnum.THONGBAO);
            }
            else
            {
                ProcessGame(TrueAnswer);
                ResetAnswers();
                //Random r = new Random();
                //n = r.Next(0, dic.getNumberList());
                if (thietlap.CheckAllUnit == false)
                {
                    n = thietlap.GetQuestion();
                }
                else
                {
                    n = thietlap.GetQuestionAllUnit();
                }
                //n = arrayQuestion[posArray++];
                pb_show.Image = dic.getImageWordByNumber(n);
                SetAnswers(n);
                StartVoice(100, 0);
            }
           
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

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_show_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void pb_show_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void Game2_Load(object sender, EventArgs e)
        {
            f = new HamCanThiet();
            time.Tick += time_Tick;
            time.Interval = 1000;
            pb_next_question.Hide();
            HideAnswers();
        }

        private void bt_setting_game_Click(object sender, EventArgs e)
        {
            thietlap.ShowDialog();
        }

        private void pb_answerE_Click(object sender, EventArgs e)
        {
            if (ansE != "")
            {
                f.AudioVoice(ansE, 100, 0);
            }
        }

        private void pb_answerH_Click(object sender, EventArgs e)
        {
            if (ansH != "")
            {
                f.AudioVoice(ansH, 100, 0);
            }
        }

        private void pb_answerG_Click(object sender, EventArgs e)
        {
            if (ansG != "")
            {
                f.AudioVoice(ansG, 100, 0);
            }
        }

        private void pb_answerF_Click(object sender, EventArgs e)
        {
            if (ansF != "")
            {
                f.AudioVoice(ansF, 100, 0);
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBoxCustoms mess = new MessageBoxCustoms("Hướng dẫn: Chọn âm thanh đúng với hình được đưa ra. Bạn có thể bật tắt âm thanh đúng/sai ở phần cài đặt game", TypeMessageEnum.THONGBAO);
        }


    }
}
