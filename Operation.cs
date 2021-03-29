using System;
using System.Collections.Generic;
using System.Text;

namespace tp_2
{
    class Operation
    {
        private int numOperation;
        private DateTime dateOper;
        private MAD montant;
        public Operation(int num,DateTime dat,MAD mon)
        {
            this.numOperation = num;
            this.dateOper = dat;
            this.montant = mon;
        }

        public void Afficher()
        {
            Console.WriteLine(this.numOperation + " - " + this.dateOper + " - " + this.montant);
        }
    }
}
