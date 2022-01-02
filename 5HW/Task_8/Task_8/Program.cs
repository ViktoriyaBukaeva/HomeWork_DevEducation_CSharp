using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) Отсортировать массив по возрастанию алгоритмом вставок(insert). 
            // Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).
            int[] m1 = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }

            Console.WriteLine();

            for (int i = 1; i < m1.Length; i++)
            {
                int a = m1[i];
                int j = i;
                while (j > 0 && a < m1[j - 1])
                {
                    int tmp = m1[j];
                    m1[j] = m1[j - 1];
                    m1[j - 1] = tmp;
                    j--;
                }
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write($"{m1[i]} ");
            }
        }
    }
}
