namespace Bai2
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.pn_mark = new System.Windows.Forms.Panel();
            this.bt_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_setting_game = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_start = new Bunifu.Framework.UI.BunifuImageButton();
            this.hien_thi_tg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number_false = new System.Windows.Forms.Label();
            this.number_true = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.answerH = new System.Windows.Forms.RadioButton();
            this.answerG = new System.Windows.Forms.RadioButton();
            this.answerF = new System.Windows.Forms.RadioButton();
            this.answerE = new System.Windows.Forms.RadioButton();
            this.pb_next_qt = new System.Windows.Forms.PictureBox();
            this.answerD = new System.Windows.Forms.RadioButton();
            this.answerC = new System.Windows.Forms.RadioButton();
            this.answerB = new System.Windows.Forms.RadioButton();
            this.answerA = new System.Windows.Forms.RadioButton();
            this.btn_help = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            this.pn_mark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_setting_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_start)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next_qt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_show
            // 
            this.pb_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_show.BackColor = System.Drawing.Color.Transparent;
            this.pb_show.Image = ((System.Drawing.Image)(resources.GetObject("pb_show.Image")));
            this.pb_show.Location = new System.Drawing.Point(230, 116);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(712, 492);
            this.pb_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_show.TabIndex = 6;
            this.pb_show.TabStop = false;
            // 
            // pn_mark
            // 
            this.pn_mark.BackColor = System.Drawing.Color.LightGray;
            this.pn_mark.Controls.Add(this.bt_close);
            this.pn_mark.Controls.Add(this.bt_setting_game);
            this.pn_mark.Controls.Add(this.bt_start);
            this.pn_mark.Controls.Add(this.hien_thi_tg);
            this.pn_mark.Controls.Add(this.label7);
            this.pn_mark.Controls.Add(this.label6);
            this.pn_mark.Controls.Add(this.number_false);
            this.pn_mark.Controls.Add(this.number_true);
            this.pn_mark.Controls.Add(this.label3);
            this.pn_mark.Controls.Add(this.label2);
            this.pn_mark.Controls.Add(this.lb_score);
            this.pn_mark.Controls.Add(this.label1);
            this.pn_mark.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_mark.Location = new System.Drawing.Point(0, 0);
            this.pn_mark.Name = "pn_mark";
            this.pn_mark.Size = new System.Drawing.Size(1130, 110);
            this.pn_mark.TabIndex = 7;
            // 
            // bt_close
            // 
            this.bt_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.ImageActive = null;
            this.bt_close.Location = new System.Drawing.Point(715, 22);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(60, 60);
            this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_close.TabIndex = 10;
            this.bt_close.TabStop = false;
            this.bt_close.Zoom = 5;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_setting_game
            // 
            this.bt_setting_game.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_setting_game.BackColor = System.Drawing.Color.Transparent;
            this.bt_setting_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_setting_game.Image = ((System.Drawing.Image)(resources.GetObject("bt_setting_game.Image")));
            this.bt_setting_game.ImageActive = null;
            this.bt_setting_game.Location = new System.Drawing.Point(353, 22);
            this.bt_setting_game.Name = "bt_setting_game";
            this.bt_setting_game.Size = new System.Drawing.Size(60, 60);
            this.bt_setting_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_setting_game.TabIndex = 9;
            this.bt_setting_game.TabStop = false;
            this.bt_setting_game.Zoom = 5;
            this.bt_setting_game.Click += new System.EventHandler(this.bt_setting_game_Click);
            // 
            // bt_start
            // 
            this.bt_start.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_start.BackColor = System.Drawing.Color.Transparent;
            this.bt_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_start.Image = ((System.Drawing.Image)(resources.GetObject("bt_start.Image")));
            this.bt_start.ImageActive = null;
            this.bt_start.Location = new System.Drawing.Point(534, 22);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(60, 60);
            this.bt_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_start.TabIndex = 4;
            this.bt_start.TabStop = false;
            this.bt_start.Zoom = 5;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // hien_thi_tg
            // 
            this.hien_thi_tg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hien_thi_tg.AutoSize = true;
            this.hien_thi_tg.Font = new System.Drawing.Font("DigifaceWide", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hien_thi_tg.Location = new System.Drawing.Point(1026, 39);
            this.hien_thi_tg.Name = "hien_thi_tg";
            this.hien_thi_tg.Size = new System.Drawing.Size(85, 26);
            this.hien_thi_tg.TabIndex = 8;
            this.hien_thi_tg.Text = "00:00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1016, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số câu sai:";
            // 
            // number_false
            // 
            this.number_false.AutoSize = true;
            this.number_false.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_false.ForeColor = System.Drawing.SystemColors.ControlText;
            this.number_false.Location = new System.Drawing.Point(155, 65);
            this.number_false.Name = "number_false";
            this.number_false.Size = new System.Drawing.Size(25, 28);
            this.number_false.TabIndex = 5;
            this.number_false.Text = "0";
            // 
            // number_true
            // 
            this.number_true.AutoSize = true;
            this.number_true.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_true.ForeColor = System.Drawing.SystemColors.ControlText;
            this.number_true.Location = new System.Drawing.Point(155, 37);
            this.number_true.Name = "number_true";
            this.number_true.Size = new System.Drawing.Size(25, 28);
            this.number_true.TabIndex = 4;
            this.number_true.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số câu đúng:";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_score.Location = new System.Drawing.Point(155, 9);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(25, 28);
            this.lb_score.TabIndex = 1;
            this.lb_score.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aachen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.answerH);
            this.panel2.Controls.Add(this.answerG);
            this.panel2.Controls.Add(this.answerF);
            this.panel2.Controls.Add(this.answerE);
            this.panel2.Controls.Add(this.pb_next_qt);
            this.panel2.Controls.Add(this.answerD);
            this.panel2.Controls.Add(this.answerC);
            this.panel2.Controls.Add(this.answerB);
            this.panel2.Controls.Add(this.answerA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 141);
            this.panel2.TabIndex = 8;
            // 
            // answerH
            // 
            this.answerH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerH.AutoSize = true;
            this.answerH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerH.Location = new System.Drawing.Point(679, 101);
            this.answerH.Name = "answerH";
            this.answerH.Size = new System.Drawing.Size(103, 28);
            this.answerH.TabIndex = 8;
            this.answerH.TabStop = true;
            this.answerH.Text = "answerH";
            this.answerH.UseVisualStyleBackColor = true;
            // 
            // answerG
            // 
            this.answerG.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerG.AutoSize = true;
            this.answerG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerG.Location = new System.Drawing.Point(679, 40);
            this.answerG.Name = "answerG";
            this.answerG.Size = new System.Drawing.Size(103, 28);
            this.answerG.TabIndex = 7;
            this.answerG.TabStop = true;
            this.answerG.Text = "answerG";
            this.answerG.UseVisualStyleBackColor = true;
            // 
            // answerF
            // 
            this.answerF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerF.AutoSize = true;
            this.answerF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerF.Location = new System.Drawing.Point(259, 101);
            this.answerF.Name = "answerF";
            this.answerF.Size = new System.Drawing.Size(101, 28);
            this.answerF.TabIndex = 6;
            this.answerF.TabStop = true;
            this.answerF.Text = "answerF";
            this.answerF.UseVisualStyleBackColor = true;
            // 
            // answerE
            // 
            this.answerE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerE.AutoSize = true;
            this.answerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerE.Location = new System.Drawing.Point(259, 40);
            this.answerE.Name = "answerE";
            this.answerE.Size = new System.Drawing.Size(102, 28);
            this.answerE.TabIndex = 5;
            this.answerE.TabStop = true;
            this.answerE.Text = "answerE";
            this.answerE.UseVisualStyleBackColor = true;
            // 
            // pb_next_qt
            // 
            this.pb_next_qt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_next_qt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_next_qt.Image = ((System.Drawing.Image)(resources.GetObject("pb_next_qt.Image")));
            this.pb_next_qt.Location = new System.Drawing.Point(534, 40);
            this.pb_next_qt.Name = "pb_next_qt";
            this.pb_next_qt.Size = new System.Drawing.Size(60, 60);
            this.pb_next_qt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_next_qt.TabIndex = 4;
            this.pb_next_qt.TabStop = false;
            this.pb_next_qt.Click += new System.EventHandler(this.pb_next_qt_Click);
            // 
            // answerD
            // 
            this.answerD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerD.AutoSize = true;
            this.answerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerD.Location = new System.Drawing.Point(899, 101);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(102, 28);
            this.answerD.TabIndex = 3;
            this.answerD.TabStop = true;
            this.answerD.Text = "answerD";
            this.answerD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerD.UseVisualStyleBackColor = true;
            // 
            // answerC
            // 
            this.answerC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerC.AutoSize = true;
            this.answerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerC.Location = new System.Drawing.Point(899, 40);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(102, 28);
            this.answerC.TabIndex = 2;
            this.answerC.TabStop = true;
            this.answerC.Text = "answerC";
            this.answerC.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerB.AutoSize = true;
            this.answerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerB.Location = new System.Drawing.Point(64, 101);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(101, 28);
            this.answerB.TabIndex = 1;
            this.answerB.TabStop = true;
            this.answerB.Text = "answerB";
            this.answerB.UseVisualStyleBackColor = true;
            // 
            // answerA
            // 
            this.answerA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerA.AutoSize = true;
            this.answerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA.Location = new System.Drawing.Point(64, 40);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(102, 28);
            this.answerA.TabIndex = 0;
            this.answerA.TabStop = true;
            this.answerA.Text = "answerA";
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.Image")));
            this.btn_help.ImageActive = null;
            this.btn_help.Location = new System.Drawing.Point(1079, 116);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(45, 45);
            this.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_help.TabIndex = 11;
            this.btn_help.TabStop = false;
            this.btn_help.Zoom = 5;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 755);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_mark);
            this.Controls.Add(this.pb_show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            this.pn_mark.ResumeLayout(false);
            this.pn_mark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_setting_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_start)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_next_qt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_help)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_show;
        private System.Windows.Forms.Panel pn_mark;
        private System.Windows.Forms.Label hien_thi_tg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label number_false;
        private System.Windows.Forms.Label number_true;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton answerA;
        private System.Windows.Forms.RadioButton answerD;
        private System.Windows.Forms.RadioButton answerC;
        private System.Windows.Forms.RadioButton answerB;
        private Bunifu.Framework.UI.BunifuImageButton bt_start;
        private Bunifu.Framework.UI.BunifuImageButton bt_setting_game;
        private System.Windows.Forms.PictureBox pb_next_qt;
        private Bunifu.Framework.UI.BunifuImageButton bt_close;
        private System.Windows.Forms.RadioButton answerH;
        private System.Windows.Forms.RadioButton answerG;
        private System.Windows.Forms.RadioButton answerF;
        private System.Windows.Forms.RadioButton answerE;
        private Bunifu.Framework.UI.BunifuImageButton btn_help;
    }
}