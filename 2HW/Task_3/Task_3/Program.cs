using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Пользователь вводить трехзначное число.
            //Записать логическое условие, которые будет истинным тогда
            //и только тогда, когда его средняя цифра меньше или равна //(<=) первой (левой)
            //и одновременно строго больше (>) последней (правой).
            // Например: 742(true)
            
            
            Console.Write("Введите трехзначное число: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            int s1 = sum / 100; // == 7
            int s2 = (sum / 10) % 10; // == 4
            int s3 = sum % 10; // == 2    
            bool s1s2s3 = s3 < s2 && s2 <= s1;
            Console.WriteLine(s1s2s3);



            


        }
    }
}
