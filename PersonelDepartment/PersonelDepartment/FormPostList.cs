using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelDepartment
{
    public partial class FormPostList : Form
    {
        public FormPostList()
        {
            InitializeComponent();
        }

        private void dolgnostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dolgnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_departmentDataSet);

        }

        private void FormPostList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_departmentDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.personnel_departmentDataSet.Dolgnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_departmentDataSet.Dolgnost". При необходимости она может быть перемещена или удалена.
            this.dolgnostTableAdapter.Fill(this.personnel_departmentDataSet.Dolgnost);

        }

        private void struct_podrazdelenieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private static FormPostList f;

        public static FormPostList fp {
            get {
                if (f == null || f.IsDisposed)
                    f = new FormPostList();
                return f; } }

        public void ShowForm() { Show(); Activate(); }

        private void dolgnostBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dolgnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_departmentDataSet);

        }

        private void dolgnostDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value == null) || (dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value.ToString() == ""))
                e.CellStyle.BackColor = Color.LightGreen;
            else
            {
                if (dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value.ToString() == "Администрация") e.CellStyle.BackColor = Color.SkyBlue;
                else {
                    if (dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value.ToString() == "Отдел кадров")
                        e.CellStyle.BackColor = Color.Pink;
                    else {
                        if (dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value.ToString() == "Экономический отдел")
                            e.CellStyle.BackColor = Color.LightCoral;
                        else
                        {
                            if (dolgnostDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnOtdel"].Value.ToString() == "Учебный отдел")
                                e.CellStyle.BackColor = Color.Yellow;
                            else e.CellStyle.BackColor = Color.Moccasin;
                        }
                    } 
                    }
            }
        }

    }
}
