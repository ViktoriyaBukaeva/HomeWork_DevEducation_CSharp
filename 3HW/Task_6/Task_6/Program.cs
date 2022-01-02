using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Даны вещественные положительные числа a, b, c.Выяснить, существует ли треугольник со сторонами a, b, c.
            Console.Write("введите величину стороны a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите величину стороны b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите величину стороны c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            { 
                Console.WriteLine("Треугольник не существует");
            }




        }
    }
}
