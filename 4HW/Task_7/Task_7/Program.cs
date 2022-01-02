using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7) Пользователь вводит одно число произвольной длины (5 - 8 цифр). 
            //   Найти количество нечетных цифр этого числа.

            Console.Write("Введите число а произвольной длины (5 - 8 цифр): ");
            int A = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (A > 0)
            {
                int b = A % 10;
               
                if (b % 2 != 0)
                {
                    count++;
                }
                A /= 10;
            }
            Console.WriteLine(count);
        }
    }
}
