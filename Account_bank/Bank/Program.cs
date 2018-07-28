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
            try
            {
                Class1 c1 = new Class1();
                c1.initial_connection();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int option = 0;
            int decide = 1;




            while (decide == 1)
            {
                Console.WriteLine("Enter which operation You want to perform: 1: Add_account 2: Deposit 3.Withdrawal 4. Calculate interest remaining: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Accounts.Add_account();
                        break;

                    case 2:
                        
                        
                       
                        Accounts.deposit();
                        break;

                   case 3:
                        Accounts.withdraw();
                        break;

                   case 4:
                        Accounts.interest();

                        break;

              }

               Console.WriteLine("Do you want to continue: 1: Yes 2: No");
               decide = int.Parse(Console.ReadLine());
            }





            Console.ReadKey();



        }
    }
}
