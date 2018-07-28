using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account_bank;


namespace BuissnessLogic
{
    public class Accounts
    {
        public int acccountId;
        public int CustName;
        public int Balance;
        public int Acc_Type;



        public static void deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit:");
            int amt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account id: ");
            int account_id = int.Parse(Console.ReadLine());
            int bal= Class1.search(account_id);
            if (bal != -100000000)
            {
                bal = bal + amt;
                Class1.Update(bal,account_id);
            }
            else
            {
                Console.WriteLine("The account does not exists.");
            }


            
        }

        public static void Add_account()
        {
            Console.WriteLine("Enter Account id: ");
            int acc_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the account type:");
            string acc_type = Console.ReadLine();
            Class1.insert(acc_id,name,acc_type,0);
        }

        public static void withdraw()
        {
            Console.WriteLine("Enter the Account id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account type: 1-saving 2-current 3-Dmat");
            string acc_type = Console.ReadLine();
            Console.WriteLine("Enter the amount you want to withdraw: ");
            int amt = int.Parse(Console.ReadLine());
            int bal = Class1.search(id);
            string type_account= Class1.search_acc_type(id);
            if (bal != -100000000)
            {
                if (type_account == "current" && bal == 0)
                {
                    Console.WriteLine("Not enough Balance");
                }
                else if (type_account == "saving" && bal == 50)
                {
                    Console.WriteLine("Not enough balance");
                }
                else if (type_account == "Dmat" && bal == (-10000))
                {
                    Console.WriteLine("Not enough balance");
                }
                else
                {
                    bal = bal - amt;
                    if (bal < 50 && type_account == "saving")
                    {
                        Console.WriteLine("Cant withdraw amount. min balance Rs 50.");
                    }
                    else if (bal < (-10000) && type_account == "Dmat")
                    {
                        Console.WriteLine("Cant withdraw amount. min balance -10000");
                    }
                    else
                    {
                        Class1.Update(bal, id);
                    }
                }
            }
            else
            {
                Console.WriteLine("The account_id does not exists.");
            }
            
        }

        public static void interest()
        {
            Console.WriteLine("Enter the account id whose interest you want to calculate: ");
            int id = int.Parse(Console.ReadLine());
            int balance= Class1.search(id);
            string type_account = Class1.search_acc_type(id);
            if (balance != (-100000000))
            {
                if (type_account == "current")
                {
                    double interest = (0.01 * balance);
                    Console.WriteLine("The interest is: "+interest);
                }
                else
                {
                    double interest = (0.04 * balance);
                    Console.WriteLine("The interest is: "+interest);
                }
            }
            else
            {
                Console.WriteLine("The account does not exists.");
            }

            
        }

    }
}
