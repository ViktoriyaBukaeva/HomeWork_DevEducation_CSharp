using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 6;
            //int max = a > b ? a : b; 
            //3) Пользователь вводит три числа(A, B и С).
            //Выведите их в консоль в порядке возрастания.Можно использовать сложное условное выражение, но можно и if'ами.

            Console.Write("введите число 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите число 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите число 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double min = num1 < num2 && num1 < num3 ? num1 : num2 < num1 && num2 < num3 ? num2 : num3;
            Console.WriteLine(min);
            double medium = num1 > num2 && num1 < num3 ? num1 : num2 > num1 && num2 < num3 ? num2 : num3;
            Console.WriteLine(medium);
            double max = num1 > num2 && num1 > num3 ? num1 : num2 > num1 && num2 > num3 ? num2 : num3;
            Console.WriteLine(max);
            

            
        }
    }
}
