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
    public partial class ChangeText : Form
    {
        public string name_user = string.Empty;
        public ChangeText(string str)
        {
            InitializeComponent();
            tb_change_name.Text = str;
        }

        public event EventHandler PerformForm1Click;// tao event phim ok

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvokeForm1Example()
        {
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);

            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                const int CS_DROPSHADOW = 0x20000;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        } 

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            name_user = tb_change_name.Text;
            User user = new User();
            user.SaveFile(tb_change_name.Text);
            EventHandler handler = this.PerformForm1Click;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);

            }
            this.Close();
        }
    }
}
