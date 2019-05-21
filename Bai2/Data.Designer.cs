﻿namespace Bai2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_editUnit = new System.Windows.Forms.Button();
            this.btn_addUnit = new System.Windows.Forms.Button();
            this.btn_deleteUnit = new System.Windows.Forms.Button();
            this.lb_nameUnit = new System.Windows.Forms.Label();
            this.comboBox_unit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // btn_editUnit
            // 
            this.btn_editUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editUnit.Location = new System.Drawing.Point(141, 686);
            this.btn_editUnit.Name = "btn_editUnit";
            this.btn_editUnit.Size = new System.Drawing.Size(103, 45);
            this.btn_editUnit.TabIndex = 7;
            this.btn_editUnit.Text = "Edit Unit";
            this.btn_editUnit.UseVisualStyleBackColor = true;
            // 
            // btn_addUnit
            // 
            this.btn_addUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addUnit.Location = new System.Drawing.Point(12, 686);
            this.btn_addUnit.Name = "btn_addUnit";
            this.btn_addUnit.Size = new System.Drawing.Size(103, 45);
            this.btn_addUnit.TabIndex = 8;
            this.btn_addUnit.Text = "Add Unit";
            this.btn_addUnit.UseVisualStyleBackColor = true;
            this.btn_addUnit.Click += new System.EventHandler(this.btn_addUnit_Click);
            // 
            // btn_deleteUnit
            // 
            this.btn_deleteUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteUnit.Location = new System.Drawing.Point(265, 686);
            this.btn_deleteUnit.Name = "btn_deleteUnit";
            this.btn_deleteUnit.Size = new System.Drawing.Size(103, 45);
            this.btn_deleteUnit.TabIndex = 9;
            this.btn_deleteUnit.Text = "Delete Unit";
            this.btn_deleteUnit.UseVisualStyleBackColor = true;
            // 
            // lb_nameUnit
            // 
            this.lb_nameUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_nameUnit.AutoSize = true;
            this.lb_nameUnit.Font = new System.Drawing.Font("Circle", 14.25F, System.Drawing.FontStyle.Italic);
            this.lb_nameUnit.ForeColor = System.Drawing.Color.DimGray;
            this.lb_nameUnit.Location = new System.Drawing.Point(546, 9);
            this.lb_nameUnit.Name = "lb_nameUnit";
            this.lb_nameUnit.Size = new System.Drawing.Size(58, 31);
            this.lb_nameUnit.TabIndex = 10;
            this.lb_nameUnit.Text = "text";
            // 
            // comboBox_unit
            // 
            this.comboBox_unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_unit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_unit.FormattingEnabled = true;
            this.comboBox_unit.ItemHeight = 20;
            this.comboBox_unit.Items.AddRange(new object[] {
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
            "Unit 44 At the airport"});
            this.comboBox_unit.Location = new System.Drawing.Point(12, 12);
            this.comboBox_unit.MaxDropDownItems = 10;
            this.comboBox_unit.Name = "comboBox_unit";
            this.comboBox_unit.Size = new System.Drawing.Size(232, 28);
            this.comboBox_unit.TabIndex = 11;
            this.comboBox_unit.SelectedIndexChanged += new System.EventHandler(this.comboBox_unit_SelectedIndexChanged);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1130, 755);
            this.Controls.Add(this.comboBox_unit);
            this.Controls.Add(this.lb_nameUnit);
            this.Controls.Add(this.btn_deleteUnit);
            this.Controls.Add(this.btn_addUnit);
            this.Controls.Add(this.btn_editUnit);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private System.Windows.Forms.Button btn_editUnit;
        private System.Windows.Forms.Button btn_addUnit;
        private System.Windows.Forms.Button btn_deleteUnit;
        private System.Windows.Forms.Label lb_nameUnit;
        private System.Windows.Forms.ComboBox comboBox_unit;
    }
}