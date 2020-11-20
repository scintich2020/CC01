using CC01.BLL;
using CC01.BO;
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
    public partial class FrmSchoolEdit : Form
    {
        private SchoolBLO schoolBLO;
        private School oldSchool;
        public FrmSchoolEdit()
        {
            InitializeComponent();
            schoolBLO = new SchoolBLO(ConfigurationManager.AppSettings["DbFolder"]);
            oldSchool = SchoolBLO.GetSchool();
            if (oldSchool != null)
            {
                txtNom.Text = oldSchool.Nom;
                txtEmail.Text = oldSchool.Email;
                txtTel.Text = oldSchool.Tel.ToString();
                txtContact.Text = oldSchool.Contact;
                pictureBox1.ImageLocation = oldSchool.Logo;
            }
        }

        private void FrmSchoolEdit_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
