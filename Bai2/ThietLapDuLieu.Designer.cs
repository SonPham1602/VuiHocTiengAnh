namespace Bai2
{
    partial class ThietLapDuLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThietLapDuLieu));
            this.checkedListBox_Select_units = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_start_unit = new System.Windows.Forms.TextBox();
            this.textbox_end_unit = new System.Windows.Forms.TextBox();
            this.textbox_time = new System.Windows.Forms.TextBox();
            this.combobox_mode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.lb_hienthisocauhoi = new System.Windows.Forms.Label();
            this.textbox_qt_number = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.checkAllUnit = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // checkedListBox_Select_units
            // 
            this.checkedListBox_Select_units.CheckOnClick = true;
            this.checkedListBox_Select_units.FormattingEnabled = true;
            this.checkedListBox_Select_units.Location = new System.Drawing.Point(16, 53);
            this.checkedListBox_Select_units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox_Select_units.Name = "checkedListBox_Select_units";
            this.checkedListBox_Select_units.Size = new System.Drawing.Size(298, 277);
            this.checkedListBox_Select_units.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Units";
            // 
            // textbox_start_unit
            // 
            this.textbox_start_unit.Location = new System.Drawing.Point(56, 385);
            this.textbox_start_unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_start_unit.Name = "textbox_start_unit";
            this.textbox_start_unit.Size = new System.Drawing.Size(60, 26);
            this.textbox_start_unit.TabIndex = 2;
            this.textbox_start_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_start_unit_KeyPress);
            // 
            // textbox_end_unit
            // 
            this.textbox_end_unit.Location = new System.Drawing.Point(222, 385);
            this.textbox_end_unit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_end_unit.Name = "textbox_end_unit";
            this.textbox_end_unit.Size = new System.Drawing.Size(60, 26);
            this.textbox_end_unit.TabIndex = 3;
            this.textbox_end_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_end_unit_KeyPress);
            // 
            // textbox_time
            // 
            this.textbox_time.Location = new System.Drawing.Point(375, 53);
            this.textbox_time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_time.Name = "textbox_time";
            this.textbox_time.Size = new System.Drawing.Size(120, 26);
            this.textbox_time.TabIndex = 4;
            this.textbox_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_time_KeyPress);
            // 
            // combobox_mode
            // 
            this.combobox_mode.FormattingEnabled = true;
            this.combobox_mode.Items.AddRange(new object[] {
            "Random",
            "Serialize",
            "Question numbers",
            "All items"});
            this.combobox_mode.Location = new System.Drawing.Point(375, 117);
            this.combobox_mode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combobox_mode.Name = "combobox_mode";
            this.combobox_mode.Size = new System.Drawing.Size(120, 26);
            this.combobox_mode.TabIndex = 5;
            this.combobox_mode.SelectedIndexChanged += new System.EventHandler(this.combobox_mode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select  by interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "End";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(375, 397);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(119, 65);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(375, 316);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(119, 65);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // lb_hienthisocauhoi
            // 
            this.lb_hienthisocauhoi.AutoSize = true;
            this.lb_hienthisocauhoi.Location = new System.Drawing.Point(352, 163);
            this.lb_hienthisocauhoi.Name = "lb_hienthisocauhoi";
            this.lb_hienthisocauhoi.Size = new System.Drawing.Size(168, 18);
            this.lb_hienthisocauhoi.TabIndex = 13;
            this.lb_hienthisocauhoi.Text = "Question number/Unit";
            // 
            // textbox_qt_number
            // 
            this.textbox_qt_number.Location = new System.Drawing.Point(375, 195);
            this.textbox_qt_number.Name = "textbox_qt_number";
            this.textbox_qt_number.Size = new System.Drawing.Size(119, 26);
            this.textbox_qt_number.TabIndex = 14;
            this.textbox_qt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_qt_number_KeyPress);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Select All Units";
            // 
            // checkAllUnit
            // 
            this.checkAllUnit.BackColor = System.Drawing.Color.Gray;
            this.checkAllUnit.ChechedOffColor = System.Drawing.Color.Gray;
            this.checkAllUnit.Checked = false;
            this.checkAllUnit.CheckedOnColor = System.Drawing.Color.Gray;
            this.checkAllUnit.ForeColor = System.Drawing.Color.White;
            this.checkAllUnit.Location = new System.Drawing.Point(208, 430);
            this.checkAllUnit.Margin = new System.Windows.Forms.Padding(4);
            this.checkAllUnit.Name = "checkAllUnit";
            this.checkAllUnit.Size = new System.Drawing.Size(20, 20);
            this.checkAllUnit.TabIndex = 17;
            this.checkAllUnit.OnChange += new System.EventHandler(this.checkAllUnit_OnChange);
            // 
            // ThietLapDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(522, 477);
            this.Controls.Add(this.checkAllUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_qt_number);
            this.Controls.Add(this.lb_hienthisocauhoi);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_mode);
            this.Controls.Add(this.textbox_time);
            this.Controls.Add(this.textbox_end_unit);
            this.Controls.Add(this.textbox_start_unit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox_Select_units);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThietLapDuLieu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiet Lap Du Lieu";
            this.Load += new System.EventHandler(this.ThietLapDuLieu_Load);
            this.Shown += new System.EventHandler(this.ThietLapDuLieu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.CheckedListBox checkedListBox_Select_units;
        public int Start_Unit;
        public int End_Unit;
        public int Time_Test;
        public string Test_Mode;
        public int[] Select_Unit;
        public int amountquestion;
        private System.Windows.Forms.TextBox textbox_start_unit;
        private System.Windows.Forms.TextBox textbox_end_unit;
        private System.Windows.Forms.TextBox textbox_time;
        private System.Windows.Forms.ComboBox combobox_mode;
        private System.Windows.Forms.Label lb_hienthisocauhoi;
        private System.Windows.Forms.TextBox textbox_qt_number;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox checkAllUnit;
        private System.Windows.Forms.Label label8;
    }
}