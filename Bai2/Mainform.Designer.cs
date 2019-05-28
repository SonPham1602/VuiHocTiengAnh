namespace Bai2
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_maximize = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bt_game = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_help = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_data = new Bunifu.Framework.UI.BunifuImageButton();
            this.pb_select_icon = new System.Windows.Forms.PictureBox();
            this.bt_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_learn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_test = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_setting = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_home = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pn_title_bar = new System.Windows.Forms.Panel();
            this.pb_notifications = new System.Windows.Forms.PictureBox();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.hienthitencuaso = new System.Windows.Forms.Label();
            this.pn_show = new System.Windows.Forms.Panel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_bar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_FadeIn = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_select_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_learn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_home)).BeginInit();
            this.pn_title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            this.pn_show.SuspendLayout();
            this.pn_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1108, 3);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(35, 35);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 14;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // pb_maximize
            // 
            this.pb_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_maximize.Image = ((System.Drawing.Image)(resources.GetObject("pb_maximize.Image")));
            this.pb_maximize.Location = new System.Drawing.Point(1067, 3);
            this.pb_maximize.Name = "pb_maximize";
            this.pb_maximize.Size = new System.Drawing.Size(35, 35);
            this.pb_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_maximize.TabIndex = 15;
            this.pb_maximize.TabStop = false;
            this.pb_maximize.Click += new System.EventHandler(this.pb_maximize_Click);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1026, 3);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(35, 35);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 16;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bt_game
            // 
            this.bt_game.BackColor = System.Drawing.Color.Transparent;
            this.bt_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_game.Image = ((System.Drawing.Image)(resources.GetObject("bt_game.Image")));
            this.bt_game.ImageActive = null;
            this.bt_game.Location = new System.Drawing.Point(12, 552);
            this.bt_game.Name = "bt_game";
            this.bt_game.Size = new System.Drawing.Size(60, 60);
            this.bt_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_game.TabIndex = 9;
            this.bt_game.TabStop = false;
            this.bt_game.Zoom = 0;
            this.bt_game.Click += new System.EventHandler(this.bt_game_Click);
            // 
            // bt_help
            // 
            this.bt_help.BackColor = System.Drawing.Color.Transparent;
            this.bt_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_help.Image = ((System.Drawing.Image)(resources.GetObject("bt_help.Image")));
            this.bt_help.ImageActive = null;
            this.bt_help.Location = new System.Drawing.Point(12, 636);
            this.bt_help.Name = "bt_help";
            this.bt_help.Size = new System.Drawing.Size(60, 60);
            this.bt_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_help.TabIndex = 8;
            this.bt_help.TabStop = false;
            this.bt_help.Zoom = 0;
            this.bt_help.Click += new System.EventHandler(this.bt_help_Click);
            // 
            // bt_data
            // 
            this.bt_data.BackColor = System.Drawing.Color.Transparent;
            this.bt_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_data.Image = ((System.Drawing.Image)(resources.GetObject("bt_data.Image")));
            this.bt_data.ImageActive = null;
            this.bt_data.Location = new System.Drawing.Point(12, 468);
            this.bt_data.Name = "bt_data";
            this.bt_data.Size = new System.Drawing.Size(60, 60);
            this.bt_data.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_data.TabIndex = 7;
            this.bt_data.TabStop = false;
            this.bt_data.Zoom = 0;
            this.bt_data.Click += new System.EventHandler(this.bt_data_Click);
            // 
            // pb_select_icon
            // 
            this.pb_select_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
            this.pb_select_icon.Location = new System.Drawing.Point(72, 48);
            this.pb_select_icon.Name = "pb_select_icon";
            this.pb_select_icon.Size = new System.Drawing.Size(10, 60);
            this.pb_select_icon.TabIndex = 6;
            this.pb_select_icon.TabStop = false;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.Transparent;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageActive = null;
            this.bt_search.Location = new System.Drawing.Point(12, 384);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(60, 60);
            this.bt_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_search.TabIndex = 5;
            this.bt_search.TabStop = false;
            this.bt_search.Zoom = 0;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_learn
            // 
            this.bt_learn.BackColor = System.Drawing.Color.Transparent;
            this.bt_learn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_learn.Image = ((System.Drawing.Image)(resources.GetObject("bt_learn.Image")));
            this.bt_learn.ImageActive = null;
            this.bt_learn.Location = new System.Drawing.Point(12, 132);
            this.bt_learn.Name = "bt_learn";
            this.bt_learn.Size = new System.Drawing.Size(60, 60);
            this.bt_learn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_learn.TabIndex = 4;
            this.bt_learn.TabStop = false;
            this.bt_learn.Zoom = 0;
            this.bt_learn.Click += new System.EventHandler(this.bt_learn_Click);
            // 
            // bt_test
            // 
            this.bt_test.BackColor = System.Drawing.Color.Transparent;
            this.bt_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_test.Image = ((System.Drawing.Image)(resources.GetObject("bt_test.Image")));
            this.bt_test.ImageActive = null;
            this.bt_test.Location = new System.Drawing.Point(12, 216);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(60, 60);
            this.bt_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_test.TabIndex = 3;
            this.bt_test.TabStop = false;
            this.bt_test.Zoom = 0;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_setting
            // 
            this.bt_setting.BackColor = System.Drawing.Color.Transparent;
            this.bt_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_setting.Image = ((System.Drawing.Image)(resources.GetObject("bt_setting.Image")));
            this.bt_setting.ImageActive = null;
            this.bt_setting.Location = new System.Drawing.Point(12, 300);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(60, 60);
            this.bt_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_setting.TabIndex = 2;
            this.bt_setting.TabStop = false;
            this.bt_setting.Zoom = 0;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.Transparent;
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.ImageActive = null;
            this.bt_home.Location = new System.Drawing.Point(12, 48);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(60, 60);
            this.bt_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_home.TabIndex = 1;
            this.bt_home.TabStop = false;
            this.bt_home.Tag = "";
            this.bt_home.Zoom = 0;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_title_bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pn_title_bar
            // 
            this.pn_title_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pn_title_bar.Controls.Add(this.pb_notifications);
            this.pn_title_bar.Controls.Add(this.pb_info);
            this.pn_title_bar.Controls.Add(this.hienthitencuaso);
            this.pn_title_bar.Controls.Add(this.pb_minimize);
            this.pn_title_bar.Controls.Add(this.pb_maximize);
            this.pn_title_bar.Controls.Add(this.pb_close);
            this.pn_title_bar.Location = new System.Drawing.Point(82, 0);
            this.pn_title_bar.Name = "pn_title_bar";
            this.pn_title_bar.Size = new System.Drawing.Size(1146, 48);
            this.pn_title_bar.TabIndex = 18;
            this.pn_title_bar.DoubleClick += new System.EventHandler(this.pb_maximize_Click);
            // 
            // pb_notifications
            // 
            this.pb_notifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_notifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_notifications.Image = ((System.Drawing.Image)(resources.GetObject("pb_notifications.Image")));
            this.pb_notifications.Location = new System.Drawing.Point(944, 3);
            this.pb_notifications.Name = "pb_notifications";
            this.pb_notifications.Size = new System.Drawing.Size(35, 35);
            this.pb_notifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_notifications.TabIndex = 19;
            this.pb_notifications.TabStop = false;
            this.pb_notifications.Click += new System.EventHandler(this.pb_notifications_Click);
            // 
            // pb_info
            // 
            this.pb_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_info.Image = ((System.Drawing.Image)(resources.GetObject("pb_info.Image")));
            this.pb_info.Location = new System.Drawing.Point(985, 3);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(35, 35);
            this.pb_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_info.TabIndex = 18;
            this.pb_info.TabStop = false;
            this.pb_info.Click += new System.EventHandler(this.pb_info_Click);
            // 
            // hienthitencuaso
            // 
            this.hienthitencuaso.AutoSize = true;
            this.hienthitencuaso.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthitencuaso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hienthitencuaso.Location = new System.Drawing.Point(6, 16);
            this.hienthitencuaso.Name = "hienthitencuaso";
            this.hienthitencuaso.Size = new System.Drawing.Size(56, 21);
            this.hienthitencuaso.TabIndex = 17;
            this.hienthitencuaso.Text = "Home";
            // 
            // pn_show
            // 
            this.pn_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_show.Controls.Add(this.doubleBitmapControl1);
            this.pn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pn_show.Location = new System.Drawing.Point(82, 48);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(1146, 794);
            this.pn_show.TabIndex = 16;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(214, 348);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // pn_bar
            // 
            this.pn_bar.BackColor = System.Drawing.Color.Transparent;
            this.pn_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_bar.BackgroundImage")));
            this.pn_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_bar.Controls.Add(this.bt_setting);
            this.pn_bar.Controls.Add(this.bt_search);
            this.pn_bar.Controls.Add(this.bt_data);
            this.pn_bar.Controls.Add(this.bt_game);
            this.pn_bar.Controls.Add(this.pb_select_icon);
            this.pn_bar.Controls.Add(this.bt_help);
            this.pn_bar.Controls.Add(this.bt_home);
            this.pn_bar.Controls.Add(this.bt_learn);
            this.pn_bar.Controls.Add(this.bt_test);
            this.pn_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_bar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(203)))), ((int)(((byte)(248)))));
            this.pn_bar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pn_bar.GradientTopLeft = System.Drawing.Color.Transparent;
            this.pn_bar.GradientTopRight = System.Drawing.Color.Transparent;
            this.pn_bar.Location = new System.Drawing.Point(0, 0);
            this.pn_bar.Name = "pn_bar";
            this.pn_bar.Quality = 10;
            this.pn_bar.Size = new System.Drawing.Size(82, 842);
            this.pn_bar.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Vui học tiếng anh";
            this.notifyIcon.Visible = true;
            // 
            // timer_FadeIn
            // 
            this.timer_FadeIn.Interval = 10;
            this.timer_FadeIn.Tick += new System.EventHandler(this.timer_FadeIn_Tick);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1228, 842);
            this.Controls.Add(this.pn_bar);
            this.Controls.Add(this.pn_show);
            this.Controls.Add(this.pn_title_bar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Vui Hoc Tieng Anh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_select_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_learn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_home)).EndInit();
            this.pn_title_bar.ResumeLayout(false);
            this.pn_title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            this.pn_show.ResumeLayout(false);
            this.pn_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public int[] arrayListWord;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_maximize;
        private System.Windows.Forms.PictureBox pb_minimize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bt_test;
        private Bunifu.Framework.UI.BunifuImageButton bt_setting;
        private Bunifu.Framework.UI.BunifuImageButton bt_home;
        private Bunifu.Framework.UI.BunifuImageButton bt_search;
        private Bunifu.Framework.UI.BunifuImageButton bt_learn;
        private System.Windows.Forms.PictureBox pb_select_icon;
        private System.Windows.Forms.Panel pn_title_bar;
        private System.Windows.Forms.Panel pn_show;
        private System.Windows.Forms.Label hienthitencuaso;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuImageButton bt_data;
        private System.Windows.Forms.PictureBox pb_info;
        private Bunifu.Framework.UI.BunifuImageButton bt_help;
        private Bunifu.Framework.UI.BunifuImageButton bt_game;
        private Bunifu.Framework.UI.BunifuGradientPanel pn_bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_notifications;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer_FadeIn;
        private System.Windows.Forms.ToolTip toolTip;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        
    }
}

