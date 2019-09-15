using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai2
{
    public partial class ThietLapDuLieu : Form
    {
        public void FadeClose(object sender, EventArgs e)// tao hieu ung tat cho form chinh
        {
            int loopctr = 0;
            for (loopctr = 100; loopctr >= 5; loopctr -= 5)
            {
                this.Opacity = loopctr / 95.0;              
                System.Threading.Thread.Sleep(10);
               // this.Refresh();// khong can cai nay cung dc,Luu y: tim hieu re this.refresh 
            }
            this.Opacity = 0;
        }
         
        public void FadeIn()
        {
            timeFadeIn.Start();
        }
        Timer timeFadeIn = new Timer();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public ThietLapDuLieu()
        {
            InitializeComponent();
            combobox_mode.DropDownStyle = ComboBoxStyle.DropDownList;
            Time_Test = 0;
            combobox_mode.SelectedIndex = 0;
            timeFadeIn.Interval = 10;
            timeFadeIn.Tick += time_Tick_Fade_In;
            
        }

        void time_Tick_Fade_In(object sender, EventArgs e)
        {
          //  this.Refresh();
            this.Opacity += .05;       
            if (this.Opacity == 1)
            {
                timeFadeIn.Stop();
            }
        }
        public delegate void GETDATA(int [] mang);
        public GETDATA mydata;
       /// <summary>
       /// bien kiem tra co chon het cac unit ko 
       /// </summary>
        public bool AllUnit;
        private bool Check()
        {
            AllUnit = checkAllUnit.Checked;
            //if (AllUnit == true)
            //{
            //    for (int i = 0; i < Int32.Parse(textbox_qt_number.Text); i++)
            //    {

            //    }
            //}
            if (textbox_time.Text == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Thời gian không có giá trị");
                return false;
            }
            else if (combobox_mode.Text == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để trống Test Mode");
               
                return false;
            }     
            else if (textbox_start_unit.Text != "" && textbox_end_unit.Text == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để trống End Unit");
            
                return false;
            }
            else if (textbox_start_unit.Text == "" && textbox_end_unit.Text != "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để trống Start Unit");
                return false;
            }
            else if (textbox_start_unit.Text != "" && textbox_end_unit.Text != "")
            {
                if (Int32.Parse(textbox_start_unit.Text) == 0)
                {
                    MessageBoxCustoms mess = new MessageBoxCustoms("Không được nhập Start Unit bằng 0");
                    
                    return false;
                }
                if (Int32.Parse(textbox_end_unit.Text) <=Int32.Parse(textbox_start_unit.Text))
                {
                  
                    MessageBoxCustoms mess = new MessageBoxCustoms("Start phải nhỏ hơn End");
                    return false;
                }
                
            }
             if (textbox_qt_number.Text == "" && combobox_mode.Text=="Random")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để số câu trống");
                
                return false;
            }
             else if (combobox_mode.Text == "Random" && textbox_qt_number.Text != "")
            {
                 amountquestion = Int32.Parse(textbox_qt_number.Text);
            }
            int temp=0;
            foreach (string str in checkedListBox_Select_units.CheckedItems)
            {
                temp++;
            }
            if (temp == 0 && textbox_end_unit.Text=="" )
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Phải chọn ít nhất một Unit");
               
                return false;
            }
            else
            {
                Select_Unit = new int[temp];
                int dem=0;
                foreach (string str in checkedListBox_Select_units.CheckedItems)
                {
                    if (str[6] == ' ')
                    {                        
                       Select_Unit[dem]= str[5]-48;
                    }
                    else
                    {
                        int n= (str[5]-48)*10+str[6]-48;
                        Select_Unit[dem] =n;
                    }
                    dem++;
                }
            }
            if (textbox_end_unit.Text != "" && textbox_start_unit.Text != "")
            {
                Start_Unit = Int32.Parse(textbox_start_unit.Text);
                End_Unit = Int32.Parse(textbox_end_unit.Text);
                int dem = 0;
                Select_Unit = new int[End_Unit-Start_Unit+1];
                for (int i = Start_Unit; i <= End_Unit; i++)
                {
                    Select_Unit[dem] = i;
                    dem++;
                }
            }

            if (amountquestion == 0 && combobox_mode.Text != "Serialize")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Số câu hỏi không được cài đặt là 0");
              
                return false;
            }
            Time_Test = Int32.Parse(textbox_time.Text);
            if(Time_Test==0)
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Thời gian không được cài đặt là 0");
              
                return false;
            }
            Test_Mode = combobox_mode.Text;
            return true;

        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                FadeClose(sender,e);
               
                this.Hide();
            }
            label1.Focus();
            
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            label1.Focus();
            FadeClose(sender, e);
            
            this.Hide();
        }

        private void textbox_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBoxCustoms mess = new MessageBoxCustoms("Chỉ được nhập số");
               
            }
        }

        private void textbox_start_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBoxCustoms mess = new MessageBoxCustoms("Chỉ được nhập số");
               
            }
        }

        private void textbox_end_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBoxCustoms mess = new MessageBoxCustoms("Chỉ được nhập số");
               
            }
        }

        private void textbox_qt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBoxCustoms mess = new MessageBoxCustoms("Chỉ được nhập số");
            }
        }

        private void combobox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_mode.Text == "Question numbers")
            {
                lb_hienthisocauhoi.Text = "Question number";
            }
            else
            {
                lb_hienthisocauhoi.Text = "Question number/Unit";
            }
            if (combobox_mode.Text == "Serialize")
            {
                textbox_qt_number.Enabled = false;
            }
            else
            {
                textbox_qt_number.Enabled = true;
            }
        }

        

        //public int[] GetArrayQuestion()
        //{
        //    Dictionary Dic = new Dictionary();
        //    int [] arrayListWord = new int[amountquestion * Select_Unit.Length];
        //    int s = new int();
        //    int en = new int();
        //    int temp = 0;
        //    for (int i = 0; i < Select_Unit.Length; i++)
        //    {
        //        Dic.getStartEndUnit(ref s, ref en,Select_Unit[i]);
        //        Random r = new Random();
        //        for (int j = 0; j < amountquestion; j++)
        //        {
        //            int r_temp;
        //            r_temp = r.Next(s, en);               
        //            arrayListWord[temp] = r_temp;                 
        //            temp++;
        //        }
        //    }
            
        //    return arrayListWord;
        //}

        private void ThietLapDuLieu_Load(object sender, EventArgs e)
        {
           SetDataSelectList();
           FadeIn();
        }

        private void ThietLapDuLieu_Shown(object sender, EventArgs e)
        {
            FadeIn();
        }

        private void checkAllUnit_OnChange(object sender, EventArgs e)
        {
            if (checkAllUnit.Checked == true)
            {
                lb_hienthisocauhoi.Text = "Question number";
            }
            else
            {
                lb_hienthisocauhoi.Text = "Question number/Unit";
            }
        }
        public int ShowUnitHaveLeastWord()
        {
            Dictionary dic = new Dictionary();
            int result = 1000;// it nhat
            for (int i = 0; i < Select_Unit.Length; i++)
            {
                if (dic.ShowNumberWordOfUnit(Select_Unit[i]) < result)
                {
                    result = Select_Unit[i];
                }
            }
           // MessageBox.Show(result.ToString());
            return result;
        }
        private void SetDataSelectList()
        {
            checkedListBox_Select_units.Items.Clear();
            List<string> arrayList = Mainform.Dic.RefeshAndLoadListUnit();
            for (int i = 0; i < arrayList.Count; i++)
            {

                checkedListBox_Select_units.Items.Add(ClearUnderscoreInString(arrayList[i]));
            }
            checkedListBox_Select_units.Refresh();
        }
        private string ClearUnderscoreInString(string str)
        {
            str = str.Replace('_', ' ');
            return str;
        }

    }
}
