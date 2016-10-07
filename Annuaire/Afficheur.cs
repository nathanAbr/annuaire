using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annuaire
{
    class Afficheur
    {
        private DataGet data = new DataGet();
        public void AfficherListContact(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine("=================================================================");
                Console.WriteLine(contact.ToString());
                Console.WriteLine("=================================================================");
            }
        }

        public void AfficherContact(Contact contacts)
        {
            Console.WriteLine("=================================================================");
            Console.WriteLine("=================================================================");
            Console.WriteLine(contacts.ToString());
            Console.WriteLine("=================================================================");
            Console.WriteLine("=================================================================");
        }

        public void AfficherListContact(List<Contact> contacts, bool save)
        {
            Console.WriteLine("===================================================\n                .CSV\n===================================================/n");
            foreach (Contact contactcsv in data.GenererCSV())
            {
                Console.WriteLine(contactcsv.ToString());
            }
            
            Console.WriteLine("\n\n===================================================\n                .TXT\n===================================================/n");
            foreach (Contact contacttxt in data.GenererTXT())
            {
                Console.WriteLine(contacttxt.ToString());
            }
        }
    }
}
