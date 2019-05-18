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
    public partial class Home : Form
    {
        Image avatar;
        Image background;
        HamCanThiet f;
        OpenFileDialog openfiledialog=new OpenFileDialog();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 

        public Home()
        {         
            InitializeComponent();
            SetToolTips();
        }

 
        
        private void change_avatar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openfiledialog.OpenFile()) != null)
                    {
                        avatar = Image.FromFile(openfiledialog.FileName);
                        pb_cover_avatar.Image = f.ImageCrop(avatar, 8, Color.White);
                        if (File.Exists(@"user_data\avatar.dat"))
                        {
                            File.Delete(@"user_data\avatar.dat");
                        }                   
                        f.SaveImageData(pb_cover_avatar.Image, "avatar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void change_background_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openfiledialog.OpenFile()) != null)
                    {
                        
                        background = Image.FromFile(openfiledialog.FileName);
                        panel_background.BackgroundImage = f.AddBackgroundFrame(background,8,Color.Gray);
                        if (File.Exists(@"user_data\background.dat"))
                        {
                            File.Delete(@"user_data\background.dat");
                        }                       
                        f.SaveImageData(panel_background.BackgroundImage, "background");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

       
        int dem2 = 0;
        Timer timer = new Timer();
      
        Timer timer2 = new Timer();
        private void pb_cover_avatar_MouseLeave(object sender, EventArgs e)
        {                
            timer.Start();            
        }

        
        void timer_Tick2(object sender, EventArgs e)
        {
            dem2++;
            if (dem2 == 3)
            {
                dem2 = 0;
                change_background.Hide();
                timer2.Stop();
            }
        }
        private void panel_background_MouseHover(object sender, EventArgs e)
        {
            change_background.Show();
        }

        private void panel_background_MouseLeave(object sender, EventArgs e)
        {
           
            timer2.Start();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lb_name_user.Text = Mainform.userApp.getname();
            f = new HamCanThiet();
            Image img = (System.Drawing.Image)(resources.GetObject("pb_cover_avatar.Image"));
            pb_cover_avatar.Image = f.ImageCrop(img, 8, Color.White);
          
            change_background.Hide();
            timer2.Interval = 1000;
            timer.Interval = 1000;
            timer2.Tick += timer_Tick2;
            if (File.Exists(@"user_data\avatar.dat"))
            {
                pb_cover_avatar.Image=f.OpenImageData("avatar");
            }
            if (File.Exists(@"user_data\background.dat"))
            {
                panel_background.BackgroundImage = f.OpenImageData("background");
            }
        }

        ChangeText change ;// thay doi ten

        private void change_name_Click(object sender, EventArgs e)
        {
            change = new ChangeText(lb_name_user.Text);
            change.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            change.ShowDialog();
        }
        private void frm2_PerformForm1Click(object sender, EventArgs e)
        {
            lb_name_user.Text = change.name_user;
        }

        private void lb_name_user_Click(object sender, EventArgs e)
        {
            change = new ChangeText(lb_name_user.Text);
            change.PerformForm1Click += new EventHandler(frm2_PerformForm1Click);
            change.ShowDialog();
        }

        private void SetToolTips()
        {
            toolTip.SetToolTip(this.pb_cover_avatar, "Thay đổi ảnh đại diện");
            toolTip.SetToolTip(this.lb_name_user, "Thay đổi tên");
            toolTip.SetToolTip(this.change_background, "Thay đổi ảnh bìa");
        }
    }
}
