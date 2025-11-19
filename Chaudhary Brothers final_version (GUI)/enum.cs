using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaudhary_Brothers
{
    internal class @enum
    {
        public static bool cashier;
        public static bool owner;
   
       public void setcashier()
        {
            cashier = true;
            owner = false;
        }
       public  void setowner()
        {
            owner = true;
            cashier = false;
        }
        public bool check()
        {
            if (owner == false)
            {
                return false;
            }
            return true;
        }
        public void end()
        {
            owner = false;
            cashier = false;
        }
    }
   

    

}
