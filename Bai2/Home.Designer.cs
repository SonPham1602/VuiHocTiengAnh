namespace Bai2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pb_cover_avatar = new System.Windows.Forms.PictureBox();
            this.panel_background = new System.Windows.Forms.Panel();
            this.change_background = new System.Windows.Forms.PictureBox();
            this.lb_name_user = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover_avatar)).BeginInit();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_cover_avatar
            // 
            this.pb_cover_avatar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_cover_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_cover_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cover_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_cover_avatar.Image")));
            this.pb_cover_avatar.Location = new System.Drawing.Point(327, 181);
            this.pb_cover_avatar.Name = "pb_cover_avatar";
            this.pb_cover_avatar.Size = new System.Drawing.Size(200, 200);
            this.pb_cover_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cover_avatar.TabIndex = 1;
            this.pb_cover_avatar.TabStop = false;
            this.pb_cover_avatar.Click += new System.EventHandler(this.change_avatar_Click);
            // 
            // panel_background
            // 
            this.panel_background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_background.BackColor = System.Drawing.Color.Black;
            this.panel_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_background.BackgroundImage")));
            this.panel_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_background.Controls.Add(this.change_background);
            this.panel_background.Controls.Add(this.lb_name_user);
            this.panel_background.Controls.Add(this.pb_cover_avatar);
            this.panel_background.Location = new System.Drawing.Point(167, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(808, 436);
            this.panel_background.TabIndex = 2;
            this.panel_background.MouseLeave += new System.EventHandler(this.panel_background_MouseLeave);
            this.panel_background.MouseHover += new System.EventHandler(this.panel_background_MouseHover);
            // 
            // change_background
            // 
            this.change_background.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_background.BackColor = System.Drawing.Color.Transparent;
            this.change_background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_background.Image = ((System.Drawing.Image)(resources.GetObject("change_background.Image")));
            this.change_background.Location = new System.Drawing.Point(775, 3);
            this.change_background.Name = "change_background";
            this.change_background.Size = new System.Drawing.Size(30, 30);
            this.change_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.change_background.TabIndex = 5;
            this.change_background.TabStop = false;
            this.change_background.Click += new System.EventHandler(this.change_background_Click);
            // 
            // lb_name_user
            // 
            this.lb_name_user.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_name_user.AutoSize = true;
            this.lb_name_user.BackColor = System.Drawing.Color.Transparent;
            this.lb_name_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name_user.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_name_user.Location = new System.Drawing.Point(356, 395);
            this.lb_name_user.Name = "lb_name_user";
            this.lb_name_user.Size = new System.Drawing.Size(62, 25);
            this.lb_name_user.TabIndex = 3;
            this.lb_name_user.Text = "Name";
            this.lb_name_user.Click += new System.EventHandler(this.lb_name_user_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 755);
            this.Controls.Add(this.panel_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover_avatar)).EndInit();
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_cover_avatar;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Label lb_name_user;
        private System.Windows.Forms.PictureBox change_background;
        private System.Windows.Forms.ToolTip toolTip;
    }
}