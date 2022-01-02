using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkThree
    {
        public static double CompareCalculateAandBTask_1(double a, double b)
        {
            if (a > b)
            {
                return (a + b);
            }
            if (a == b)
            {
                return (a * b);
            }
            return (a - b);
        }
        public static int DetermineQuadrantTask_2(double x, double y)
        {
            if ((x == 0 ||  y == 0))
            {
                throw new ArgumentException("Точка находится на оси x или y ");
            }           
            if (x > 0 && y > 0)
            {
                return 1;
            }
            if (x > 0 && y < 0)
            {
                return 2;
            }
            if (x < 0 && y < 0)
            {
                return 3;
            }
            return 4;
        }
        public static (double min, double medium, double max) ReplaceNumberfromMinToMaxTask_3(double num1, double num2, double num3)
        {
            double min = num1 < num2 && num1 < num3 ? num1 : num2 < num1 && num2 < num3 ? num2 : num3;            
            double medium = num1 > num2 && num1 < num3 ? num1 : num2 < num1 && num2 > num3 ? num2 : num3;
            double max = num1 > num2 && num1 > num3 ? num1 : num2 > num1 && num2 > num3 ? num2 : num3;
            return (min, medium, max);
        }
        public static double[] ResolveQuadEquationTask_4(double a, double b, double c)

        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                return new double[] {};
            }
            if (D == 0)
            {
                return new double[] { (-b )/ (2 * a) };
            }
            else
            {
                return new double[] { (-b + Math.Sqrt(D)) / 2 * a, (-b - Math.Sqrt(D)) / 2 * a };
            }
        }
        public static string GetUppercaseofNumberTask_5(int num)
        {
            if (num < 10 || num > 99)
            {
                throw new ArgumentException("Введенное число не входит в диапазон, где оно больше или равно 10 и меньше или равно 99");
            }
            string message = "";
            if (num >= 10 && num <= 99)
            {
                if (num >= 20)
                {
                    if (num >= 20 && num <= 29)
                    {
                        message += "двадцать ";
                    }
                    else if (num >= 30 && num <= 39)
                    {
                        message += "тридцать ";
                    }
                    else if (num >= 40 && num <= 49)
                    {
                        message += "сорок ";
                    }
                    else if (num >= 50 && num <= 59)
                    {
                        message += "пятьдесять ";
                    }
                    else if (num >= 60 && num <= 69)
                    {
                        message += "шестьдесят ";
                    }
                    else if (num >= 70 && num <= 79)
                    {
                        message += "семьдесят ";
                    }
                    else if (num >= 80 && num <= 89)
                    {
                        message += "восемьдесят ";
                    }
                    else if (num >= 90 && num <= 99)
                    {
                        message += "девяносто ";
                    }
                    num = num % 10;
                }
                switch (num)
                {
                    case 1: message += "один"; break;
                    case 2: message += "два"; break;
                    case 3: message += "три"; break;
                    case 4: message += "четыре"; break;
                    case 5: message += "пять"; break;
                    case 6: message += "шесть"; break;
                    case 7: message += "семь"; break;
                    case 8: message += "восемь"; break;
                    case 9: message += "девять"; break;
                    case 10: message += "десять"; break;
                    case 11: message += "одиннадцать"; break;
                    case 12: message += "двенадцать"; break;
                    case 13: message += "тринадцать"; break;
                    case 14: message += "четырнадцать"; break;
                    case 15: message += "пятнадцать"; break;
                    case 16: message += "шестнадцать"; break;
                    case 17: message += "семнадцать"; break;
                    case 18: message += "восемнадцать"; break;
                    case 19: message += "девятнадцать"; break;
                }                
            }
            return message;
        }
        public static bool DetermineTriangleTask_6(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b);            
        }
    }
}



