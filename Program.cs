using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint onCount = 0;
            uint enCount = 0;

            int onSum = 0;
            int enSum = 0;

            Console.WriteLine("Введите первое число диапазона: ");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапазона: ");
            int limit = int.Parse(Console.ReadLine());

            while(currentValue <= limit)
            {
                if(currentValue % 2 == 0)
                {
                    enCount++;
                    enSum += currentValue;                  
                }
                else
                {
                    onCount++;
                    onSum += currentValue;                 
                }
                currentValue++;
            }
            Console.WriteLine($"Количество нечётных чисел: {onCount}");
            Console.WriteLine($"Количество чётных чисел: {enCount}");
            Console.WriteLine($"Сумма нечётных чисел: {onSum}");
            Console.WriteLine($"Сумма чётных чисел: {enSum}");
            Console.ReadKey(true);

        }
    }
}
