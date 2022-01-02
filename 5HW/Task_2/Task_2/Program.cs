using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Каждый третий элемент массива заменить суммой двух предыдущих элементов.
           
            int[] m1 = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < m1.Length; i = i + 3)
            {
                int a = i;
                int b = i + 1;
                int c = i + 2;
                m1[c] = m1[a] + m1[b];
                Console.WriteLine(m1[c]);
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write($"{m1[i]} ");
            }





        }
    }
}
