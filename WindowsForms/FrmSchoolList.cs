using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmSchoolList : Form
    {
        private StudentBLO studentBLO;
        private SchoolBLO schoolBLO;
        public FrmSchoolList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            schoolBLO = new SchoolBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var students = studentBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.Nom.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
            lblCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmSchoolEdit(loadData);
            f.Show();
        }

        private void FrmSchoolList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmSchoolEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as School,
                        loadData
                    );
                    f.ShowDialog();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this product(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        studentBLO.DeleteSchool(dataGridView1.SelectedRows[i].DataBoundItem as School);
                    }
                    loadData();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<SchoolPrintList> items = new List<SchoolPrintList>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                School s = dataGridView1.Rows[i].DataBoundItem as School;
                items.Add
                (
                   new SchoolPrintList
                   (
                      s.Nom,
                      s.Email,
                      s.Tel,
                      s.Contact,
                      s.Photo
                    )
                );
            }
        }
    }
}
