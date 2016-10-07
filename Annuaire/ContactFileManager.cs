using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Annuaire
{
    class ContactFileManager
    {
        private List<String> formats = new List<string> {"txt", "csv"};
        public ContactFileManager()
        {
        }
        
        public void SaveListContacts(List<Contact> contacts)
        {
            foreach(Contact contact in contacts)
            {
                this.SaveContact(contact);
            }
        }
    
        public void SaveContact(Contact contact, String format)
        {
            foreach (String extension in formats)
            {
                if(format == extension)
                {
                    if(format == "csv")
                    {
                        StreamWriter write = new StreamWriter("Contact." + format, true);
                        String data;
                        data = contact.Nom + ";" + contact.Prenom + ";" + contact.Tel + ";" + contact.Mail;
                        write.WriteLine(data);
                        write.Close();
                    }
                    if(format == "txt")
                    {
                        this.SaveContact(contact);
                    }
                }
            }
        }

        public void SaveContact(Contact contact)
        {
            StreamWriter write = new StreamWriter("Contact.txt", true);
            String data;
            String nom = this.IncrementChaine(contact.Nom);
            String prenom = this.IncrementChaine(contact.Prenom);
            String tel = this.IncrementChaine(contact.Tel);
            String mail = this.IncrementChaine(contact.Mail);
            data = nom + prenom +  tel + mail;
            write.WriteLine(data);
            write.Close();
        }

        private String IncrementChaine(String chaine)
        {
            int chaineCompte = chaine.Count();
            while (chaineCompte < 50)
            {
                chaine += " ";
                chaineCompte = chaine.Count();
            }
            return chaine;
        }
    }
}
