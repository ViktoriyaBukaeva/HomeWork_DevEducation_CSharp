using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Посчитать количества нечетных и четных элементов массива.Не путать с нечетными и четными индексами.
            
            int[] m1 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 100);
                Console.WriteLine($"{m1[i]}  ");
            }
            int count_even = 0;
            int count_odd = 0;
            for (int i = 0; i < m1.Length; i++)
            {
                if (m1[i] % 2 == 0)
                {
                    count_even++;
                }
                else
                {
                    count_odd++;
                }
            }
            Console.WriteLine("количество четных числе в массиве = " + count_even);
            Console.WriteLine("количество нечетных числе в массиве = " + count_odd);
        }
    }
}