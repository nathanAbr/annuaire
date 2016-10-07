using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class ContactManager
    {
        private List<Contact> contacts;
        private Afficheur view;
        private ContactFileManager file;

        public ContactManager()
        {
            contacts = new List<Contact>();
            view = new Afficheur();
            file = new ContactFileManager();
        }

        public void AddContact(String nom, String prenom, String tel, String mail)
        {
            Contact contact = new Contact(nom, prenom, tel, mail);
            this.contacts.Add(new Contact(nom, prenom, tel, mail));
            Console.WriteLine("Souhaitez vous enregistrer le contact sur un fichier externe ?");
            String ok = Console.ReadLine();
            if(ok == "oui")
            {
                Console.WriteLine("Quel format souhaitezvous utiliser ? (txt | csv)");
                String format = Console.ReadLine();
                file.SaveContact(contact, format);
            }
        }

        public void ViewContact()
        {
            view.AfficherListContact(this.contacts);
        }

        public void ViewContact(bool save)
        {
            view.AfficherListContact(this.contacts, save);
        }

        public void RechercherContact(String keyWord)
        {
            List<Contact> listContact = this.contacts;
            String[] motCle = keyWord.Split();
            int nbChar = motCle.Count();
            int compteur = 0;
            foreach (Contact contact in listContact)
            {
                String[] motRecherhe = contact.Nom.Split();
                compteur = 0;
                for (int i = 0; i < nbChar; i++)
                {

                    if (motRecherhe[i] == motCle[i])
                    {
                        compteur++;
                    }
                }

                if ((compteur / nbChar) > 0.2f)
                {
                    view.AfficherContact(contact);
                }
            }
        }
    }
}
