using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Bank
{
    public class Account
    {
        public int Id { get; }
        public bool Blocked { get; set; }
        public int Balance { get; set; }

        public Account(int id)
        {
            Id = id;
        }

        public Account(int id, bool blocked, int balance)
        {
            Id = id;
            Blocked = blocked;
            Balance = balance;
        }

    }
}
