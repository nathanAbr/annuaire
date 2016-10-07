using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool ok = true;
            while (ok)
            {
                String var = menu.MenuPrincipal();
                if (var == "AJOUTER")
                {
                    menu.SousMenuAdd();
                }
                if (var == "LISTER")
                {
                    Console.WriteLine("Souhaitez vous afficher la liste des contacts enregistrer ? (OUI | NON) ");
                    String save = Console.ReadLine();
                    if(save == "oui")
                    {
                        menu.SousMenuList(true);
                    }
                    else { menu.SousMenuList(false); }
                    
                }
                if (var == "RECHERCHER")
                {
                    menu.SousMenuRechercher();
                }
                if (menu.Continuer())
                {
                    ok = false;
                }
            }
        }
    }
}
