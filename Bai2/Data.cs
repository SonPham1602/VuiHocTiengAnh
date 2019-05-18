using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Data : Form
    {
        Dictionary dic;
        public Data()
        {
            InitializeComponent();
            
        }
        private void DeleteAllRow()
        {
            do
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    try
                    {
                        dataGrid.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGrid.Rows.Count >= 1);
        }
        private void InitDataGridView()
        {
          
            dataGrid.ColumnCount = 2;
            dataGrid.Columns[0].HeaderText = "STT";
            dataGrid.Columns[1].HeaderText = "Word";
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Photo";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGrid.Columns.Add(imgCol);
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.RowTemplate.Height = 250;
        }
        private void FillData(int numberUnit){

            lb_nameUnit.Text = dic.GetNameOfUnitByNumber(numberUnit);
            int s = 0;
            int e = 0;
            dic.getStartEndUnit(ref s, ref e, numberUnit);
            int temp = 1;// bien dem
            for (int i = s; i <=e; i++)
            {
                Image img = dic.getImageWordByNumber(i);             
                Object[] row = new Object[] { temp,dic.GetMeanWord(i),img};
                dataGrid.Rows.Add(row);
                temp++;

            }
            foreach (DataGridViewColumn c in dataGrid.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Circle", 30F, GraphicsUnit.Pixel);
                c.DefaultCellStyle = new DataGridViewCellStyle(c.DefaultCellStyle);
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddDataForm a = new AddDataForm();
            a.ShowDialog();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            dic = new Dictionary();
            InitDataGridView();
            FillData(1);

        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteAllRow();
            FillData(this.comboBox_unit.SelectedIndex + 1);
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                EditWordInUnitForm edit = new EditWordInUnitForm(e.RowIndex);
                edit.ShowDialog();

            }
        }

        private void btn_addUnit_Click(object sender, EventArgs e)
        {
            AddNewUnitForm add = new AddNewUnitForm();
            add.ShowDialog();
        }
    }
}
