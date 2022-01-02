using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6) Найти количество элементов массива, которые больше всех своих соседей одновременно.
            // Примечание: соседями элемента считать только 4 потенциальных соседа: на 1 выше, на 1 ниже, на 1 левее и на 1 правее.
            // Обязательно учесть выход за границы массива!При определении критерия, 
            // считать сумму соседей для каждого элемента, даже для элемента[0; 0] (у него, кстати, будет всего два соседа - [0; 1] и[1; 0]).
            Random rnd = new Random();
            int[,] arrey = new int[5, 5];
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    arrey[i, j] = rnd.Next(0, 10);
                    Console.Write($"{arrey[i, j]}\t");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    int sosedi = (i > 0 ? arrey[i - 1, j] : 0)
                        + (i < arrey.GetLength(0) - 1 ? arrey[i + 1, j] : 0)
                        + (j > 0 ? arrey[i, j - 1] : 0)
                        + (j < arrey.GetLength(1) - 1 ? arrey[i, j + 1] : 0);
                    if (arrey[i, j] > sosedi)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
        
