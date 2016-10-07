using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Enseignant : Contact
    {
        private String matiere;
        public Enseignant(String nom, String prenom, String tel, String mail, String matiere) : base(nom, prenom, tel, mail)
        {
            this.matiere = matiere;
        }

        public String Matiere
        {
            get
            {
                return this.matiere;
            }
            set
            {
                this.matiere = value;
            }
        }
    }
}
