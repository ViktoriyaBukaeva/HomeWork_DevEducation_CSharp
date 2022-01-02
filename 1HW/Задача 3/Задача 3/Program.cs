using System;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Пользователь вводит два строковых(string) значения(s1 и s2).Поменяйте содержимое переменных s1 и s2 местами.
            //Подсказка: воспользуйтесь третьей переменной для временного сохранения значения одной из двух переменных.
            Console.Write ("введите значение s1 = ");
            string s1 = Console.ReadLine();
            Console.Write ("введите значение s2 = ");
            string s2 = Console.ReadLine();
            string s3 = s1;
            s1 = s2;
            s2 = s3;
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);






        }
    }
}
