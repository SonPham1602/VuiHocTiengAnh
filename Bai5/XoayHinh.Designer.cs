namespace Bai5
{
    partial class XoayHinh
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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoayHinh));
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.animator2 = new AnimatorNS.Animator();
            this.timer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.animator1.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button1, AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(178, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Rotate;
            this.animator1.Cursor = System.Windows.Forms.Cursors.Hand;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 10F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation3;
            this.animator1.Interval = 5;
            this.animator1.MaxAnimationTime = 100000;
            this.animator1.TimeStep = 0.001F;
            // 
            // pb_image
            // 
            this.animator1.SetDecoration(this.pb_image, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pb_image, AnimatorNS.DecorationType.None);
            this.pb_image.Image = ((System.Drawing.Image)(resources.GetObject("pb_image.Image")));
            this.pb_image.Location = new System.Drawing.Point(464, 37);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(300, 300);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 2;
            this.pb_image.TabStop = false;
            // 
            // button2
            // 
            this.animator1.SetDecoration(this.button2, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button2, AnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(580, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // animator2
            // 
            this.animator2.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation4;
            // 
            // timer
            // 
            this.timer.Interval = 6;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // XoayHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "XoayHinh";
            this.Text = "XoayHinh";
            this.Load += new System.EventHandler(this.XoayHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private AnimatorNS.Animator animator1;
        private AnimatorNS.Animator animator2;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
    }
}