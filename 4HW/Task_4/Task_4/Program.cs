using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Пользователь вводит два числа(A и B).
            // Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
            // (Учтите, что при вводе B может оказаться меньше A).
            Console.Write("Введите целое число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a > b)
            {
                int tmp = a;
                b = a;
                a = tmp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;                   
                }
            }
            Console.WriteLine(sum);
        }   
    }
}
 
