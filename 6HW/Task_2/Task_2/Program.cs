using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) Заполнить матрицу 9x9 таблицей умножения:
            // 1 2 3...  9
            // 2 4 6... ...
            // 3 6 9... ...
            // ...  ... ... ...
            // 9........81

            int[,] TableMylt = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    TableMylt[i, j] = i * j;
                }
            }
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine();

                for (int j = 1; j < 10; j++)
                { 
                    Console.Write($"{TableMylt[i, j]}\t");
                }
            }
            Console.ReadKey();
        } //"{0,3}",
        //Console.Write("{0,3}",myltiplytable[i, j]);
    }
}
