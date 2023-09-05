using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Bank
{
    public class BankAccount
    {
        private int balance;
        private string accountId;

        public BankAccount(string id)
        {
            accountId = id;
            balance = 0;
        }

        public void InsertMoney(int amount)
        {
            balance += amount;
        }
        public int GetBalance()
        {
            return balance;
        }
    }
}
