using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
   public class StudentPrintList
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public byte[] Photo { get; set; }

        public StudentPrintList(string matricule, string nom, string prenom, string email, string contact, byte[] photo)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Contact = contact;
            Photo = photo;
        }
    }
}
