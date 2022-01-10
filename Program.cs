using ConsoleApp3.Models;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister  = new CashRegister(10,Enums.Currency.AZN);
            //CashRegister cashRegister1 = new CashRegister(400, Enums.Currency.USD);
            CashRegister cashRegister2 = new CashRegister(500, Enums.Currency.TRY);
            cashRegister.AddNewSale(23.5, Enums.Currency.AZN);
            //cashRegister1.AddNewSale(40, Enums.Currency.USD);
            cashRegister2.AddNewSale(35, Enums.Currency.TRY);
            Console.WriteLine(cashRegister);
            //Console.WriteLine(cashRegister1);
            Console.WriteLine(cashRegister2);
        }
    }
}
