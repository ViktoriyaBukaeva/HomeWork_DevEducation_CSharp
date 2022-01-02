using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8) Реализовать перемножение матриц целых чисел. Примеры не сложно найти в сети.
            //Важно их понять и адаптировать для ваших двух произвольных массивов.
            //Проверить входное условие перемножения (число столбцов 1-го массива == числу строк 2-го массива).
            int[,] masA = new int[3, 2];
            int[,] masB = new int[2, 3];
            Random rnd = new Random();
            for (int i = 0; i < masA.GetLength(0); i++)
            {
                for (int j = 0; j < masA.GetLength(1); j++)
                {
                    masA[i, j] = rnd.Next(0, 10);
                    Console.Write($"{masA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < masB.GetLength(0); i++)
            {
                for (int j = 0; j < masB.GetLength(1); j++)
                {
                    masB[i, j] = rnd.Next(11, 20);
                    Console.Write($"{masB[i, j]} ");
                }
                Console.WriteLine();
            }
            int[,] masC = new int[masA.GetLength(0), masB.GetLength(1)];
            for (int i = 0; i < masA.GetLength(0); i++)        // 3
            {
                for (int j = 0; j < masB.GetLength(1); j++)
                {
                    masC[i, j] = 0;
                    for (int k = 0; k < masA.GetLength(1); k++)
                    {
                        masC[i, j] += masA[i, k] * masB[k, j];
                    }
                }
            }
            for (int i = 0; i < masC.GetLength(0); i++)
            {
                for (int j = 0; j < masC.GetLength(1); j++)
                {
                    Console.Write($"{masC[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}