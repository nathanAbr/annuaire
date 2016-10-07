using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Annuaire
{
    class DataGet
    {
        public List<Contact> GenererCSV()
        {
            StreamReader read = new StreamReader("Contact.csv");
            String ligne;
            String[] tab = new String[] { };
            String[] tabChar = new String[] { };
            List<Contact> annuaire = new List<Contact>();
            char delimiter = ';';
            while ((ligne = read.ReadLine()) != null)
            {
                tab = new String[] { ligne };
                foreach (String tableau in tab)
                {
                    tabChar = tableau.Split(delimiter);
                    annuaire.Add(new Contact(tabChar[0].ToString(), tabChar[1].ToString(), tabChar[2].ToString(), tabChar[3].ToString()));
                }
            }
            return annuaire;
        }

        public List<Contact> GenererTXT()
        {
            StreamReader read = new StreamReader("Contact.txt");
            String ligne;
            List<Contact> annuaire = new List<Contact>();
            while ((ligne = read.ReadLine()) != null)
            {
                String nom = ligne.Substring(0, 50);
                String prenom = ligne.Substring(50, 50);
                String tel = ligne.Substring(100, 50);
                String mail = ligne.Substring(150, 50);
                annuaire.Add(new Contact(nom, prenom, tel, mail));
            }
            return annuaire;
        }
    }
}
