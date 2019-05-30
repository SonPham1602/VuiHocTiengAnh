using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace Bai2
{
    public partial class Test : Form
    {
        Dictionary Dic =new Dictionary();
        public Test()
        {
            InitializeComponent();
           
        }
        enum Status
        {
            pause,
            run,
            waitSet
        }
        int NumberOfTest=0;// So Lan test duoc thuc hien
        int UnitHaveLeastNumberWord;// unit chua it tu nhat
        int SumWordOfLeastUnit;// so luong tu cua unit it nhat
        // thuoc tinh chuong trinh
        Status TrangThai;
        Timer timer1;
        public int[] Select_Unit;
        public int Time;
        int DemGiay = 0;
        int DemPhut = 0;
        int DemTongGiay = 0;
        int SoCauDung = 0;
        int SoCauSai = 0;
        public int Mode;//1 la random,0 la theo thu tu
        ThietLapDuLieu thietlap = new ThietLapDuLieu();
        public List<int> arrayfalseWord;
        //danh sach cac tu
        public int[] arrayWord ;
        //cac tu da su dung
        public List<int> arrayWordUsed;
        SoundPlayer tick = new SoundPlayer("data\\clocktick.wav");
        int vitrird = 0;//vi tri random
        public bool KiemTraQuayLai = false;
        public void HienThiThoiGian()
        {
            string hienthigiay, hienthiphut;

            if (DemGiay == 60)
            {
                DemPhut++;
                DemGiay = 0;
            }
            hienthigiay = DemGiay.ToString();
            hienthiphut = DemPhut.ToString();
            hien_thi_tg.Text = hienthiphut + ":" + hienthigiay;


        }
        private bool KiemTraHoanThanh()
        {

            for (int i = 0; i < arrayListWord.Length; i++)
            {
                if (arrayListWord[i] != -1)
                {
                    return false;
                }
            }
            return true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            so_cau_dung.Text = SoCauDung.ToString();
            so_cau_sai.Text = SoCauSai.ToString();
            if (SoCauDung == arrayListWord.Length)
            {
                timer1.Stop();
            
                //MessageBox.Show("CHÚC MỪNG BẠN ĐÃ HOÀN THÀNH BÀI KIỂM TRA", "THÔNG BÁO");
                //string temp = "";
                string[] listword = new string[arrayWord.Length];
                for (int i = 0; i < arrayWord.Length; i++)
                {
                    listword[i] = Dic.getWordByNumber(arrayWord[i]).getTu();
                }
                ResultTest result = new ResultTest(DemTongGiay.ToString(), SoCauDung,SoCauSai, null,listword);
                result.Show();
            }
            else
            {
                if (vitrird == arrayListWord.Length)
                {
                    vitrird = 0;
                    KiemTraQuayLai = true;
                }
                for (int i = vitrird; i < arrayListWord.Length; i++)
                {
                    if (arrayListWord[i] != -1)
                    {
                        hienthianh.Image = Dic.getImageWordByNumber(arrayListWord[i]);
                        lb_word.Text = Dic.GetMeanWord(arrayListWord[i]);
                        vitrird = i;
                        break;
                    }
                }
                HienThiThoiGian();
                DemGiay++;
                if (DemTongGiay == thietlap.Time_Test - 5)
                {

                    tick.Play();
                }
                if (DemTongGiay == thietlap.Time_Test)
                {
                    timer1.Stop();
                    //MessageBox.Show("HẾT GIỜ", "THÔNG BÁO");
                    string[] temp=new string[arrayListWord.Length];
                    string[] listword = new string[arrayWord.Length];
                    for (int i = 0; i < arrayWord.Length; i++)
                    {
                        listword[i] = Dic.getWordByNumber(arrayWord[i]).getTu();
                    }
                    for (int i = 0; i < arrayListWord.Length; i++)
                    {
                        if (arrayListWord[i] != -1)
                        {
                            temp[i] = Dic.getWordByNumber(arrayListWord[i]).getTu();
                        }
                    }
                   
                   
                    ResultTest result = new ResultTest(DemTongGiay.ToString(), SoCauDung, SoCauSai,temp,listword);
                    result.Show();
                }
                DemTongGiay++;
            }

        }
         
        private bool KiemTraTonTaiList(int n)// true la chua ton tai
        {
            // case 1 kiem tra ko the random
            int compare = NumberOfTest * thietlap.amountquestion;
            //MessageBox.Show(compare.ToString() + " " + Dic.ShowNumberWordOfUnit(UnitHaveLeastNumberWord));
            if (SumWordOfLeastUnit < compare)
            {
                //MessageBox.Show(compare.ToString() + " " + Dic.ShowNumberWordOfUnit(UnitHaveLeastNumberWord));
               // MessageBox.Show("da thuc hien  xoa");
                DeleteListUsed();
                NumberOfTest = 1;
                return false;
            }
           
             // Kiem tra trung trong Cac tu da su dung                          
            for (int i = 0; i < arrayWordUsed.Count; i++)
            {
                if (n == arrayWordUsed[i])
                {
                  
                    return false;
                }
            }

            for (int i = 0; i < arrayListWord.Length; i++)
            {
                if (n == arrayListWord[i])
                {
                    
                    return false;
                }

            }
            return true;
        }
        private void button_start_Click(object sender, EventArgs e)
        {
          
            if (thietlap.Time_Test == 0)
            {
                MessageBox.Show("Chưa cài đặt Chương Trình", "THÔNG BÁO");
            }
            else
            {
                UnitHaveLeastNumberWord = thietlap.ShowUnitHaveLeastWord();
                SumWordOfLeastUnit = Dic.ShowNumberWordOfUnit(UnitHaveLeastNumberWord);
                NumberOfTest++;


                KiemTraQuayLai = false;
                TrangThai = Status.run;
                arrayfalseWord = new List<int>();
                DemGiay = 0;
                DemPhut = 0;
                DemTongGiay = 0;
                SoCauDung = 0;
                SoCauSai = 0;
                ProfileUser.SoLanLamTest++;
                if (thietlap.Test_Mode == "Random")
                {
                    arrayListWord = new int[thietlap.amountquestion * thietlap.Select_Unit.Length];
                    int temp = 0;
                    vitrird = 0;
                    int s = new int();
                    int en = new int();
                    for (int i = 0; i < thietlap.Select_Unit.Length; i++)
                    {
                        Dic.getStartEndUnit(ref s, ref en, thietlap.Select_Unit[i]);
                        Random r = new Random();
                        for (int j = 0; j < thietlap.amountquestion; j++)
                        {
                            int r_temp;
                            do
                            {
                                r_temp = r.Next(s, en + 1);
                            } while (KiemTraTonTaiList(r_temp) == false);
                            arrayListWord[temp] = r_temp;
                            arrayWordUsed.Add(r_temp);
                            temp++;
                        }
                    }
                    arrayWord = (int[])arrayListWord.Clone();
                    timer1.Start();
                }
                else if (thietlap.Test_Mode == "Serialize")
                {
                    MessageBox.Show("chua cai dat");
                }

            }
            hien_thi_tg.Focus();
        }
        public void button_setup_Click(object sender, EventArgs e)
        {
            
            thietlap.ShowDialog();
            thietlap.FadeIn();
            hien_thi_tg.Focus();
        }
        private bool KiemTraTonTai(int vt)// tra ve true neu chua co, tra ve false neu ton tai
        {
            for (int i = 0; i < arrayfalseWord.Count; i++)
            {
                if (arrayfalseWord[i] == vt)
                {
                    return false;
                }
            }
            return true;
        }
        
        private bool removeListFalseWord(int value)
        {
            for (int i = arrayfalseWord.Count - 1; i >= 0; i--)
            {
                if (arrayfalseWord[i] == value)
                {
                    arrayfalseWord.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (arrayListWord != null)
            {
                switch (keyData)
                {
                    case Keys.Space:
                        if (TrangThai == Status.run)
                        {
                            if (KiemTraQuayLai == true)
                            {
                                SoCauSai--;
                            }

                            arrayListWord[vitrird] = -1;
                            SoCauDung++;
                            vitrird++;
                            //chuỗi các lệnh        
                        }
                        else
                        {
                            MessageBox.Show("Chương trình đang tạm dừng\n Bấm P để tiếp tục", "THÔNG BÁO");
                        }
                        break;

                    case Keys.S:
                        if (TrangThai == Status.run)
                        {
                            if (KiemTraQuayLai == false)
                            {
                                SoCauSai++;
                            }
                            vitrird++;
                        }
                        else
                        {
                            MessageBox.Show("Chương trình đang tạm dừng\n Bấm P để tiếp tục", "THÔNG BÁO");
                        }
                        //if (KiemTraTonTai(vitrird) == true)
                        //{
                        // arrayfalseWord.Add(vitrird);
                        //  
                        // }

                        //chuỗi các lệnh
                        break;
                    case Keys.P:
                        if (TrangThai == Status.pause)
                        {
                            timer1.Enabled = !timer1.Enabled;
                            TrangThai = Status.run;
                        }
                        else
                        {
                            timer1.Enabled = !timer1.Enabled;
                            TrangThai = Status.pause;
                            MessageBox.Show("Chương trình đang tạm dừng\n Bấm P để tiếp tục", "THÔNG BÁO");
                        }
                        break;
                   
                        //chuỗi các lệnh
                      
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Dic.ShowNumberWordOfUnit(1).ToString());
            arrayWordUsed = new List<int>();
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            hienthianh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Function delete all items in List Used
        /// </summary>
        private void DeleteListUsed()
        {
            arrayWordUsed.Clear();
        }
    }
}
