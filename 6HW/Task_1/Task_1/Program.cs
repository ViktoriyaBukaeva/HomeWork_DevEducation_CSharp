using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM.
            // Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.
            // Примечание: здесь "NxM" означает, что массив прямоугольный, произвольного размера.
            // Наиболее наглядно такие задачи показывают себя на массивах, например, 5x8.
            Random rnd = new Random();
            int[,] mas1 = new int[5, 8];
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    mas1[i, j] = rnd.Next(0, 100);
                    Console.Write($"{mas1[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < mas1.GetLength(1); j++)
            {
                mas1[0, j] *= -1;
                mas1[mas1.GetLength(0) - 1, j] *= -1;
            }
            for (int i = 1; i < mas1.GetLength(0) - 1; i++)
            {
                mas1[i, 0] *= -1;
                mas1[i, mas1.GetLength(1) - 1] *= -1;
            }

            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    Console.Write($"{mas1[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
