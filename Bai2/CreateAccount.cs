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
    public partial class CreateAccount : Form
    {
        Bai2.UserFile usefile= new Bai2.UserFile();
        private void ResetTextBox()
        {
            tb_name.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";
        }
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            this.Hide();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            if (File.Exists("user_data" + "\\" + tb_username.Text) == true)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại\nKhông thể tạo", "THÔNG BÁO");
            }
            else
            {
                usefile.createfile(tb_username.Text);
                usefile.writefile(tb_password.Text, tb_username.Text);
                MessageBox.Show("Tạo tài khoản thành công", "THÔNG BÁO");
            }
            this.Hide();
        }
    }
}
