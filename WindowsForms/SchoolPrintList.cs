using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class SchoolPrintList
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public string Contact { get; set; }
        public byte[] Photo { get; set; }

        public SchoolPrintList(string nom, string email, int tel, string contact, byte[] photo)
        {
            Nom = nom;
            Email = email;
            Tel = tel;
            Contact = contact;
            Photo = photo;
        }
    }
}
