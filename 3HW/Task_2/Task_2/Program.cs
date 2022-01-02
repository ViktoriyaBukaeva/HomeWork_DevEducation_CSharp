using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Пользователь вводит два числа(X и Y). Определить какой четверти координатной плоскости принадлежит точка с координатами(X, Y).
            //Примечание.Нумерацию четвертей принять такую:
            //4 | 1
            //--------
            //3 | 2

            Console.Write("Ведите координату по x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ведите координату по y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 1 четверти оси координат.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится во 2 четверти оси координат.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 3 четверти оси координат.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 4 четверти оси координат.");
            }
            else
            {
                Console.WriteLine("Точка находится на пересечении оси координат.");
            }






        }
    }
}
