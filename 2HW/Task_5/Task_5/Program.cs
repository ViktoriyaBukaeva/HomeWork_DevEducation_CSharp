using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Записать логическое условие, которое проверит, что в double числе нулевая дробная часть.
            //Например:
            //156.0(true)
            //156.2(false)
            //Подсказка: сравните само число double number и его явное приведение к(int)number
            
            double num1 = 156.0;
            double num2 = 156.5;
            int y9 = (int)num1;
            int y10 = (int)num2;
            bool meaning = num1 == y9;
            bool meaning2 = num2 == y10;
            Console.WriteLine(meaning);
            Console.WriteLine(meaning2);




        }
    }
}
