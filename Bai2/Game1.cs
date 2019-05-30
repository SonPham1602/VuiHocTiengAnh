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
    
    public enum difficultGame// Mức độ của game
    {
        easy,
        medium,
        hard
    }

    public partial class Game1 : Form
    {
        /// <summary>
        /// An cac cau hoi
        /// muc dich dung de 8 cau hoi
        /// </summary>
        private void HideAnswer()
        {
            answerE.Hide();
            answerF.Hide();
            answerG.Hide();
            answerH.Hide();
        }
        private void ShowAnswer()
        {
            answerE.Show();
            answerF.Show();
            answerG.Show();
            answerH.Show();
        }
        int numberAnswer;
        int Score;
        int nTrue;
        int nFalse;
        int TimeOfGame;
        //difficultGame dif;
        Dictionary dic=new Dictionary();
        int DemGiay,DemPhut;
        int DemTongGiay = 0;
        Timer time = new Timer();
        HamCanThiet f;
       // int posArray;// vi tri cua mang
        SettingGame thietlap = new SettingGame();
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
        private void SetAnswers(int number)
        {
            string s1, s2, s3, s4, s5, s6, s7, s8;
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
                Random r = new Random();
                int n = r.Next(1, 4);
                if (n == 1)
                {
                    answerA.Text = s1;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                }
                else if (n == 2)
                {
                    answerB.Text = s1;
                    answerA.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                }
                else if (n == 3)
                {
                    answerB.Text = s3;
                    answerA.Text = s2;
                    answerC.Text = s1;
                    answerD.Text = s4;
                }
                else if (n == 4)
                {
                    answerB.Text = s3;
                    answerA.Text = s2;
                    answerC.Text = s4;
                    answerD.Text = s1;
                }
            }
            else if (numberAnswer == 8)
            {
                dic.CreateAnswers(number, ref s1, ref s2, ref s3, ref s4,ref s5,ref s6,ref s7,ref s8);
                Random r = new Random();
                int n = r.Next(1, 8);
                if (n == 1)
                {
                    answerA.Text = s1;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s8;


                }
                else if (n == 2)
                {
                    answerA.Text = s2;
                    answerB.Text = s1;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s8;
                }
                else if (n == 3)
                {
                    answerA.Text = s3;
                    answerB.Text = s2;
                    answerC.Text = s1;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s8;
                }
                else if (n == 4)
                {
                    answerA.Text = s4;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s1;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s8;
                }
                else if (n == 5)
                {
                    answerA.Text = s5;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s1;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s8;
                }
                else if (n == 6)
                {
                    answerA.Text = s6;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s1;
                    answerG.Text = s7;
                    answerH.Text = s8;
                }
                else if (n == 7)
                {
                    answerA.Text = s7;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s1;
                    answerH.Text = s8;
                }
                else if (n == 8)
                {
                    answerA.Text = s8;
                    answerB.Text = s2;
                    answerC.Text = s3;
                    answerD.Text = s4;
                    answerE.Text = s5;
                    answerF.Text = s6;
                    answerG.Text = s7;
                    answerH.Text = s1;
                }
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
        private void ProcessGame(string TrueAnswer)// xử lý điểm trong game
        {
            //MessageBox.Show("/" + GetAnswer() + "/");
           // MessageBox.Show("/" + TrueAnswer + "/");
            if (thietlap.SoundInGame == true)
            {
                if (GetAnswer() == TrueAnswer)
                {
                    f.PlaySoundEffect("data\\true.wav");
                    // MessageBox.Show("dung");
                    Score++;
                    nTrue++;
                }
                else
                {
                    f.PlaySoundEffect("data\\false.wav");
                    Score--;
                    nFalse++;
                }

            }
            else
            {
                if (GetAnswer() == TrueAnswer)
                {   
                    // MessageBox.Show("dung");
                    Score++;
                    nTrue++;
                }
                else
                {
                    Score--;
                    nFalse++;
                }
            }
           
            lb_score.Text = Score.ToString();
            number_false.Text = nFalse.ToString();
            number_true.Text = nTrue.ToString();
        }
        public Game1()
        {
            Score = 0;
            f = new HamCanThiet();
            InitializeComponent();
           
          //  answerA.Checked = false;
            //ResetAnswers();
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            //radioButton4.Checked = false;
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

        void time_Tick(object sender, EventArgs e)
        {
           if(DemTongGiay==thietlap.timeGame)
            {
                time.Stop();
                if (Score > ProfileUser.DiemCaoNhatDatDuocGame)
                {
                    ProfileUser.DiemCaoNhatDatDuocGame = Score;
                }
                MessageBoxCustoms mess = new MessageBoxCustoms("Hết giờ\nSố điểm: "+Score.ToString()+"\nSố câu trả lời đúng: "+nTrue.ToString() + "\nSố câu trả lời sai: "+nFalse.ToString(), TypeMessageEnum.KETQUA);
                
            }
            else
            {

                HienThiThoiGian();
                DemGiay++;
            }        
            DemTongGiay++;

           
        }
        int n;// biến vị trí câu hỏi 
        //int[] arrayQuestion;
        private void bt_start_Click(object sender, EventArgs e)// bát đầu game
        {
            numberAnswer = thietlap.numberAnswers;
            TimeOfGame = thietlap.timeGame;
            if (TimeOfGame == 0)
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Bạn chưa thiết lập dữ liệu. Mời bạn nhấn nút cài đặt");
            }
            else
            {

                ProfileUser.SoLanChoiGame++;
                DemGiay = 0;
                DemPhut = 0;
                DemTongGiay = 0;
                nTrue = 0;
                nFalse = 0;
                Score = 0;
                lb_score.Text = Score.ToString();
                number_false.Text = nFalse.ToString();
                number_true.Text = nTrue.ToString();
                if(numberAnswer==8)
                {
                    ShowAnswer();
                }
                else
                {
                    HideAnswer();
                }
                //posArray = 1;            
                //arrayQuestion = thietlap.GetArrayQuestion();
                if(thietlap.CheckAllUnit==false)
                {
                    n = thietlap.GetQuestion();
                }
                else
                {
                    n = thietlap.GetQuestionAllUnit();
                }
                time.Start();// thơi gian chạy
                Score = 0;// khởi tạo điểm bằng 0
                nTrue = 0;
                nFalse = 0;             
                ResetAnswers();
                //Random r = new Random();
                //n = r.Next(0, dic.getNumberList());
                SetAnswers(n);
                pb_show.Image = dic.getImageWordByNumber(n);
                pb_next_qt.Show();
            }          
        }

        private void pb_next_qt_Click(object sender, EventArgs e)
        {
            if (GetAnswer() == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Bạn chưa chọn đáp án");
            }
            else
            {

                ProcessGame(dic.getWordByNumber(n).GetMeanWord());
                ResetAnswers();
                if (thietlap.CheckAllUnit == false)
                {
                    n = thietlap.GetQuestion();
                }
                else
                {
                    n = thietlap.GetQuestionAllUnit();
                }
                // Random r = new Random();
                //n = r.Next(0, dic.getNumberList());
                SetAnswers(n);
                pb_show.Image = dic.getImageWordByNumber(n);
            }
            
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void bt_setting_game_Click(object sender, EventArgs e)
        {         
            thietlap.ShowDialog();
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            label1.Select();
            time.Tick += time_Tick;
            time.Interval = 1000;
            pb_next_qt.Hide();
            TimeOfGame = 0;
            HideAnswer(); // an 4 cau E F G H
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBoxCustoms mess = new MessageBoxCustoms("Hướng dẫn: Chọn đáp án đúng với hình được đưa ra. Bạn có thể bật tắt âm thanh ở phần cài đặt game");
        }
    }
}
