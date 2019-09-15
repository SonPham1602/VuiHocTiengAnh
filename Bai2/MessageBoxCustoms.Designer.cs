namespace Bai2
{
    partial class MessageBoxCustoms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCustoms));
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_ok = new System.Windows.Forms.PictureBox();
            this.GradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TypeMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_noidung = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).BeginInit();
            this.GradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(489, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 20;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.Location = new System.Drawing.Point(174, 164);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 53);
            this.btn_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ok.TabIndex = 21;
            this.btn_ok.TabStop = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // GradientPanel
            // 
            this.GradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GradientPanel.BackgroundImage")));
            this.GradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GradientPanel.Controls.Add(this.TypeMessage);
            this.GradientPanel.Controls.Add(this.btn_close);
            this.GradientPanel.GradientBottomLeft = System.Drawing.Color.LightSteelBlue;
            this.GradientPanel.GradientBottomRight = System.Drawing.Color.Transparent;
            this.GradientPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(218)))));
            this.GradientPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(218)))));
            this.GradientPanel.Location = new System.Drawing.Point(1, 1);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Quality = 10;
            this.GradientPanel.Size = new System.Drawing.Size(522, 64);
            this.GradientPanel.TabIndex = 27;
            // 
            // TypeMessage
            // 
            this.TypeMessage.BackColor = System.Drawing.Color.Transparent;
            this.TypeMessage.Font = new System.Drawing.Font("Arial", 15.75F);
            this.TypeMessage.ForeColor = System.Drawing.Color.White;
            this.TypeMessage.Location = new System.Drawing.Point(151, 8);
            this.TypeMessage.Name = "TypeMessage";
            this.TypeMessage.Size = new System.Drawing.Size(226, 39);
            this.TypeMessage.TabIndex = 26;
            this.TypeMessage.Text = "Thông Báo";
            this.TypeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_noidung
            // 
            this.lb_noidung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_noidung.BackColor = System.Drawing.Color.Transparent;
            this.lb_noidung.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lb_noidung.ForeColor = System.Drawing.Color.DimGray;
            this.lb_noidung.Location = new System.Drawing.Point(12, 69);
            this.lb_noidung.Name = "lb_noidung";
            this.lb_noidung.Size = new System.Drawing.Size(501, 87);
            this.lb_noidung.TabIndex = 28;
            this.lb_noidung.Text = "Thong Bao";
            this.lb_noidung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.GradientPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MessageBoxCustoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(525, 225);
            this.Controls.Add(this.lb_noidung);
            this.Controls.Add(this.GradientPanel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(525, 525);
            this.Name = "MessageBoxCustoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBoxCustoms_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBoxCustoms_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ok)).EndInit();
            this.GradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox btn_ok;
        private System.Windows.Forms.PictureBox btn_close;
        private Bunifu.Framework.UI.BunifuGradientPanel GradientPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel TypeMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_noidung;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}