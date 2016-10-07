using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Menu
    {
        private ContactManager contactManager;
        

        public Menu()
        {
            contactManager = new ContactManager();
        }

        public String MenuPrincipal()
        {
            Console.WriteLine("Bonjour, que souhaitez vous faire ? (AJOUTER | LISTER | RECHERCHER)");
            String reponse = Console.ReadLine();
            return reponse;
        }

        public void SousMenuAdd()
        {
            Console.WriteLine("Veuillez saisir votre prénom :");
            String prenom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre nom :");
            String nom = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre numéro de téléphone :");
            String tel = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre adresse email :");
            String mail = Console.ReadLine();
            this.contactManager.AddContact(nom, prenom, tel, mail);

        }

        public void SousMenuList(bool save)
        {
            if (save)
            {
                this.contactManager.ViewContact(save);
            }
            else
            {
                this.contactManager.ViewContact();
            }
        }

        public void SousMenuRechercher()
        {
            Console.WriteLine("Taper votre mot pour la recherche :");
            String keyWord = Console.ReadLine();
            this.contactManager.RechercherContact(keyWord);
        }

        public bool Continuer()
        {
            Console.WriteLine("Souhaitez vous continuer ? (OUI | NON)");
            bool ok = false;
            String reponse = Console.ReadLine();
            if (reponse == "non")
            {
                ok = true;
            }
            return ok;
        }
        
    }
}
