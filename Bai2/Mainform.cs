using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows;
namespace Bai2
{
    public partial class Mainform : Form
    {
        public void FadeClose(object sender, EventArgs e)// tao hieu ung tat cho form chinh
        {
            int loopctr = 0;
            for (loopctr = 100; loopctr >= 5; loopctr -= 5)
            {
                this.Opacity = loopctr / 95.0;
                //this.Refresh();// khong can cai nay cung dc,Luu y: tim hieu re this.refresh 
                System.Threading.Thread.Sleep(10);
            }
            this.Close();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]// can using  System.Runtime.InteropServices
        private static extern IntPtr CreateRoundRectRgn// ham tao corner radius 
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

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

        void HideApplication()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        public void ShowApplication()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        void SetSizeButton(Size s)// thay doi kich thuoc cua cac button
        {
            bt_home.Size = s;
            bt_learn.Size = s;
            bt_setting.Size = s;
            bt_search.Size = s;
            bt_test.Size = s;
            bt_data.Size = s;
            bt_help.Size = s;
        }

        private void SetPropertiesApplication()
        {
            string[] temp;
            if (File.Exists(@"user_data\setting.dat"))
            {
                temp = f.LoadPropertiesUser();
                this.ChangeColorBar(Color.FromArgb(Int32.Parse(temp[1]), Int32.Parse(temp[2]), Int32.Parse(temp[3])));
            }
            else
            {
                temp = new string[4];
                temp[0] = "1228 x 842";
            }
            if (temp[0] == "1000 x 800")
            {
                this.Size = new System.Drawing.Size(1000, 800);
            }
            else if (temp[0] == "1280 x 720")
            {
                this.Size = new System.Drawing.Size(1280, 720);
            }
            else if (temp[0] == "1228 x 842")
            {
                this.Size = new System.Drawing.Size(1228, 842);
            }
            else if (temp[0] == "1600 x 900")
            {
                this.Size = new System.Drawing.Size(1600, 900);
            }
            CurrentSizeForm = this.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }
        private Bai2.Dictionary Dic = new Bai2.Dictionary();
        
        // thuoc tinh chuong trinh
        Size CurrentSizeForm= new Size();
        Home home=new Home();
        Learn learn= new Learn();
        Test test =new Test();
        Setting setting=new Setting();
        Search search=new Search();
        Data data=new Data();
        SelectGame game=new SelectGame();
        public static User userApp;
        HamCanThiet f;
        About about = new About();
        Help help = new Help();
        public static UIUserSetting uiuser=new UIUserSetting();
       
        //ket thuc khai bao thuoc tinh
        private void SetDefault()
        {
            this.pn_bar.GradientBottomLeft = Color.FromArgb(133, 203, 248);
            this.pn_bar.GradientBottomRight = Color.FromArgb(0, 192, 192);           
        }
      
       // login login_user = new login();
          Loading loading = new Loading();
        public Mainform()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer_FadeIn.Start();// tao hieu ung fade in 
            ProfileUser.ReadData();
            ProfileUser.SoLanMoChuongTrinh++;
          
           //this.StartPosition = FormStartPosition.CenterScreen;
            //"name of control".Cursor = new System.Windows.Forms.Cursor(Properties.Resources."name of image".Handle);
           //this.Cursor  =new System.Windows.Forms.Cursor()
            //HideApplication();
            //login_user.Show();
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //loading.ShowDialog();
            //loading.CloseLoading();
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); // sw cotructor
            //sw.Start(); // starts the stopwatch
            //for (int i = 0; ; i++)
            //{
            //    if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
            //    // depending on how often you want the time to be checked) 
            //    {
            //        sw.Stop(); // stop the time measurement
            //        if (sw.ElapsedMilliseconds > 5000) // check if desired period of time has elapsed
            //        {
            //            break; // if more than 5000 milliseconds have passed, stop looping and return
            //            // to the existing code
            //        }
            //        else
            //        {
            //            sw.Start(); // if less than 5000 milliseconds have elapsed, continue looping
            //            // and resume time measurement
            //        }
            //    }
            //}
            SetToolTips();
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            userApp = new User();
            userApp.LoadFile();
            f = new HamCanThiet();
            SetPropertiesApplication();
            hienthitencuaso.Text = "Home";                
           // ShowSelectIconButton(sender);
            home.TopLevel = false;
            pn_show.Controls.Add(home);
         
            home.Dock = DockStyle.Fill;
            home.Show();
            home.BringToFront();
            
          
           // this.Show();
            //this.ChangeColorBar(Color.FromArgb());
            //bt_home_Click(sender, e);
           
            
            
        }
       
      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // cac ham xu ly phim title bar
        private void pb_close_Click(object sender, EventArgs e)
        {
            FadeClose(sender, e);
        }
       

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
       
        private void pb_maximize_Click(object sender, EventArgs e)
        {
            int nTaskBarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;
            int w=Screen.PrimaryScreen.Bounds.Width;
            int h=Screen.PrimaryScreen.Bounds.Height-nTaskBarHeight;
            if (this.Size == new System.Drawing.Size(w, h))
            {
                this.bunifuElipse1.ElipseRadius = 15;
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (CurrentSizeForm.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (CurrentSizeForm.Height / 2)); // ham di chuyen form ve vi tri chinh giua man hinh
                this.Size = CurrentSizeForm;
                setting.SetData(this.Size, this.pn_bar.GradientBottomLeft);
                
            }
            else
            {
                this.bunifuElipse1.ElipseRadius = 0;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(w,h);
                setting.SetData(this.Size, this.pn_bar.GradientBottomLeft);           
            }
        }
       
        private void ShowSelectIconButton(object sender)// ham hien thi button nao dang duoc chon
        {
            pb_select_icon.Top = ((Control)sender).Top;
            pb_select_icon.Height = ((Control)sender).Height;  
        }

         // ham xu ly cac phim chuc nang trong chuong trinh   
        private void HideAllFormControl()
        {
            pn_show.Hide();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Home")
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Home";
                ShowSelectIconButton(sender);
                home.TopLevel = false;
                home.Dock = DockStyle.Fill;
                home.Show();
                home.BringToFront();
                pn_show.Show();
            }
        }
       
        private void bt_learn_Click(object sender, EventArgs e)
        {
           
            if(hienthitencuaso.Text != "Learn")// thêm if  dể cho ko bị lag phần hiển thị
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Learn";

                //pn_show.Scale(new SizeF(0.9f, 0.9f)); ham lam thu nho ti le form
                ShowSelectIconButton(sender);
                learn.TopLevel = false;
                pn_show.Controls.Add(learn);
                learn.Dock = DockStyle.Fill;
                learn.Show();
                learn.BringToFront();
                pn_show.Show();
            
            }
            
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Test")
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Test";
                ShowSelectIconButton(sender);
                test.TopLevel = false;
                pn_show.Controls.Add(test);
                test.Dock = DockStyle.Fill;
                test.Show();
                test.BringToFront();
                pn_show.Show();
            }         
        }
        
        private void bt_setting_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Setting")
            {
                HideAllFormControl();
                setting.SetData(this.Size,this.pn_bar.GradientBottomLeft);
                setting.change += setting_change;
                hienthitencuaso.Text = "Setting";
                ShowSelectIconButton(sender);
                setting.TopLevel = false;
                pn_show.Controls.Add(setting);
                setting.Dock = DockStyle.Fill;
                setting.Show();
                setting.BringToFront();
                pn_show.Show();
            }   
        }

        private void ChangeColorBar(Color c)
        {
            pn_bar.GradientBottomLeft = c;
        }

        private void setting_change(object sender, ChangeUI e)
        {
            if (e.size.Width == 1000)
            {
                this.learn.SetSizeLable(11);
                this.learn.SetSizeControl(150);
            }
            else
            {
               
                this.learn.SetDefault();
            }
            this.ChangeColorBar(e.color);
            this.Size = e.size;
            if (e.size.Width == Screen.PrimaryScreen.Bounds.Size.Width)
            {
                this.bunifuElipse1.ElipseRadius = 0;
                this.Location = new Point(0, 0);
            }
            else
            {
                this.bunifuElipse1.ElipseRadius = 15;
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)); // ham di chuyen form ve vi tri chinh giua man hinh
            }
            //this.Location=new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)); // ham di chuyen form ve vi tri chinh giua man hinh

        }
        
        private void bt_search_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Search")
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Search";
                ShowSelectIconButton(sender);
                search.TopLevel = false;
                pn_show.Controls.Add(search);
                search.Dock = DockStyle.Fill;
                search.Show();
                search.BringToFront();
                pn_show.Show();
            }
        }
       
        private void bt_data_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Data")
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Data";
                ShowSelectIconButton(sender);
                data.TopLevel = false;
                pn_show.Controls.Add(data);
                data.Dock = DockStyle.Fill;
                data.Show();
                data.BringToFront();
                pn_show.Show();
            }
        }

        private void bt_help_Click(object sender, EventArgs e)
        {
            hienthitencuaso.Text = "Help";
            ShowSelectIconButton(sender);
            help.TopLevel = false;
            pn_show.Controls.Add(help);
            help.Dock = DockStyle.Fill;
            help.Show();
            help.BringToFront();
            pn_show.Show();
        }

        private void bt_game_Click(object sender, EventArgs e)
        {
            if (hienthitencuaso.Text != "Game")
            {
                HideAllFormControl();
                hienthitencuaso.Text = "Game";
                ShowSelectIconButton(sender);
                game.TopLevel = false;
                pn_show.Controls.Add(game);
                game.Dock = DockStyle.Fill;
                game.Show();
                game.BringToFront();
                pn_show.Show();
            }
        }
     
        private void pb_info_Click(object sender, EventArgs e)
        {
            about.SetColor(this.pn_bar.GradientBottomLeft);
            about.ShowDialog();
        }

        private void pb_notifications_Click(object sender, EventArgs e)
        {

        }

        private void timer_FadeIn_Tick(object sender, EventArgs e)
        {
            
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer_FadeIn.Stop();
            }
        }
        /// <summary>
        /// add tooltips for buttons 
        /// </summary>
        private void SetToolTips()
        {
            toolTip.SetToolTip(this.bt_home, "Thẻ Home");
            toolTip.SetToolTip(this.bt_learn, "Thẻ Học Tập");
            toolTip.SetToolTip(this.bt_setting, "Thẻ Cài Đặt Chương Trình");
            toolTip.SetToolTip(this.bt_game, "Thẻ Trò Chơi Tiếng Anh");
            toolTip.SetToolTip(this.bt_test, "Thẻ Kiểm Tra Trên Lớp");
            toolTip.SetToolTip(this.bt_search, "Thẻ Tìm Kiếm Từ");
            toolTip.SetToolTip(this.bt_help, "Thẻ Giúp Đỡ");
            toolTip.SetToolTip(this.pb_close, "Thoát Chương Trình");
            toolTip.SetToolTip(this.pb_minimize, "Thu Nhỏ Chương Trình");
            toolTip.SetToolTip(this.pb_maximize, "Mở Rộng Chương Trình");
            toolTip.SetToolTip(this.pb_info, "Thông Tin Phiên Bản Phần Mềm");
            toolTip.SetToolTip(this.bt_data, "Thẻ Dữ Liệu Chương Trình");
            

        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProfileUser.SaveData();
        }
    }
    
}
