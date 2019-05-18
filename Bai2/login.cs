using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai2
{
    public partial class login : Form
    {
        public bool kiemtra;// kiem tra nhap dung mat khau
        string pass = "";
       // string name = "";
        BinaryWriter bw;
        public login()
        {
            InitializeComponent();
            this.kiemtra = false;
            this.ActiveControl = tb_name_user;
            CreateFolder("user_data");
            
        }
       
        private void CreateFolder(string name)
        {
            try
            {
                string directoryPath = name;
                // Bước 2: kiểm tra nếu thư mục "StoredFiles" chưa tồn tại thì tạo mới
                if (!System.IO.Directory.Exists(directoryPath))
                {
                    System.IO.Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }
        public void createfile(string name)
        {
            try
            {
                string s = "user_data" + "\\" + name;
                bw = new BinaryWriter(new FileStream(s, FileMode.Create));
                //MessageBox.Show("Successful");
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot create file.");
                return;
            }
            bw.Close();
        }
        public void writefile(string s, string name)
        {
            try
            {
                //bw = new BinaryWriter(new FileStream("mydata", FileMode.Append, FileAccess.Write));
                //bw.Write(s);
                //bw.Write(s1);
                //MessageBox.Show("thanh cong");
                name = "user_data" + "\\" + name;
                string appendText = s;//+Environment.NewLine;
                File.AppendAllText(name, appendText, Encoding.UTF8);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

        }
        void login_user(string name_user)
        {
            string t_name_user = "user_data" + "\\" + name_user;
            if (File.Exists(t_name_user) == true)
            {
                string temp = "";
                //MessageBox.Show("Tai khoan ton tai");
                readfile(name_user, ref temp);
                //MessageBox.Show("PassWord:" + temp+"/");
                // MessageBox.Show("PassWord:" + tb_pass.Text + "/");
                if (temp.Equals(pass) == true)
                {
                    this.kiemtra = true;
                    this.Hide();
                    Mainform f = new Mainform();
                    f.Show();
                   // MessageBox.Show("Đăng nhập thành công","THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "THÔNG BÁO");
                }


            }
            else
            {
                MessageBox.Show("Tài khoản chưa tồn tài\nVui lòng nhấn Create để tạo tài khoản", "THÔNG BÁO");
            }
        }
        public void readfile(string name_user, ref string out_data)
        {


            //string str="";
            // string s="";
            try
            {
                //br = new BinaryReader(new FileStream("mydata", FileMode.Open,FileAccess.Read));
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + "\n Cannot open file.");

            }
            try
            {
                // = "";
                //int count = br.ReadInt32();
                //// Read in all pairs.
                //for (  int i= 0; i < count; i++)
                //{
                //    str = br.ReadString();

                //} 
                name_user = "user_data" + "\\" + name_user;
                string fileBytes = File.ReadAllText(name_user);
                out_data = fileBytes;
                // StringBuilder sb = new StringBuilder();

                // foreach (string b in fileBytes)
                // {
                //  sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                // }

                //MessageBox.Show("PassWord:" + fileBytes);


                //s = br.ReadString();
                //str = br.ReadString();
                //MessageBox.Show("data " + str+s);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
            }
            // br.Close();

        }
        private void tb_name_user_OnTextChange(object sender, EventArgs e)
        {

        }

        private void tb_password_user_OnTextChange(object sender, EventArgs e)
        {
            
        }
       
        private void tb_password_user_KeyPress(object sender, EventArgs e)
        {
            
            KeyPressEventArgs k = e as KeyPressEventArgs;
            if (k != null)
            {
                if (k.KeyChar == 13)
                {
                    //MessageBox.Show("name:"+tb_name_user.text+"\npass:"+pass);
                    bt_sign_in_Click(sender, e);
                    pass = "";
                }
                else if (k.KeyChar == 8)
                {
                    if (pass.Length >0)
                    {
                        pass = pass.Remove(pass.Length - 1);
                    }
                }
                else
                {
                    pass = pass + k.KeyChar.ToString();
                    k.KeyChar = '•';
                }
               
            }
           
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_name_user_Leave(object sender, EventArgs e)
        {
            
        }

        private void bt_sign_in_Click(object sender, EventArgs e)//sign in
        {
            //MessageBox.Show("name:" + tb_name_user.text + "\npass:" + pass);
            login_user(tb_name_user.text);
        }

        private void minimize_user_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        CreateAccount c;
        private void create_account_Click(object sender, EventArgs e)// dao tai khoan
        {
            if (c == null)
            {
                c = new CreateAccount();
            }          
            c.TopLevel = false;
            bunifuGradientPanel1.Controls.Add(c);
            c.Show();
            c.Dock = DockStyle.Fill;     
            c.BringToFront();

            //if (File.Exists("user_data" + "\\" + tb_name_user.text) == true)
            //{
            //    MessageBox.Show("Tên tài khoản đã tồn tại\nKhông thể tạo", "THÔNG BÁO");
            //}
            //else
            //{
            //    createfile(tb_name_user.text);
            //    writefile(pass,tb_name_user.text);
            //    MessageBox.Show("Tạo tài khoản thành công","THÔNG BÁO");
            //}
        }

        private void show_pass_OnChange(object sender, EventArgs e)
        {

        }
    }
}
