using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var students = students.GetBy
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
        private void Form1_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void lblPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmStudentList(loadData);
            f.Show();
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
                    Form f = new FrmStudentEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Student,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<FrmStudentList> items = new List<FrmStudentList>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Student s = dataGridView1.Rows[i].DataBoundItem as Student;
                items.Add
                (
                   new StudentPrintList
                   (
                       s.Reference,
                       s.Name,
                       s.UnitPrice,
                       s.Picture

                    )
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        studentBLO.DeleteProduct(dataGridView1.SelectedRows[i].DataBoundItem as Student);
                    }
                    loadData();
                }
            }
        }
    }

}
