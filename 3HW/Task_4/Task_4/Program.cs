using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите значение а = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Уравнение ax^2 + bx + c = 0 решений не имеет");
            }
            else if (discriminant == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine($"x = -b / 2a = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine($"x1 = {-b} + √{discriminant} / 2 * {a} = {x1}");
                Console.WriteLine($"x2 = {-b} - √{discriminant} / 2 * {a} = {x2}");
            }

        }






    }
}

