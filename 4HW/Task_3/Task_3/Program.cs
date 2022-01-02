using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Пользователь вводит одно число(A). Вывести наибольший делитель(кроме самого A) числа A.

            Console.Write("Введите положительное число: ");
            double A = Convert.ToDouble(Console.ReadLine());
            double i = 2;

            while (i <= A)
            {
                double j = A / i;

                if (j == (int)j)
                {
                    Console.WriteLine(j);
                    break;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
