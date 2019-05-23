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
            this.hienthianh = new System.Windows.Forms.PictureBox();
            this.textbox_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_help = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_unit_name = new System.Windows.Forms.Label();
            this.lb_mean_word = new System.Windows.Forms.Label();
            this.btn_right = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_left = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_search_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).BeginInit();
            this.SuspendLayout();
            // 
            // hienthianh
            // 
            this.hienthianh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hienthianh.Location = new System.Drawing.Point(238, 139);
            this.hienthianh.Name = "hienthianh";
            this.hienthianh.Size = new System.Drawing.Size(703, 548);
            this.hienthianh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hienthianh.TabIndex = 3;
            this.hienthianh.TabStop = false;
            // 
            // textbox_search
            // 
            this.textbox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_search.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.BorderThickness = 2;
            this.textbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_search.isPassword = false;
            this.textbox_search.Location = new System.Drawing.Point(238, 33);
            this.textbox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(703, 44);
            this.textbox_search.TabIndex = 4;
            this.textbox_search.Text = "Write The Word";
            this.textbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_search.Click += new System.EventHandler(this.textbox_search_Click);
            this.textbox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_search_KeyDown);
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.Image")));
            this.btn_help.ImageActive = null;
            this.btn_help.Location = new System.Drawing.Point(1089, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(45, 45);
            this.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_help.TabIndex = 5;
            this.btn_help.TabStop = false;
            this.btn_help.Zoom = 10;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lb_unit_name
            // 
            this.lb_unit_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_unit_name.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_unit_name.Location = new System.Drawing.Point(238, 754);
            this.lb_unit_name.Name = "lb_unit_name";
            this.lb_unit_name.Size = new System.Drawing.Size(703, 31);
            this.lb_unit_name.TabIndex = 10;
            this.lb_unit_name.Text = "label1";
            this.lb_unit_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mean_word
            // 
            this.lb_mean_word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mean_word.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_mean_word.Location = new System.Drawing.Point(238, 709);
            this.lb_mean_word.Name = "lb_mean_word";
            this.lb_mean_word.Size = new System.Drawing.Size(703, 31);
            this.lb_mean_word.TabIndex = 11;
            this.lb_mean_word.Text = "label1";
            this.lb_mean_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_right
            // 
            this.btn_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_right.Image")));
            this.btn_right.ImageActive = null;
            this.btn_right.Location = new System.Drawing.Point(947, 420);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(60, 60);
            this.btn_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_right.TabIndex = 12;
            this.btn_right.TabStop = false;
            this.btn_right.Zoom = 10;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_left.Image")));
            this.btn_left.ImageActive = null;
            this.btn_left.Location = new System.Drawing.Point(172, 408);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(60, 60);
            this.btn_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_left.TabIndex = 13;
            this.btn_left.TabStop = false;
            this.btn_left.Zoom = 10;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // lb_search_result
            // 
            this.lb_search_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_search_result.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_search_result.Location = new System.Drawing.Point(238, 95);
            this.lb_search_result.Name = "lb_search_result";
            this.lb_search_result.Size = new System.Drawing.Size(703, 31);
            this.lb_search_result.TabIndex = 14;
            this.lb_search_result.Text = "label1";
            this.lb_search_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1146, 794);
            this.Controls.Add(this.lb_search_result);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.lb_mean_word);
            this.Controls.Add(this.lb_unit_name);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.textbox_search);
            this.Controls.Add(this.hienthianh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hienthianh;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_search;
        private Bunifu.Framework.UI.BunifuImageButton btn_help;
        private System.Windows.Forms.Label lb_unit_name;
        private System.Windows.Forms.Label lb_mean_word;
        private Bunifu.Framework.UI.BunifuImageButton btn_right;
        private Bunifu.Framework.UI.BunifuImageButton btn_left;
        private System.Windows.Forms.Label lb_search_result;
    }
}