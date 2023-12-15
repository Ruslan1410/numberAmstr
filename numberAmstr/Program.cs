using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAmstr
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0)
            {
                if (IsArmstrongNumber(number))
                {
                    Console.WriteLine($"{number} - это число Армстронга.");
                }
                else
                {
                    Console.WriteLine($"{number} - не является числом Армстронга.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите неотрицательное целое число.");
            }
        }

        // Метод для проверки, является ли число числом Армстронга
        static bool IsArmstrongNumber(int num)
        {
            int originalNumber = num;
            int numberOfDigits = CountDigits(num);
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                num /= 10;
            }

            return sum == originalNumber;
        }

        // Метод для подсчета количества цифр в числе
        static int CountDigits(int num)
        {
            int count = 0;

            while (num > 0)
            {
                num /= 10;
                count++;
            }

            return count;
        }
    }

}
