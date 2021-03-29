using System;
using System.Collections.Generic;
using System.Text;

namespace tp_2
{
    class comptecourt:Compte
    {
        public comptecourt(MAD dec,MAD mbox,Client cl)
            : base( mbox,ref cl)
        {
            
                
        }

        public override bool Debiter(MAD sum)
    
        {
           
               
                if (this.Solde - sum > dec)
                    {

                    return false;

                }

                return true;



          }

        static MAD dec=new MAD(100);

    }
}
