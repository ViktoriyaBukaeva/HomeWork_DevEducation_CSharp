using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
            // Например при вводе “25” в консоль будет выведено “двадцать пять”.
            // Примечание.Здесь, пожалуй, удобно использовать switch-case, но можно и if-ами.Да, потребуется много веткой с соответствующими словами ))
            // Но их будет не 89(10 - 99) :) Подумайте, как можно сделать поменьше. Анализируйте соответствующие цифры и выводите соответствующий текст.
            Console.Write("Введите двухзначное число больше 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 10 && num <= 99)
            {
                if (num >= 20)
                {
                    if (num >= 20 && num <= 29)
                    {
                        Console.Write("двадцать ");
                    }
                    else if (num >= 30 && num <= 39)
                    {
                        Console.Write("тридцать ");
                    }
                    else if (num >= 40 && num <= 49)
                    {
                        Console.Write("сорок ");
                    }
                    else if (num >= 50 && num <= 59)
                    {
                        Console.Write("пятьдесять ");
                    }
                    else if (num >= 60 && num <= 69)
                    {
                        Console.Write("шестьдесят ");
                    }
                    else if (num >= 70 && num <= 79)
                    {
                        Console.Write("семьдесят ");
                    }
                    else if (num >= 80 && num <= 89)
                    {
                        Console.Write("восемьдесят ");
                    }
                    else if (num >= 90 && num <= 99)
                    {
                        Console.Write("девяносто ");
                    }
                    num = num % 10;
                }
                               
                switch (num)
                {
                    case 1: Console.WriteLine("один"); break;
                    case 2: Console.WriteLine("два"); break;
                    case 3: Console.WriteLine("три"); break;
                    case 4: Console.WriteLine("четыре"); break;
                    case 5: Console.WriteLine("пять"); break;
                    case 6: Console.WriteLine("шесть"); break;
                    case 7: Console.WriteLine("семь"); break;
                    case 8: Console.WriteLine("восемь"); break;
                    case 9: Console.WriteLine("девять"); break;
                    case 10: Console.WriteLine("десять"); break;
                    case 11: Console.WriteLine("одиннадцать"); break;
                    case 12: Console.WriteLine("двенадцать"); break;
                    case 13: Console.WriteLine("тринадцать"); break;
                    case 14: Console.WriteLine("четырнадцать"); break;
                    case 15: Console.WriteLine("пятнадцать"); break;
                    case 16: Console.WriteLine("шестнадцать"); break;
                    case 17: Console.WriteLine("семнадцать"); break;
                    case 18: Console.WriteLine("восемнадцать"); break;
                    case 19: Console.WriteLine("девятнадцать"); break;
                }
            }
            else
            {
                Console.WriteLine("Введенное число не соответствует заданным параметрам.");
            }
        }
    }
}
