using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Циклически cдвинуть массив вправо на 1 элемент.Например: 1 2 3 4 5-> 2 3 4 5 1.
            //А после этого сделать циклический сдвиг вправо на N элементов.
            int[] m1 = new int[5] { 1, 2, 3, 4, 5 };
            // сдвиг на 1 элемент
            int a = m1[m1.Length - 1];           
            for (int i = m1.Length - 1; i >= 1; i--)
            {
                m1[i] = m1[i - 1];
            }
            m1[0] = a;

            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();

            // сдвиг на N элементов
            int n = 3;
            for (int j = 0; j < n; j++)
            {
                a = m1[m1.Length - 1]; 
                for (int i = m1.Length - 1; i >= 1; i--)
                {
                    m1[i] = m1[i - 1];
                }
                m1[0] = a;
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write($"{m1[i]} ");
            }
        }
    }
}
