using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Пользователь вводит два числа. 
            // Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            // Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            Console.Write("Введите целое число N1: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число N2: ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            while (N1 != 0 && flag == false)
            {
                int b1 = N1 % 10;
                int N2copy = N2;

                while (N2copy != 0 && flag == false)
                {
                    int b2 = N2copy % 10;

                    if (b1 == b2)
                    {
                        flag = true;
                    }
                    N2copy = N2copy / 10;
                }
                N1 = N1 / 10;               
            }
            if (flag == true)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
            
        }
    }
}
