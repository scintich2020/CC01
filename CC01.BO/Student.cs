using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Student
    {
        public string matricule;

        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public byte[] Photo { get; set; }

        public Student()
        {

        }

        public Student(string matricule, string nom, string prenom, DateTime dateNaissance, 
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

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Matricule == student.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }

        public void Add(Student students)
        {
            throw new NotImplementedException();
        }
    }
}
