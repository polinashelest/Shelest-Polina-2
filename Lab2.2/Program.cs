using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var client1 = new Client(7);
            Console.WriteLine("Client ID is " + client1.Id);


            var account1 = new Account(13);

            client1.Accounts.Add(account1); 
            var foundAccount = client1.GetAccountById(13); //пошук рахунку з id=13
            Console.WriteLine("Balance of account with ID = 13 is " + foundAccount.Balance);
            

            client1.Accounts.Add(new Account(6) { Balance = -5 });;
            client1.Accounts.Add(new Account(7) { Balance = 10, Blocked = true});
            client1.Accounts.Add(new Account(5, true, 15));

            var accountIds = client1.Accounts.Select(a => a.Id);
            Console.WriteLine("IDs of client's acounts: " + string.Join(", ", accountIds));

            var sortedAccounts = client1.Accounts.OrderBy(a => a.Balance);
            var s = string.Join(", ", sortedAccounts.Select(a => a.Balance));
            Console.WriteLine("Sorted accounts by balance (ascending): " + s);

            var positivebalances = client1.SumOfPositive();
            Console.WriteLine("Sum of positive balances of the client is " + positivebalances);

            var negativebalances = client1.SumOfNegative();
            Console.WriteLine("Sum of negative balances of the client is " + negativebalances);

            Console.ReadLine();

        }
    }
}
