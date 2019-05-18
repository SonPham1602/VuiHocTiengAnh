namespace Bai3
{
    partial class Form3
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
            this.btn_xulianh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_xulianh
            // 
            this.btn_xulianh.Location = new System.Drawing.Point(90, 115);
            this.btn_xulianh.Name = "btn_xulianh";
            this.btn_xulianh.Size = new System.Drawing.Size(104, 31);
            this.btn_xulianh.TabIndex = 6;
            this.btn_xulianh.Text = "tai anh";
            this.btn_xulianh.UseVisualStyleBackColor = true;
            this.btn_xulianh.Click += new System.EventHandler(this.btn_xulianh_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_xulianh);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_xulianh;
    }
}