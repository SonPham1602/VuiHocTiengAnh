namespace Bai2
{
    partial class ChangeText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeText));
            this.tb_change_name = new System.Windows.Forms.TextBox();
            this.bt_Ok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // tb_change_name
            // 
            this.tb_change_name.CausesValidation = false;
            this.tb_change_name.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_change_name.Location = new System.Drawing.Point(39, 37);
            this.tb_change_name.Name = "tb_change_name";
            this.tb_change_name.Size = new System.Drawing.Size(214, 33);
            this.tb_change_name.TabIndex = 1;
            this.tb_change_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_Ok
            // 
            this.bt_Ok.ActiveBorderThickness = 2;
            this.bt_Ok.ActiveCornerRadius = 20;
            this.bt_Ok.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bt_Ok.ActiveForecolor = System.Drawing.Color.White;
            this.bt_Ok.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bt_Ok.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Ok.BackgroundImage")));
            this.bt_Ok.ButtonText = "OK";
            this.bt_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ok.ForeColor = System.Drawing.Color.SeaGreen;
            this.bt_Ok.IdleBorderThickness = 2;
            this.bt_Ok.IdleCornerRadius = 20;
            this.bt_Ok.IdleFillColor = System.Drawing.Color.White;
            this.bt_Ok.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bt_Ok.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bt_Ok.Location = new System.Drawing.Point(14, 78);
            this.bt_Ok.Margin = new System.Windows.Forms.Padding(5);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(112, 52);
            this.bt_Ok.TabIndex = 2;
            this.bt_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Aachen", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_name.Location = new System.Drawing.Point(112, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 25);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name";
            // 
            // bt_cancel
            // 
            this.bt_cancel.ActiveBorderThickness = 2;
            this.bt_cancel.ActiveCornerRadius = 20;
            this.bt_cancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bt_cancel.ActiveForecolor = System.Drawing.Color.White;
            this.bt_cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bt_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cancel.BackgroundImage")));
            this.bt_cancel.ButtonText = "Cancel";
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.bt_cancel.IdleBorderThickness = 2;
            this.bt_cancel.IdleCornerRadius = 20;
            this.bt_cancel.IdleFillColor = System.Drawing.Color.White;
            this.bt_cancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bt_cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bt_cancel.Location = new System.Drawing.Point(158, 78);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 52);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // ChangeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.tb_change_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_change_name;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_Ok;
        private System.Windows.Forms.Label lb_name;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_cancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;

    }
}