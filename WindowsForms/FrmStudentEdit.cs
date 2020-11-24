using System;
using CC01.BO;
using CC01.BLL;
using System.IO;
using System.Configuration;
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
    public partial class FrmStudentEdit : Form
    {
        private Action callBack;
        private Student oldStudent;
        public FrmStudentEdit()
        {
            InitializeComponent();
        }


        public FrmStudentEdit(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmStudentEdit(Student student, Action callBack) : this(callBack)
        {
            this.oldStudent = student;
            txtMatricule.Text = student.Matricule;
            txtNom.Text = student.Nom;
            txtPrenom.Text = student.Prenom;
            txtDateNaisssance.Text = student.DateNaissance.ToString();
            txtLieu.Text = student.LieuNaissance;
            txtEmail.Text = student.Email;
            txtContact.Text = student.Contact;
            if (student.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(student.Photo));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Student newStudent = new Student
                (
                    txtMatricule.Text.ToUpper(),
                    txtNom.Text,
                    txtPrenom.Text,
                    DateTime.Parse(txtDateNaisssance.Text),
                    txtLieu.Text,
                    txtEmail.Text,
                    txtContact.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldStudent?.Photo
                );

                StudentBLO studentBLO = new StudentBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldStudent == null)
                    studentBLO.CreateStudent(newStudent);
                else
                    studentBLO.EditStudent(oldStudent, newStudent);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldStudent != null)
                    Close();

                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtDateNaisssance.Clear();
                txtLieu.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtMatricule.Focus();

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
            txtMatricule.BackColor = Color.White;
            txtNom.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtMatricule.Text))
            {
                text += "- Please enter the reference ! \n";
                txtMatricule.BackColor = Color.Pink;
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                checkForm();

                Student newStudent = new Student
                (
                    txtMatricule.Text.ToUpper(),
                    txtNom.Text,
                    txtPrenom.Text,
                    DateTime.Parse(txtDateNaisssance.Text),
                    txtLieu.Text,
                    txtEmail.Text,
                    txtContact.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldStudent?.Photo
                );

                StudentBLO studentBLO = new StudentBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldStudent == null)
                    studentBLO.CreateStudent(newStudent);
                else
                    studentBLO.EditStudent(oldStudent, newStudent);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldStudent != null)
                    Close();

                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtDateNaisssance.Clear();
                txtLieu.Clear();
                txtEmail.Clear();
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStudentEdit_Load(object sender, EventArgs e)
        {

        }
    }
}

