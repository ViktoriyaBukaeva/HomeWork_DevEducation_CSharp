using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) Отсортировать массив по возрастанию алгоритмом выборки(select).
            // Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).
            int[] m1 = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < m1.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < m1.Length; j++)
                {
                    if (m1[j] < m1[min])
                    {
                        min = j;
                    }
                }
                int tmp = m1[i];
                m1[i] = m1[min];
                m1[min] = tmp;
            }
            Console.WriteLine(string.Join(' ', m1));
        }
      
    }      
}

