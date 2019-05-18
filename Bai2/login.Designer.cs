namespace Bai2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.show_pass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.create_account = new Bunifu.Framework.UI.BunifuThinButton2();
            this.minimize_user = new System.Windows.Forms.PictureBox();
            this.tb_name_user = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_sign_in = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.tb_password_user = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.show_pass);
            this.bunifuGradientPanel1.Controls.Add(this.create_account);
            this.bunifuGradientPanel1.Controls.Add(this.minimize_user);
            this.bunifuGradientPanel1.Controls.Add(this.tb_name_user);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bt_sign_in);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.pb_close);
            this.bunifuGradientPanel1.Controls.Add(this.tb_password_user);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(400, 600);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // show_pass
            // 
            this.show_pass.BackColor = System.Drawing.Color.Transparent;
            this.show_pass.ChechedOffColor = System.Drawing.Color.Transparent;
            this.show_pass.Checked = true;
            this.show_pass.CheckedOnColor = System.Drawing.Color.Transparent;
            this.show_pass.ForeColor = System.Drawing.Color.White;
            this.show_pass.Location = new System.Drawing.Point(331, 185);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(20, 20);
            this.show_pass.TabIndex = 10;
            this.show_pass.OnChange += new System.EventHandler(this.show_pass_OnChange);
            // 
            // create_account
            // 
            this.create_account.ActiveBorderThickness = 2;
            this.create_account.ActiveCornerRadius = 10;
            this.create_account.ActiveFillColor = System.Drawing.Color.Transparent;
            this.create_account.ActiveForecolor = System.Drawing.Color.Transparent;
            this.create_account.ActiveLineColor = System.Drawing.Color.White;
            this.create_account.BackColor = System.Drawing.Color.Transparent;
            this.create_account.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("create_account.BackgroundImage")));
            this.create_account.ButtonText = "Create";
            this.create_account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account.ForeColor = System.Drawing.Color.Transparent;
            this.create_account.IdleBorderThickness = 2;
            this.create_account.IdleCornerRadius = 10;
            this.create_account.IdleFillColor = System.Drawing.Color.Transparent;
            this.create_account.IdleForecolor = System.Drawing.Color.White;
            this.create_account.IdleLineColor = System.Drawing.Color.White;
            this.create_account.Location = new System.Drawing.Point(87, 281);
            this.create_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(238, 43);
            this.create_account.TabIndex = 9;
            this.create_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            // 
            // minimize_user
            // 
            this.minimize_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.minimize_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_user.Image = ((System.Drawing.Image)(resources.GetObject("minimize_user.Image")));
            this.minimize_user.Location = new System.Drawing.Point(321, 3);
            this.minimize_user.Name = "minimize_user";
            this.minimize_user.Size = new System.Drawing.Size(35, 35);
            this.minimize_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_user.TabIndex = 8;
            this.minimize_user.TabStop = false;
            this.minimize_user.Click += new System.EventHandler(this.minimize_user_Click);
            // 
            // tb_name_user
            // 
            this.tb_name_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(205)))), ((int)(((byte)(249)))));
            this.tb_name_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_name_user.BackgroundImage")));
            this.tb_name_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_name_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_name_user.ForeColor = System.Drawing.Color.White;
            this.tb_name_user.Icon = ((System.Drawing.Image)(resources.GetObject("tb_name_user.Icon")));
            this.tb_name_user.Location = new System.Drawing.Point(87, 118);
            this.tb_name_user.Name = "tb_name_user";
            this.tb_name_user.Size = new System.Drawing.Size(238, 48);
            this.tb_name_user.TabIndex = 7;
            this.tb_name_user.text = "";
            this.tb_name_user.Leave += new System.EventHandler(this.tb_name_user_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bt_sign_in
            // 
            this.bt_sign_in.ActiveBorderThickness = 2;
            this.bt_sign_in.ActiveCornerRadius = 10;
            this.bt_sign_in.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bt_sign_in.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bt_sign_in.ActiveLineColor = System.Drawing.Color.White;
            this.bt_sign_in.BackColor = System.Drawing.Color.Transparent;
            this.bt_sign_in.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sign_in.BackgroundImage")));
            this.bt_sign_in.ButtonText = "Sign in";
            this.bt_sign_in.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sign_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sign_in.ForeColor = System.Drawing.Color.Transparent;
            this.bt_sign_in.IdleBorderThickness = 2;
            this.bt_sign_in.IdleCornerRadius = 10;
            this.bt_sign_in.IdleFillColor = System.Drawing.Color.Transparent;
            this.bt_sign_in.IdleForecolor = System.Drawing.Color.White;
            this.bt_sign_in.IdleLineColor = System.Drawing.Color.White;
            this.bt_sign_in.Location = new System.Drawing.Point(87, 228);
            this.bt_sign_in.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_sign_in.Name = "bt_sign_in";
            this.bt_sign_in.Size = new System.Drawing.Size(238, 43);
            this.bt_sign_in.TabIndex = 5;
            this.bt_sign_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_sign_in.Click += new System.EventHandler(this.bt_sign_in_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "Sign in with Google";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(87, 519);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(238, 46);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Sign in with Google";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Sign in with Facebook";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(87, 467);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(238, 46);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Sign in with Facebook";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(362, 3);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(35, 35);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 2;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // tb_password_user
            // 
            this.tb_password_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(246)))));
            this.tb_password_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_password_user.BackgroundImage")));
            this.tb_password_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_password_user.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_password_user.ForeColor = System.Drawing.Color.White;
            this.tb_password_user.Icon = ((System.Drawing.Image)(resources.GetObject("tb_password_user.Icon")));
            this.tb_password_user.Location = new System.Drawing.Point(87, 172);
            this.tb_password_user.Name = "tb_password_user";
            this.tb_password_user.Size = new System.Drawing.Size(238, 48);
            this.tb_password_user.TabIndex = 1;
            this.tb_password_user.text = "";
            this.tb_password_user.KeyPress += new System.EventHandler(this.tb_password_user_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTextbox tb_password_user;
        private System.Windows.Forms.PictureBox pb_close;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_sign_in;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox tb_name_user;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox minimize_user;
        private Bunifu.Framework.UI.BunifuThinButton2 create_account;
        private Bunifu.Framework.UI.BunifuCheckbox show_pass;
    }
}