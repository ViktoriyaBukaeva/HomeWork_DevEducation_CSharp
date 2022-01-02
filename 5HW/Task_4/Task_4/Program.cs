using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4) Поменять местами первую и вторую половину массива, например,
            //для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 3 1 2.

            int[] m1 = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();

            int m1_pol = m1.Length / 2;
            int m2_pol = m1.Length - m1.Length / 2;
            for (int i = 0; i < m1_pol; i++)
            {
                int t = m1[i];
                m1[i] = m1[m2_pol + i];
                m1[m2_pol + i] = t;
            }
            for (int i = 0; i < m1.Length; i++)
            { 
                Console.Write($"{m1[i]} ");
            }

        }
    }
}
