using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9) Пользователь вводит целое положительное  число(N).
            //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
            Console.Write("Введите целое положительное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                int current = i;
                while (current != 0)
                {
                    int b = current % 10;
                    if (b % 2 != 0)
                    {
                        sum1 = sum1 + b;
                    }
                    else
                    {
                        sum2 = sum2 + b;
                    }
                    current = current / 10;
                }
                if (sum2 > sum1)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
