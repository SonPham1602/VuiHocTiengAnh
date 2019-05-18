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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            
        }
        public void CloseLoading()
        {
            System.Threading.Thread.Sleep(2000);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
