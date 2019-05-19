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
    public partial class ShowImageTestResult : Form
    {
        Dictionary dic = new Dictionary();
        public ShowImageTestResult()
        {
            InitializeComponent();
        }
        public ShowImageTestResult(string ImagePicture)
        {
           
            InitializeComponent();
            pictureBox.Image = dic.getImageWordByWord(ImagePicture);
        }
    }
}
