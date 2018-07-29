using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account_bank;
using BuissnessLogic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int option = 0;
            int decide = 1;




            while (decide == 1)
            {
                Console.WriteLine("Enter which operation You want to perform: 1: Add_account 2: Deposit 3.Withdrawal 4. Calculate interest remaining: 5.Display Account Details ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Accounts a1 = new Accounts();
                       a1.Add_account();
                        break;

                    case 2:



                        Accounts a2 = new Accounts();
                       a2.deposit();
                        break;

                   case 3:

                        Accounts a3 = new Accounts();
                       a3.withdraw();
                        break;

                   case 4:

                        Accounts a4 = new Accounts();
                        a4.interest();

                        break;
                    case 5:
                        Class1 c = new Class1();
                        c.Display();
                        break;

              }

               Console.WriteLine("Do you want to continue: 1: Yes 2: No");
               decide = int.Parse(Console.ReadLine());
            }
            





            Console.ReadKey();



        }
    }
}
