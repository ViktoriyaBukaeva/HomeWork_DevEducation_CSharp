using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Пользователь вводит три не равных нулю числа (a, b и c).
            //Выведите в консоль решение (значение X) линейного уравнения стандартного вида a*X+b=c.
            Console.Write("введите значение 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение 3: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double x;
            Console.WriteLine(x = (c - b) / a);
            var q = x;
            Console.ReadLine();

        }
    }
}

