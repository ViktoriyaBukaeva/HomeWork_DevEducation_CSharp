using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Посчитать сумму всех трех цифр трехзначного числа, заданного константой(const). Вывести сумму на печать.
            // Например: 735 = 15(7 + 3 + 5)
            const int num = 793;
            int n1 = num % 10; //3
            int n2 = num / 100; //7
            int n3 = (num / 10) % 10; //9 
            Console.WriteLine(n1 + n2 + n3);
           
        }
    }
}
