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
                Console.WriteLine("Enter for framework : 1 for ADO.net  2 for Entity Framework ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter which operation You want to perform: 1: Add_account 2: Deposit 3.Withdrawal 4. Calculate interest remaining: 5.Display Account Details ");
                option = int.Parse(Console.ReadLine());
                if(choice==1)
                {
                    Accounts a1 = new Accounts();
                    switch (option)
                    {
                        case 1:
                            a1.Add_account();
                            break;

                        case 2:
                            
                            a1.deposit();
                            break;

                        case 3:
                             a1.withdraw();
                             break;

                        case 4:
                              a1.interest();
                            break;
                        case 5:
                            Class1 c = new Class1();
                            c.Display();
                            break;

                    }

                    Console.WriteLine("Do you want to continue: 1: Yes 2: No");
                    decide = int.Parse(Console.ReadLine());
                }
                else if (choice ==2 )
                {
                     Entity a1 = new Entity();
                    switch (option)
                    {
                        case 1:
                            a1.Add_account();
                            break;

                        case 2:

                          a1.deposit();
                            break;

                        case 3:

                            a1.withdraw();
                            break;

                        case 4:

                            a1.interest();

                            break;
                        case 5:
                            
                            a1.Display();
                            break;

                    }

                    Console.WriteLine("Do you want to continue: 1: Yes 2: No");
                    decide = int.Parse(Console.ReadLine());
                }

            }
            
 
            Console.ReadKey();



        }
    }
}
