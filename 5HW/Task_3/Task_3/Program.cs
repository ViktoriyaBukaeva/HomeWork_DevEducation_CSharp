using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3) Слить два целочисленных массива в один(должен получиться третий массив).
           
            int[] m1 = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();

            int[] m2 = new int[9];            
            for (int i = 0; i < m2.Length; i++)
            {
                m2[i] = rnd.Next(0, 50);
                Console.Write($"{m2[i]} ");
            }
            Console.WriteLine();

            int[] m3 = new int[m1.Length + m2.Length];
            for (int i = 0; i < m3.Length; i++)
            {
                int num = 0;
                if (i < m1.Length)
                {
                    num = m1[i];
                }
                else
                {
                    int j = i - m1.Length;
                    num = m2[j];
                }
                m3[i] = num;
            }
            
            for (int i = 0; i < m3.Length; i++)
            {
                Console.Write($"{m3[i]} ");
            }
            Console.WriteLine();






        }
    }
}
