using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6) Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот. 
            // Сделать за O(N / 2).

            int[] m1 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(0, 50);
                Console.Write($"{m1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < m1.Length-1; i = i + 2)
            {
                int tmp = m1[i];
                m1[i] = m1[i + 1];
                m1[i + 1] = tmp;
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write($"{m1[i]} ");
            }
        }
    }
}
