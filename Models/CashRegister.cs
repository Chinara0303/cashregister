using ConsoleApp3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class CashRegister
    {
        static double TotalAmount;
        static int TotalSalesCount=0;
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public CashRegister(double totalAmount, Currency currency)
        {
            TotalAmount = totalAmount;
            Currency = currency;
        }
        public void AddNewSale(double amount, Currency currency)
        {
            TotalSalesCount++;

            if (Currency==currency)
            {
                TotalAmount += amount;
            }
            else
            {
                switch (currency)
                {
                    case Currency.AZN:
                        TotalAmount += amount /= 1.7;
                        break; 
                    case Currency.USD:
                        TotalAmount += amount *= 1.7;
                        break;
                    case Currency.TRY:
                        TotalAmount += amount *= 0.13;
                        break;
                    default:
                        break;
                }
            }
           
        }
        public void RemoveSale(double amount, Currency currency1)
        {
            TotalSalesCount--;
            if (Currency == currency1)
            {
                TotalAmount -= amount;
            }
            else
            {
                switch (currency1)
                {
                    case Currency.AZN:
                        TotalAmount -= amount /= 1.7;
                        break;
                    case Currency.USD:
                        TotalAmount -= amount *= 1.7;
                        break;
                    case Currency.TRY:
                        TotalAmount -= amount *= 0.13;
                        break;
                    default:
                        break;
                }
            }
        }
        public override string ToString()
        {
            return $"Umumi Mebleg:{TotalAmount}\nOdenish novu:{PaymentType}\nValyuta:{Currency}\nSatishlarin sayi:{TotalSalesCount}";
        }
    }
}
