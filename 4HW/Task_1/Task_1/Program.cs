using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Пользователь вводит одно число(A).
            //Вывести все числа от 1 до 1000, которые делятся на A.
            Console.Write("Введите делитель: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 1000; i++)
            {
                if (i % num == 0)
            { 
                Console.WriteLine(i);
            }


        }
    }
}
