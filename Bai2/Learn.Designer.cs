namespace Bai2
{
    partial class Learn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn));
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_audio = new System.Windows.Forms.PictureBox();
            this.pb_next = new System.Windows.Forms.PictureBox();
            this.hienthianh = new System.Windows.Forms.PictureBox();
            this.select_unit = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_mean_word = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Select_voice = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb2 = new System.Windows.Forms.Label();
            this.volume_voice = new System.Windows.Forms.TrackBar();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.speed_voice = new System.Windows.Forms.TrackBar();
            this.pb_reset = new System.Windows.Forms.PictureBox();
            this.pb_mark = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_audio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_voice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_voice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mark)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_back
            // 
            this.pb_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = ((System.Drawing.Image)(resources.GetObject("pb_back.Image")));
            this.pb_back.Location = new System.Drawing.Point(382, 16);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(50, 50);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_back.TabIndex = 2;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_audio
            // 
            this.pb_audio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_audio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_audio.Image = ((System.Drawing.Image)(resources.GetObject("pb_audio.Image")));
            this.pb_audio.Location = new System.Drawing.Point(542, 16);
            this.pb_audio.Name = "pb_audio";
            this.pb_audio.Size = new System.Drawing.Size(50, 50);
            this.pb_audio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_audio.TabIndex = 3;
            this.pb_audio.TabStop = false;
            this.pb_audio.Click += new System.EventHandler(this.pb_audio_Click);
            // 
            // pb_next
            // 
            this.pb_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_next.Image = ((System.Drawing.Image)(resources.GetObject("pb_next.Image")));
            this.pb_next.Location = new System.Drawing.Point(693, 16);
            this.pb_next.Name = "pb_next";
            this.pb_next.Size = new System.Drawing.Size(50, 50);
            this.pb_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_next.TabIndex = 4;
            this.pb_next.TabStop = false;
            this.pb_next.Click += new System.EventHandler(this.pb_next_Click);
            // 
            // hienthianh
            // 
            this.hienthianh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hienthianh.BackColor = System.Drawing.Color.Transparent;
            this.hienthianh.Image = ((System.Drawing.Image)(resources.GetObject("hienthianh.Image")));
            this.hienthianh.Location = new System.Drawing.Point(235, 26);
            this.hienthianh.Name = "hienthianh";
            this.hienthianh.Size = new System.Drawing.Size(708, 637);
            this.hienthianh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hienthianh.TabIndex = 5;
            this.hienthianh.TabStop = false;
            // 
            // select_unit
            // 
            this.select_unit.BackColor = System.Drawing.Color.Transparent;
            this.select_unit.BorderRadius = 6;
            this.select_unit.DisabledColor = System.Drawing.Color.Gray;
            this.select_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.select_unit.Items = new string[] {
        "Unit 1 It\'s time to wake up",
        "Unit 2 Let\'s get dressed",
        "Unit 3 Breakfast-time",
        "Unit 4 Going to school",
        "Unit 5 Lesson time",
        "Unit 6 Indoor playtime",
        "Unit 7 Outdoor playtime",
        "Unit 8 Snack-time",
        "Unit 9 In the kitchen",
        "Unit 10 Dinner-time",
        "Unit 11 In the bathroom",
        "Unit 12 Let\'s relax",
        "Unit 13 Bedtime",
        "Unit 14 Happy Birthday, David!",
        "Unit 15 It\'s sunny today!",
        "Unit 16 Our pet show",
        "Unit 17 Our school concert",
        "Unit 18 At the fast-food restaurant",
        "Unit 19 At the supermarket",
        "Unit 20 At the shopping center",
        "Unit 21 At the bird park",
        "Unit 22 At the zoo",
        "Unit 23 At the beach",
        "Unit 24 At the circus",
        "Unit 25 In the playgrounf",
        "Unit 26 At the park",
        "Unit 27 On the farm",
        "Unit 28 At the swimming pool",
        "Unit 29 At the library",
        "Unit 30 The postman",
        "Unit 31 The dustman",
        "Unit 32 The policeman",
        "Unit 33 The fireman",
        "Unit 34 The Builder",
        "Unit 35 The hairdresser and the barber",
        "Unit 36 The dentist",
        "Unit 37 The doctor",
        "Unit 38 Le\'s go for a car ride",
        "Unit 39 At the garage",
        "Unit 40 Let\'s ride in the bus ",
        "Unit 41 Let\'s ride on the underground train ",
        "Unit 42 Let\'s go for a boat ride",
        "Unit 43 At the railway station ",
        "Unit 44 At the airport"};
            this.select_unit.Location = new System.Drawing.Point(13, 35);
            this.select_unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.select_unit.Name = "select_unit";
            this.select_unit.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
            this.select_unit.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(220)))), ((int)(((byte)(175)))));
            this.select_unit.selectedIndex = -1;
            this.select_unit.Size = new System.Drawing.Size(196, 37);
            this.select_unit.TabIndex = 6;
            this.select_unit.onItemSelected += new System.EventHandler(this.select_unit_onItemSelected);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lb_mean_word
            // 
            this.lb_mean_word.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_mean_word.AutoSize = true;
            this.lb_mean_word.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mean_word.Location = new System.Drawing.Point(536, 666);
            this.lb_mean_word.Name = "lb_mean_word";
            this.lb_mean_word.Size = new System.Drawing.Size(69, 31);
            this.lb_mean_word.TabIndex = 7;
            this.lb_mean_word.Text = "word";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb1.ForeColor = System.Drawing.Color.DimGray;
            this.lb1.Location = new System.Drawing.Point(42, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(138, 31);
            this.lb1.TabIndex = 8;
            this.lb1.Text = "Select Unit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pb_audio);
            this.panel1.Controls.Add(this.pb_next);
            this.panel1.Controls.Add(this.pb_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 713);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 81);
            this.panel1.TabIndex = 9;
            // 
            // Select_voice
            // 
            this.Select_voice.BackColor = System.Drawing.Color.Transparent;
            this.Select_voice.BorderRadius = 6;
            this.Select_voice.DisabledColor = System.Drawing.Color.Gray;
            this.Select_voice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_voice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Select_voice.Items = new string[] {
        "Male",
        "Female"};
            this.Select_voice.Location = new System.Drawing.Point(13, 131);
            this.Select_voice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Select_voice.Name = "Select_voice";
            this.Select_voice.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(202)))), ((int)(((byte)(175)))));
            this.Select_voice.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(220)))), ((int)(((byte)(175)))));
            this.Select_voice.selectedIndex = 0;
            this.Select_voice.Size = new System.Drawing.Size(196, 37);
            this.Select_voice.TabIndex = 10;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb2.ForeColor = System.Drawing.Color.DimGray;
            this.lb2.Location = new System.Drawing.Point(34, 76);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(154, 31);
            this.lb2.TabIndex = 11;
            this.lb2.Text = "Select Voice";
            // 
            // volume_voice
            // 
            this.volume_voice.LargeChange = 20;
            this.volume_voice.Location = new System.Drawing.Point(13, 247);
            this.volume_voice.Maximum = 100;
            this.volume_voice.Name = "volume_voice";
            this.volume_voice.Size = new System.Drawing.Size(196, 45);
            this.volume_voice.TabIndex = 12;
            this.volume_voice.Value = 80;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb3.ForeColor = System.Drawing.Color.DimGray;
            this.lb3.Location = new System.Drawing.Point(23, 193);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(176, 31);
            this.lb3.TabIndex = 13;
            this.lb3.Text = "Select Volume";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb4.ForeColor = System.Drawing.Color.DimGray;
            this.lb4.Location = new System.Drawing.Point(30, 304);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(163, 31);
            this.lb4.TabIndex = 15;
            this.lb4.Text = "Select Speed";
            // 
            // speed_voice
            // 
            this.speed_voice.LargeChange = 1;
            this.speed_voice.Location = new System.Drawing.Point(13, 357);
            this.speed_voice.Minimum = -10;
            this.speed_voice.Name = "speed_voice";
            this.speed_voice.Size = new System.Drawing.Size(196, 45);
            this.speed_voice.TabIndex = 14;
            // 
            // pb_reset
            // 
            this.pb_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_reset.Image = ((System.Drawing.Image)(resources.GetObject("pb_reset.Image")));
            this.pb_reset.Location = new System.Drawing.Point(86, 425);
            this.pb_reset.Name = "pb_reset";
            this.pb_reset.Size = new System.Drawing.Size(50, 50);
            this.pb_reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_reset.TabIndex = 16;
            this.pb_reset.TabStop = false;
            this.pb_reset.Click += new System.EventHandler(this.pb_reset_Click);
            // 
            // pb_mark
            // 
            this.pb_mark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_mark.Location = new System.Drawing.Point(949, 613);
            this.pb_mark.Name = "pb_mark";
            this.pb_mark.Size = new System.Drawing.Size(50, 50);
            this.pb_mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_mark.TabIndex = 17;
            this.pb_mark.TabStop = false;
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1146, 794);
            this.Controls.Add(this.pb_mark);
            this.Controls.Add(this.select_unit);
            this.Controls.Add(this.pb_reset);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.speed_voice);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.volume_voice);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.Select_voice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.hienthianh);
            this.Controls.Add(this.lb_mean_word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Learn";
            this.Text = "Learn";
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_audio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthianh)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volume_voice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_voice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.PictureBox pb_audio;
        private System.Windows.Forms.PictureBox pb_next;
        private System.Windows.Forms.PictureBox hienthianh;
        private Bunifu.Framework.UI.BunifuDropdown select_unit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_mean_word;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown Select_voice;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TrackBar volume_voice;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TrackBar speed_voice;
        private System.Windows.Forms.PictureBox pb_reset;
        private System.Windows.Forms.PictureBox pb_mark;
    }
}