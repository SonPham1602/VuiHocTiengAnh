namespace Bai2
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lb_nameUnit = new System.Windows.Forms.Label();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            this.pb_addUnit = new System.Windows.Forms.PictureBox();
            this.pb_editUnit = new System.Windows.Forms.PictureBox();
            this.pb_deleteUnit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageActive = null;
            this.btn_add.Location = new System.Drawing.Point(1068, 681);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(50, 50);
            this.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add.TabIndex = 3;
            this.btn_add.TabStop = false;
            this.btn_add.Zoom = 10;
            this.btn_add.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.White;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid.Location = new System.Drawing.Point(12, 53);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1106, 611);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            // 
            // lb_nameUnit
            // 
            this.lb_nameUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_nameUnit.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_nameUnit.ForeColor = System.Drawing.Color.DimGray;
            this.lb_nameUnit.Location = new System.Drawing.Point(324, 9);
            this.lb_nameUnit.Name = "lb_nameUnit";
            this.lb_nameUnit.Size = new System.Drawing.Size(521, 31);
            this.lb_nameUnit.TabIndex = 10;
            this.lb_nameUnit.Text = "text";
            this.lb_nameUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_unit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.ItemHeight = 20;
            this.comboBox_unit.Location = new System.Drawing.Point(12, 12);
            this.comboBox_unit.MaxDropDownItems = 10;
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(232, 28);
            this.comboBox_unit.TabIndex = 11;
            this.comboBox_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox_unit_SelectedIndexChanged);
            // 
            // pb_addUnit
            // 
            this.pb_addUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_addUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addUnit.Image = ((System.Drawing.Image)(resources.GetObject("pb_addUnit.Image")));
            this.pb_addUnit.Location = new System.Drawing.Point(23, 670);
            this.pb_addUnit.Name = "pb_addUnit";
            this.pb_addUnit.Size = new System.Drawing.Size(64, 64);
            this.pb_addUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_addUnit.TabIndex = 12;
            this.pb_addUnit.TabStop = false;
            this.pb_addUnit.Click += new System.EventHandler(this.pb_addUnit_Click);
            // 
            // pb_editUnit
            // 
            this.pb_editUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_editUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_editUnit.Image = ((System.Drawing.Image)(resources.GetObject("pb_editUnit.Image")));
            this.pb_editUnit.Location = new System.Drawing.Point(112, 670);
            this.pb_editUnit.Name = "pb_editUnit";
            this.pb_editUnit.Size = new System.Drawing.Size(64, 64);
            this.pb_editUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_editUnit.TabIndex = 13;
            this.pb_editUnit.TabStop = false;
            this.pb_editUnit.Click += new System.EventHandler(this.pb_editUnit_Click);
            // 
            // pb_deleteUnit
            // 
            this.pb_deleteUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_deleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_deleteUnit.Image = ((System.Drawing.Image)(resources.GetObject("pb_deleteUnit.Image")));
            this.pb_deleteUnit.Location = new System.Drawing.Point(207, 670);
            this.pb_deleteUnit.Name = "pb_deleteUnit";
            this.pb_deleteUnit.Size = new System.Drawing.Size(64, 64);
            this.pb_deleteUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_deleteUnit.TabIndex = 14;
            this.pb_deleteUnit.TabStop = false;
            this.pb_deleteUnit.Click += new System.EventHandler(this.pb_deleteUnit_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 755);
            this.Controls.Add(this.pb_deleteUnit);
            this.Controls.Add(this.pb_editUnit);
            this.Controls.Add(this.pb_addUnit);
            this.Controls.Add(this.comboBox_unit);
            this.Controls.Add(this.lb_nameUnit);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_deleteUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private System.Windows.Forms.Label lb_nameUnit;
        private System.Windows.Forms.ComboBox comboBox_unit;
        private System.Windows.Forms.PictureBox pb_addUnit;
        private System.Windows.Forms.PictureBox pb_editUnit;
        private System.Windows.Forms.PictureBox pb_deleteUnit;
    }
}