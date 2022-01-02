using System;

namespace _вне_дз__Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            int num1 = (int) num;
            bool result = num1 == num;
            Console.WriteLine(result);

        }
    }
}
