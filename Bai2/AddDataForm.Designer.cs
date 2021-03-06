﻿namespace Bai2
{
    partial class AddDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataForm));
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btn_open_image = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_draw = new System.Windows.Forms.Button();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button_Ok = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_cancel = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_show
            // 
            this.pb_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_show.Image = ((System.Drawing.Image)(resources.GetObject("pb_show.Image")));
            this.pb_show.Location = new System.Drawing.Point(12, 49);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(382, 233);
            this.pb_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_show.TabIndex = 0;
            this.pb_show.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(81, 302);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(243, 23);
            this.txtPath.TabIndex = 2;
            // 
            // btn_open_image
            // 
            this.btn_open_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(98)))));
            this.btn_open_image.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_image.ForeColor = System.Drawing.Color.White;
            this.btn_open_image.Location = new System.Drawing.Point(330, 298);
            this.btn_open_image.Name = "btn_open_image";
            this.btn_open_image.Size = new System.Drawing.Size(64, 31);
            this.btn_open_image.TabIndex = 3;
            this.btn_open_image.TabStop = false;
            this.btn_open_image.Text = "Open";
            this.btn_open_image.UseVisualStyleBackColor = false;
            this.btn_open_image.Click += new System.EventHandler(this.btn_open_image_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(81, 344);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 23);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Path";
            // 
            // btn_draw
            // 
            this.btn_draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(98)))));
            this.btn_draw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_draw.ForeColor = System.Drawing.Color.White;
            this.btn_draw.Location = new System.Drawing.Point(12, 12);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(64, 31);
            this.btn_draw.TabIndex = 12;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = false;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // button_Ok
            // 
            this.button_Ok.BackColor = System.Drawing.Color.Transparent;
            this.button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ok.Image = ((System.Drawing.Image)(resources.GetObject("button_Ok.Image")));
            this.button_Ok.ImageActive = null;
            this.button_Ok.Location = new System.Drawing.Point(15, 387);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(148, 59);
            this.button_Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Ok.TabIndex = 13;
            this.button_Ok.TabStop = false;
            this.button_Ok.Zoom = 10;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_cancel.Image")));
            this.button_cancel.ImageActive = null;
            this.button_cancel.Location = new System.Drawing.Point(246, 387);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(148, 59);
            this.button_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_cancel.TabIndex = 14;
            this.button_cancel.TabStop = false;
            this.button_cancel.Zoom = 10;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(406, 462);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn_open_image);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pb_show);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDataForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDataForm";
            this.Load += new System.EventHandler(this.AddDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_show;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btn_open_image;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_draw;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuImageButton button_cancel;
        private Bunifu.Framework.UI.BunifuImageButton button_Ok;
    }
}