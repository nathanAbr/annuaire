using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Contact
    {
        private String nom;
        private String prenom;
        private String mail;
        private String tel;

        public Contact(String nom, String prenom, String tel, String mail)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }

        public String Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public String Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public String Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public String Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }

        public new String ToString()
        {
            String retour = this.nom + " " + this.prenom + "\n    tel : " + this.tel + "\n    mail: " + this.mail;
            return retour;
        }
    }
}
