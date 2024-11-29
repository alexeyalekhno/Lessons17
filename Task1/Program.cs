using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Input();
            Console.WriteLine(bankAccount1.GetInfo());

            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Input();
            Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
