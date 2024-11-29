using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankAccount<T>
    {
        public T AccountNumber { get; set; }
        public double Balance { get; set; }
        public string FullName { get; set; }

        public string GetInfo()
        {
            return $"{AccountNumber} {Balance} {FullName}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер банковского счета:");
            string stringAccountNumber = Console.ReadLine();
            AccountNumber = (T)Convert.ChangeType(stringAccountNumber, typeof(T));
            Console.WriteLine("Введите баланс счета:");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО:");
            FullName = Console.ReadLine();

        }
    }
}
