using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            //   Найдите число N методом половинного деления.
            Console.Write("Введите целое положительное число, которое является кубом целого числа N:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int r = num;
            int m = -1;

            while (i != m)
            {
                m = (i + r) / 2;
                if (Math.Pow(m, 3) == num) 
                    break;
                if (Math.Pow(m, 3) > num)
                    r = m;
                else
                    i = m;
            }
            Console.WriteLine(m);
        }
    }
}
