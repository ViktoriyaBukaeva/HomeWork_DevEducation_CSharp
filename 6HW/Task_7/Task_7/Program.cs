using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7) Заполнить массив из символов(char) указанным образом(см.рисунок 1).
            
            char[,] mas = new char [5, 5];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1 || i >= j && i >= mas.GetLength(0) - j - 1) ? '*' : '-';
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
           
        }
    
    }

}


