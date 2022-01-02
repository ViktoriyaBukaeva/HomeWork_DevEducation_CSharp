using System;

namespace Task_Методы
{
    public class HomeWorkOne
    {
        public static void DoTaskOne (int a, double b)
        {
            Console.WriteLine("Привет, " + a + "!");
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine("Пока, " + b + "...");
        }
        
        public static double DoTaskSecond(double a, double b)
        {
            return (5 * a + Math.Pow(b, 4)) / (b - a);
        }

        public static (string, string) DoTaskThree(string s1, string s2)
        {
            string s3 = s1;
            s1 = s2;
            s2 = s3;
            return (s1, s2);
        }
        
        public static double DoTaskFour(double a, double b, double c)
        {
            return (c - b) / a;             
        }
    }
}
