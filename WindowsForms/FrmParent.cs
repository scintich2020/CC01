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
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmStudentList form = new FrmStudentList();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmSchoolList form = new FrmSchoolList();
            form.MdiParent = this;
            form.Show();
        }
    }
}
