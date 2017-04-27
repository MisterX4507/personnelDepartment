using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelDepartment.Properties;

namespace PersonelDepartment
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,БИС,Гайфуллина А.Д. и Корышев Н.П.,группа 735,2017",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkerList.fw.ShowForm();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPostList.fp.ShowForm();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
