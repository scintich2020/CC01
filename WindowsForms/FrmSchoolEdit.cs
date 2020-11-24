using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmSchoolEdit : Form
    {
        private Action callBack;
        private School oldSchool;
        public FrmSchoolEdit()
        {
            InitializeComponent();
        }
        public FrmSchoolEdit(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmSchoolEdit(School school, Action callBack) : this(callBack)
        {
            this.oldSchool = school;
            txtNom.Text = school.Nom;
            txtEmail.Text = school.Email;
            txtTel.Text = school.Tel.ToString();
            txtContact.Text = school.Contact;
            if (school.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(school.Photo));

        }
        private void FrmSchoolEdit_Load(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                School newSchool = new School
                (
                txtNom.Text,
                txtEmail.Text,
                int.Parse(txtTel.Text),
                txtContact.Text,
                !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldSchool?.Photo
                );

                SchoolBLO schoolBLO = new SchoolBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldSchool == null)
                    schoolBLO.CreateSchool(newSchool);
                else
                    schoolBLO.EditSchool(oldSchool, newSchool);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldSchool != null)
                    Close();

                txtNom.Clear();
                txtEmail.Clear();
                txtTel.Clear();
                txtContact.Clear();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        private void checkForm()
        {
            string text = string.Empty;
            txtNom.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                text += "- Please enter the reference ! \n";
                txtNom.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                text += "- Please enter the name ! \n";
                txtNom.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }
    }
}
