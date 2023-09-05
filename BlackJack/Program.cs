using BlackJack.Bank;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank;
            bank = new Bank();
            bank.InsertMoney("spelare", -300);

            Console.WriteLine("Hejsan, vill du se till bank saldo? y/n: ");
            var svar = Console.ReadLine();
            
            if (svar == "y" || svar == "Y")
            {
                Console.WriteLine(bank);
            }
            else
            {
                Console.WriteLine("Hej då!");
            }

        }
    }
}