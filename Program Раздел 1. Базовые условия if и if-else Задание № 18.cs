using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Сумма покупки (руб): ");
            if (double.TryParse(Console.ReadLine(), out double sum))
            {
                double finalSum = sum > 1000 ? sum * 0.95 : sum;
                Console.WriteLine($"Итоговая цена: {finalSum:F2} руб.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}