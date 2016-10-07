using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Etudiant : Contact
    {
        private String cursus;
        public Etudiant(String nom, String prenom, String tel, String mail, String cursus) : base(nom, prenom, tel, mail)
        {
            this.cursus = cursus;
        }

        public String Cursus
        {
            get
            {
                return this.cursus;
            }
            set
            {
                this.cursus = value;
            }
        }
    }
}
