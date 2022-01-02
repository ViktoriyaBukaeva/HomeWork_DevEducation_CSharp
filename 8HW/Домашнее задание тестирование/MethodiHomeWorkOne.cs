using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkOne
    {
        public static List<string> GetListHelloandBy_Task1(int a, double b)
        {
            List<string> res = new List<string>();
            res.Add("привет, " + a + " !");
            res.Add(a + " + " + b + " = " + (a + b));
            res.Add("пока, " + b + " ...");
            return res;
        }

        public static double SolveEquation_Task2(double a, double b)
        {
            if (a == b)
            {
                throw new DivideByZeroException("на 0 делить нельзя");
            }
            return (5 * a + Math.Pow(b, 4)) / (b - a);
        }

        public static (string, string) RepleaceMeaning_Task_3(string s1, string s2)
        {
            string s3 = s1;
            s1 = s2;
            s2 = s3;
            return (s1, s2);
        }

        public static double SolveLinearEquationTask_4(double a, double b, double c)
        {
            return (c - b) / a;
        }

    }
}
