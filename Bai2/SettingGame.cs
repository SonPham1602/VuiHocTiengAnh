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
    public partial class SettingGame : Form
    {
       
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
        /// <summary>
        /// ham get question
        /// </summary>
        /// <returns>cau hoi duoc chon</returns>
        public int GetQuestion()
        {
            Dictionary Dic = new Dictionary();
            Random r = new Random();
            int pos = r.Next(0, Select_Unit.Length);
            int s = new int();
            int en = new int();
            Dic.getStartEndUnit(ref s, ref en, Select_Unit[pos]);
            int result=r.Next(s, en);
            return result;
        }
        public int GetQuestionAllUnit()
        {
            Dictionary Dic = new Dictionary();
            Random r = new Random();
            int result = r.Next(0, Dic.getNumberList());
            return result;
        }
        int Start_Unit;
        int End_Unit;
        public int timeGame;
        public int numberAnswers;
        public int[] Select_Unit;
        public bool CheckAllUnit;
        public bool SoundInGame;
        private bool Check()
        {
            if (txtTime.Text == "")
            {
                MessageBoxCustoms mess =new MessageBoxCustoms("Thời gian không có giá trị", TypeMessageEnum.THONGBAO);
                return false;
            }
            else if (textbox_start_unit.Text != "" && textbox_end_unit.Text == "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để trống End Unit", TypeMessageEnum.THONGBAO);
                return false;
            }
            else if (textbox_start_unit.Text == "" && textbox_end_unit.Text != "")
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Không được để trống Start Unit", TypeMessageEnum.THONGBAO);
                return false;
            }
            else if (textbox_start_unit.Text != "" && textbox_end_unit.Text != "")
            {
                if (Int32.Parse(textbox_start_unit.Text) == 0)
                {
                    MessageBoxCustoms mess = new MessageBoxCustoms("Không được nhập Start Unit bằng 0", TypeMessageEnum.THONGBAO);
                    return false;
                }
                if (Int32.Parse(textbox_end_unit.Text) <= Int32.Parse(textbox_start_unit.Text))
                {
                    MessageBoxCustoms mess = new MessageBoxCustoms("Start phải nhỏ hơn End", TypeMessageEnum.THONGBAO);
                    return false;
                }

            }
          
            if (textbox_end_unit.Text != "" && textbox_start_unit.Text != "")
            {
                Start_Unit = Int32.Parse(textbox_start_unit.Text);
                End_Unit = Int32.Parse(textbox_end_unit.Text);
                int dem = 0;
                Select_Unit = new int[End_Unit - Start_Unit + 1];
                for (int i = Start_Unit; i <= End_Unit; i++)
                {
                    Select_Unit[dem] = i;
                    dem++;
                }
            }

       
            timeGame = Int32.Parse(txtTime.Text);
            if (timeGame == 0)
            {
                MessageBoxCustoms mess = new MessageBoxCustoms("Thời gian không được cài đặt là 0", TypeMessageEnum.THONGBAO);
                return false;
            }
            // chon so cau hoi 4 or 8 
             if(numberAnswer.selectedIndex==0)
            {
                numberAnswers = 4;
            }
             else
            {
                numberAnswers = 8;
            }
             // chon all unit
             if(btnCheckAll.Checked==true)
            {
                CheckAllUnit = true;
            }
             else
            {
                CheckAllUnit = false;
                int temp = 0;
                foreach (string str in checkedListBox_Select_units.CheckedItems)
                {
                    temp++;
                }
                if (temp == 0 && textbox_end_unit.Text == "" && btnCheckAll.Checked == false)
                {
                    MessageBoxCustoms mess = new MessageBoxCustoms("Phải chọn ít nhất một Uni", TypeMessageEnum.THONGBAO);
                    return false;
                }
                else
                {
                    Select_Unit = new int[temp];
                    int dem = 0;
                    foreach (string str in checkedListBox_Select_units.CheckedItems)
                    {
                        if (str[6] == ' ')
                        {
                            Select_Unit[dem] = str[5] - 48;
                        }
                        else
                        {
                            int n = (str[5] - 48) * 10 + str[6] - 48;
                            Select_Unit[dem] = n;
                        }
                        dem++;
                    }
                }
            }
            return true;
        }
        public SettingGame()
        {
            InitializeComponent();
        }

        private void SettingGame_Load(object sender, EventArgs e)
        {
            SetDataSelectList();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (Check() == true)
                this.Hide();
            label1.Focus();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            label1.Focus();
            this.Hide();
        }

        private void cb_sound_game_OnChange(object sender, EventArgs e)
        {
            if (cb_sound_game.Checked == true)
            {
                SoundInGame = true;
            }
            else
            {
                SoundInGame = false;
            }
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
