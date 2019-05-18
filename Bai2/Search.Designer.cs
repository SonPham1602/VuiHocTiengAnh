namespace Bai2
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.tb_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.hienthianh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.tb_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_search.BackgroundImage")));
            this.tb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_search.ForeColor = System.Drawing.Color.SeaGreen;
            this.tb_search.Icon = ((System.Drawing.Image)(resources.GetObject("tb_search.Icon")));
            this.tb_search.Location = new System.Drawing.Point(357, 33);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(409, 55);
            this.tb_search.TabIndex = 3;
            this.tb_search.text = "";
            this.tb_search.KeyPress += new System.EventHandler(this.tb_search_KeyPress);
            // 
            // hienthianh
            // 
            this.hienthianh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hienthianh.Location = new System.Drawing.Point(238, 94);
            this.hienthianh.Name = "hienthianh";
            this.hienthianh.Size = new System.Drawing.Size(703, 593);
            this.hienthianh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hienthianh.TabIndex = 3;
            this.hienthianh.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1146, 794);
            this.Controls.Add(this.hienthianh);
            this.Controls.Add(this.tb_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox tb_search;
        private System.Windows.Forms.PictureBox hienthianh;
    }
}