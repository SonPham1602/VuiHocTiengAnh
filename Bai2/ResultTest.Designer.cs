namespace Bai2
{
    partial class ResultTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultTest));
            this.label_true = new System.Windows.Forms.Label();
            this.label_false = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.picture_teacher = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_ShowResult = new System.Windows.Forms.ListView();
            this.cl_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label_true
            // 
            this.label_true.AutoSize = true;
            this.label_true.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_true.Location = new System.Drawing.Point(14, 248);
            this.label_true.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_true.Name = "label_true";
            this.label_true.Size = new System.Drawing.Size(81, 36);
            this.label_true.TabIndex = 0;
            this.label_true.Text = "True:";
            // 
            // label_false
            // 
            this.label_false.AutoSize = true;
            this.label_false.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_false.Location = new System.Drawing.Point(14, 336);
            this.label_false.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_false.Name = "label_false";
            this.label_false.Size = new System.Drawing.Size(92, 36);
            this.label_false.TabIndex = 1;
            this.label_false.Text = "False:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(14, 447);
            this.label_time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(89, 36);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "Time:";
            // 
            // picture_teacher
            // 
            this.picture_teacher.Image = ((System.Drawing.Image)(resources.GetObject("picture_teacher.Image")));
            this.picture_teacher.Location = new System.Drawing.Point(20, 14);
            this.picture_teacher.Margin = new System.Windows.Forms.Padding(5);
            this.picture_teacher.Name = "picture_teacher";
            this.picture_teacher.Size = new System.Drawing.Size(233, 229);
            this.picture_teacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_teacher.TabIndex = 4;
            this.picture_teacher.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "Congratulations";
            // 
            // lv_ShowResult
            // 
            this.lv_ShowResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_stt,
            this.cl_word,
            this.cl_status});
            this.lv_ShowResult.Location = new System.Drawing.Point(285, 102);
            this.lv_ShowResult.Name = "lv_ShowResult";
            this.lv_ShowResult.Size = new System.Drawing.Size(563, 435);
            this.lv_ShowResult.TabIndex = 7;
            this.lv_ShowResult.UseCompatibleStateImageBehavior = false;
            this.lv_ShowResult.View = System.Windows.Forms.View.Details;
            this.lv_ShowResult.DoubleClick += new System.EventHandler(this.lv_ShowResult_DoubleClick);
            // 
            // cl_stt
            // 
            this.cl_stt.Text = "STT";
            this.cl_stt.Width = 135;
            // 
            // cl_word
            // 
            this.cl_word.Text = "Word";
            this.cl_word.Width = 219;
            // 
            // cl_status
            // 
            this.cl_status.Text = "True/False";
            this.cl_status.Width = 288;
            // 
            // ResultTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 549);
            this.Controls.Add(this.lv_ShowResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picture_teacher);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_false);
            this.Controls.Add(this.label_true);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ResultTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultTest";
            this.Load += new System.EventHandler(this.ResultTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_true;
        private System.Windows.Forms.Label label_false;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox picture_teacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_ShowResult;
        private System.Windows.Forms.ColumnHeader cl_stt;
        private System.Windows.Forms.ColumnHeader cl_word;
        private System.Windows.Forms.ColumnHeader cl_status;
    }
}