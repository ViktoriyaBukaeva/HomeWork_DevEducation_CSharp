using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Пользователь вводит два числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.Write("Введите целое число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целое число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                a = Math.Abs(a);
            }
            if (b < 0)
            {
                b = Math.Abs(b);
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine(b);

        }
    }
}
