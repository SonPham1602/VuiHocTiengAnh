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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_cau_cham_ngon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_help = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover_avatar)).BeginInit();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_cover_avatar
            // 
            this.pb_cover_avatar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_cover_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_cover_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cover_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_cover_avatar.Image")));
            this.pb_cover_avatar.Location = new System.Drawing.Point(305, 183);
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
            this.lb_name_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_name_user.BackColor = System.Drawing.Color.Transparent;
            this.lb_name_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name_user.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name_user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_name_user.Location = new System.Drawing.Point(3, 398);
            this.lb_name_user.Name = "lb_name_user";
            this.lb_name_user.Size = new System.Drawing.Size(805, 25);
            this.lb_name_user.TabIndex = 3;
            this.lb_name_user.Text = "Name";
            this.lb_name_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_name_user.Click += new System.EventHandler(this.lb_name_user_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Open Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(162, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Open Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Play Games:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_cau_cham_ngon
            // 
            this.lb_cau_cham_ngon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cau_cham_ngon.BackColor = System.Drawing.Color.Transparent;
            this.lb_cau_cham_ngon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_cau_cham_ngon.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cau_cham_ngon.ForeColor = System.Drawing.Color.DimGray;
            this.lb_cau_cham_ngon.Location = new System.Drawing.Point(170, 439);
            this.lb_cau_cham_ngon.Name = "lb_cau_cham_ngon";
            this.lb_cau_cham_ngon.Size = new System.Drawing.Size(805, 73);
            this.lb_cau_cham_ngon.TabIndex = 6;
            this.lb_cau_cham_ngon.Text = " If you can dream it, you can do it";
            this.lb_cau_cham_ngon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_cau_cham_ngon.Click += new System.EventHandler(this.lb_cau_cham_ngon_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Do Test:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(12, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "High Score in Test:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(12, 695);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "High Score in Game:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.Image")));
            this.btn_help.ImageActive = null;
            this.btn_help.Location = new System.Drawing.Point(1073, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(45, 45);
            this.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_help.TabIndex = 13;
            this.btn_help.TabStop = false;
            this.btn_help.Zoom = 10;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 755);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_cau_cham_ngon);
            this.Controls.Add(this.panel_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_cover_avatar)).EndInit();
            this.panel_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_cover_avatar;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Label lb_name_user;
        private System.Windows.Forms.PictureBox change_background;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_cau_cham_ngon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton btn_help;
    }
}