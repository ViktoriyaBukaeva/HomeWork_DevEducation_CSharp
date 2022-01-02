using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Заполнить квадратную матрицу NxN(произвольного размера) нулями и единицами так, 
            //   как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое".
            //   Левое нижнее поле на шахматной доске всегда черное.
            //   Обратите внимание -нумерация элементов массива идет сверху вниз, и слева направо.
            //   То есть, левое нижнее поле -это поле в последней строке и 0 - м столбце.

            int M = 9;
            int[,] A = new int[M, M];
            bool color = false;
            for (int i = A.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = color ? 1 : 0;
                    color = !color;
                }
                if (M % 2 == 0) color = !color;
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
