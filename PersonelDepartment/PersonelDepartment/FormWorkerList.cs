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
    public partial class FormWorkerList : Form
    {
        public FormWorkerList()
        {
            InitializeComponent();
        }


        private void FormWorkerList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_departmentDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.personnel_departmentDataSet.Sotrudnik);

        }

        private static FormWorkerList f;

        public static FormWorkerList fw {
            get { if (f == null || f.IsDisposed) f = new FormWorkerList(); return f; } }

        public void ShowForm() { Show(); Activate(); }

        private void sotrudnikBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_departmentDataSet);

        }

        string fileImage = "";
        private void buttonOpenPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK) {
                fileImage = openFileDialogPhoto.FileName;
                photoPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName); }
            else fileImage = "";
        }
    }
}
