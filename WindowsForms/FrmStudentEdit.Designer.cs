﻿namespace WindowsForms
{
    partial class FrmStudentEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtDateNaisssance = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(327, 294);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(279, 29);
            this.txtContact.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(323, 264);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(73, 24);
            this.lblContact.TabIndex = 57;
            this.lblContact.Text = "Contact";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(531, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(519, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 79);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(327, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 79);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(323, 43);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(59, 24);
            this.lblPhoto.TabIndex = 7;
            this.lblPhoto.Text = "Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(327, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 176);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Click to browser");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtMatricule
            // 
            this.txtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricule.Location = new System.Drawing.Point(12, 47);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(279, 29);
            this.txtMatricule.TabIndex = 0;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(8, 20);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(86, 24);
            this.lblMatricule.TabIndex = 50;
            this.lblMatricule.Text = "Matricule";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(12, 118);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(279, 29);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(10, 91);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 24);
            this.lblNom.TabIndex = 48;
            this.lblNom.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(12, 190);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(279, 29);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(8, 163);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(77, 24);
            this.lblPrenom.TabIndex = 46;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtDateNaisssance
            // 
            this.txtDateNaisssance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateNaisssance.Location = new System.Drawing.Point(12, 261);
            this.txtDateNaisssance.Name = "txtDateNaisssance";
            this.txtDateNaisssance.Size = new System.Drawing.Size(279, 29);
            this.txtDateNaisssance.TabIndex = 3;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.Location = new System.Drawing.Point(8, 234);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(165, 24);
            this.lblDateNaissance.TabIndex = 44;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // txtLieu
            // 
            this.txtLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieu.Location = new System.Drawing.Point(14, 339);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(279, 29);
            this.txtLieu.TabIndex = 4;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(10, 312);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(163, 24);
            this.lblLieu.TabIndex = 42;
            this.lblLieu.Text = "Lieu de naissance";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(14, 411);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 387);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(568, 226);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(43, 20);
            this.lblText.TabIndex = 61;
            this.lblText.Text = "Text:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(617, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(617, 220);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(193, 26);
            this.txtText.TabIndex = 59;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(730, 264);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 36);
            this.btnGenerate.TabIndex = 58;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmStudentEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtDateNaisssance);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "FrmStudentEdit";
            this.Text = "Student Edit";
            this.Load += new System.EventHandler(this.FrmStudentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtDateNaisssance;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnGenerate;
    }
}