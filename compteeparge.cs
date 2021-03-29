using System;
using System.Collections.Generic;
using System.Text;

namespace tp_2
{
    class compteeparge : Compte
    {
        public compteeparge(double taux, MAD mbox, Client cl)
            :base(mbox,ref cl)
        {
            
            Console.WriteLine("entre un taux");
            double x = Convert.ToDouble(Console.ReadLine());
            while (x < 0  || x > 100)
            {

                Console.WriteLine("entre un taux valide ");
                 x = Convert.ToDouble(Console.ReadLine());
              
            }
            this.taux = x;

        }

        public MAD calculeIntere()
        {
          
            MAD inte = new MAD(this.taux/100);
            this.Solde += this.Solde * inte;
           


            return this.Solde;

        }



        private double taux;
    }
}
