using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // решение 2
            Console.Write("введите значение 1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение 2: ");
            double b1 = Convert.ToDouble(Console.ReadLine());


            double equations1 = (5 * a1 + Math.Pow(b1,4)) / (b1 - a1);
            Console.WriteLine(equations1);


        }
    }
}
