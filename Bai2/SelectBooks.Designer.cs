namespace Bai2
{
    partial class SelectBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_select_book = new System.Windows.Forms.PictureBox();
            this.btn_left = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_right = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_select_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Book";
            // 
            // btn_select_book
            // 
            this.btn_select_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_select_book.Image")));
            this.btn_select_book.Location = new System.Drawing.Point(346, 104);
            this.btn_select_book.Name = "btn_select_book";
            this.btn_select_book.Size = new System.Drawing.Size(423, 549);
            this.btn_select_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_select_book.TabIndex = 0;
            this.btn_select_book.TabStop = false;
            this.btn_select_book.Click += new System.EventHandler(this.btn_select_book_Click);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_left.Image")));
            this.btn_left.ImageActive = null;
            this.btn_left.Location = new System.Drawing.Point(32, 322);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(60, 60);
            this.btn_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_left.TabIndex = 15;
            this.btn_left.TabStop = false;
            this.btn_left.Zoom = 10;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_right.Image")));
            this.btn_right.ImageActive = null;
            this.btn_right.Location = new System.Drawing.Point(1023, 334);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(60, 60);
            this.btn_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_right.TabIndex = 14;
            this.btn_right.TabStop = false;
            this.btn_right.Zoom = 10;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // SelectBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 716);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_select_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectBooks";
            this.Text = "SelectBooks";
            ((System.ComponentModel.ISupportInitialize)(this.btn_select_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_select_book;
        private Bunifu.Framework.UI.BunifuImageButton btn_left;
        private Bunifu.Framework.UI.BunifuImageButton btn_right;
    }
}