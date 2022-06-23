using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bank
{
    public class Client
    {
        private int _id;
        public int Id 
        { 
            get {
                return _id;
            }
        }
        public List <Account> Accounts { get; }

        public Client(int id)
        {
            _id = id;
            Accounts = new List <Account> ();
        }

        public Account GetAccountById(int accountId)
        {
            return Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        public int SumOfPositive()
        {
            return Accounts
                .Where(a => a.Balance > 0)
                .Select(a => a.Balance)
                .Sum();
        }

        public int SumOfNegative()
        {
            return Accounts
                .Where(a => a.Balance < 0)
                .Select(a => a.Balance)
                .Sum();
        }

    }
}
