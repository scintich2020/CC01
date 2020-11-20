using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class StudentPrintList
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public byte[] Photo { get; set; }

        public StudentPrintList(string matricule, string nom, string prenom, DateTime dateNaissance,
            string lieuNaissance, string email, string contact, byte[] photo)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            LieuNaissance = lieuNaissance;
            Email = email;
            Contact = contact;
            Photo = photo;
        }
    }
}
