using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Пользователь вводит одно число(A). Найдите количество положительных целых чисел , квадрат которых меньше A.
            Console.Write("Введите положительное число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while (k * k < A)
            {
                k++;
            }
            k--;
            Console.WriteLine(k); 






        }
    }
}
