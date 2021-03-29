using System;
using System.Collections.Generic;
using System.Text;

namespace tp_2
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        //private Compte[] compte_cl = new Compte[5];
        List<Compte> Comptes = new List<Compte>();
       // private int nbr_compte = 0;


        public Client(string nom, string pre, string adr)
        {
            this.nom = nom;
            this.prenom = pre;
            this.adresse = adr;
           
            
        }
        public void print()
        {
            Console.WriteLine("le nom :" + this.nom + " le prenom : " + this.prenom + " l'adresse " + this.adresse);
            for(int i = 0; i < Comptes.Count; i++)
            {
                Console.WriteLine("Compte : ");
                Comptes[i].print_info();
            }

        }
        public void ajouter_compte(Compte cm)
        {

          Comptes.Add(cm);
           
          
        }

    }
}
