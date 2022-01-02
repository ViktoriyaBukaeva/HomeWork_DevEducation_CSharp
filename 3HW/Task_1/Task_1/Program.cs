using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Пользователь вводит два числа(A и B). Если A > B, подсчитать A+B, если A == B, подсчитать A*B, если A<B, подсчитать A-B.
            //Сделать лесенкой из двух if'ов.
            Console.Write("Введите число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a + b);
            }
            else if (a == b)
            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine(a - b);
            }






        }
    }
}
