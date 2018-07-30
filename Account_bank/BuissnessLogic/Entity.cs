using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLogic
{
    class Entity
    {
       public static AccEntities account_database = new AccEntities();
   

        public void Add_account()
        {
            Console.WriteLine("Enter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter account id: ");
            int acc_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter account type: ");
            string acc_type = Console.ReadLine();
            var data = new ACCOUNT
            {
                account_id = acc_id,
                acc_type = acc_type,
                cust_name = name,
            };
            account_database.ACCOUNTs.Add(data);
             
            
        }

        public void deposit()
        {
            Console.WriteLine("Enter the account id : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount you want to deposit: ");
            int amount = int.Parse(Console.ReadLine());
            int bal = account_database.ACCOUNTs.Find(id).balance;
            bal += amount;
            var obj = new ACCOUNT
            {
                balance = bal,
            };
            account_database.ACCOUNTs.Add(obj);
        }

        public void withdraw()
        {
            Console.WriteLine("Enter the account id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account type:");
            string acc_type = Console.ReadLine();
            Console.WriteLine("Enter the amount you want to withdraw:");
            int amount = int.Parse(Console.ReadLine());
            int bal = account_database.ACCOUNTs.Find(id).balance;
            string AccountType = account_database.ACCOUNTs.Find(id).acc_type;
            if(AccountType=="saving" && bal == 1000)
            {
                Console.WriteLine("Not Enough Balance");
            }
            else if(AccountType=="current" && bal == 0)
            {
                Console.WriteLine("Not Enough Blanace");
            }
            else if (AccountType=="Dmat" && bal == (-10000))
            {
                Console.WriteLine("Not Enough Balance");
            }
            else
            {
                bal = bal - amount;
                if(AccountType=="saving" && bal < 1000)
                {
                    Console.WriteLine("Cannot withdraw amount.Minimum balance of Rs 1000 required.");
                }
                else if(AccountType=="Dmat" && bal < (-10000))
                {
                    Console.WriteLine("Cannot withdraw amount.Minimum balance of -10000 required.");
                }
                else
                {
                    var obj = new ACCOUNT
                    {
                        balance = bal,
                    };
                    account_database.ACCOUNTs.Add(obj);
                }
            }

        }

        public void interest()
        {
            Console.WriteLine("Enter the account id whose interest you want to calculate: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account type: ");
            string acc_type = Console.ReadLine();
            string AccountType = account_database.ACCOUNTs.Find(id).acc_type;
            double bal = account_database.ACCOUNTs.Find(id).balance;
            if (AccountType == "saving")
            {
                bal = 0.04 * bal;
                Console.WriteLine("The interest calculated is: "+bal);
            }
            else
            {
                bal = 0.01 * bal;
                Console.WriteLine("The interest calculated is: "+bal);
            }

        }

        public void Display()
        {
            Console.WriteLine("Enter the account id whose details you want to display: ");
            int id = int.Parse(Console.ReadLine());
            List<ACCOUNT> details_list = new List<ACCOUNT>();
            details_list = account_database.ACCOUNTs.ToList();
            foreach(ACCOUNT acc in details_list)
            {
                if (id == Convert.ToInt32(acc.account_id))
                {
                    Console.WriteLine("Id: "+acc.account_id+"\n Name: "+acc.cust_name+"\n Balance: "+acc.balance+"\n Account type: "+acc.acc_type);

                }
            }
            

        }                                                  
    }
}
