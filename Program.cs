using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Robi", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}$.");

            account.MakeWithdrawl(120, DateTime.Now, "Hammok");
            account.MakeWithdrawl(50, DateTime.Now, "Xbox Game");

            Console.WriteLine(account.GetAccountHistory());


            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance!");
            //    Console.WriteLine(e.ToString());
            //}

            
        }
    }
}
