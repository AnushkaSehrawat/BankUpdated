using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public  interface Idatabase
    {
        void Add_account();
        void deposit();
        void withdraw();
        void interest();
        void Display();

    }
}
