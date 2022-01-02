using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) Ввести с клавиатуры координаты выстрела x1 и y1.
            // Записать в bool переменную логическое выражение, которое будет истинным(true) тогда и только тогда, когда этот выстрел попадает в круглую мишень
            // (точка лежит внутри круга радиусом R). Вывести bool переменную на экран.
            // Формула круга: x ^ 2 + y ^ 2 = R ^ 2 (или ( x-0)²+(y-0)²=r²).
            // Следовательно, условие нахождения точки ВНУТРИ круга будет ////(подумайте о знаке сравнения). 
            // Запись x^2 означает "икс в квадрате".
            Console.Write("введите координату 1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите координату 2: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            double radius = 8;
            bool condition = Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(radius, 2);
            Console.WriteLine(condition);

            
        }
    }
}
