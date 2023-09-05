using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Bank
{
    public class Bank
    {
        private BankAccount spelare;

        public Bank()
        {
            spelare = new BankAccount("spelare");
        }
        public void InsertMoney(string accoundId, int amount)
        {
            // hitta rätt konto

            // sätt in pengar på detta konto
            spelare.InsertMoney(amount);
        }

        public override string ToString()
        {
            return "Bank saldo: " + spelare.GetBalance();
        }
        
    }



}



