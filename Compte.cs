using System;
using System.Collections.Generic;
using System.Text;

namespace tp_2
{
    class Compte
    {

        private readonly Int32 num_compte;
        private static Int32 cpt_campte = 0;

        private Client Titulaire;
        protected MAD Solde;
        private static readonly MAD plafond = new MAD(2000);
        // private Operation[] operation =new Operation[100];
        //private int nbr_operation = 0;
        List<Operation>  operatios= new List<Operation>();


        public Compte(MAD so, ref Client cl)
        {
            this.num_compte = ++cpt_campte;
            this.Solde = so;
            this.Titulaire = cl;
            

        }

        public void print_info()
        {
            Console.WriteLine("numero du compte : " + this.num_compte);
            Titulaire.print();
            Solde.print();
        }
        public bool crediter(MAD sum)
        {
            MAD test = new MAD(0);
            if (sum > test)
            {
                this.Solde = this.Solde + sum;
                return true;

            }
            else return false;

        }
        public virtual bool Debiter(MAD sum)
        {
            MAD test = new MAD(0);
            if (sum > test)
            {
                if (sum < Compte.plafond)
                {
                    this.Solde -= sum;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool vairement(Compte P2cr, MAD val)
        {
            return (this.Debiter(val) && P2cr.crediter(val));


        }
        public void ajouteroperation(Operation op)
        {

            operatios.Add(op);

        }
    }
}
