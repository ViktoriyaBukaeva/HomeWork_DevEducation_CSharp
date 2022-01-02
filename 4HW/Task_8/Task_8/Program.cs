using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8) Пользователь вводит одно число. 
            //Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, 
            //задано число 123, вывести 321.Просьба массивами и строками не пользоваться.
            Console.Write("Введите посследовательность цифр: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int d_num = num.ToString().Length;
            int pos = 0;
            int res = 0;
            while (num > 0)
            {
                res += (num % 10) * (int)Math.Pow(10, d_num - pos - 1);
                pos++;
                num /= 10;
            }
            Console.WriteLine(res);
        }
    }    
}   


