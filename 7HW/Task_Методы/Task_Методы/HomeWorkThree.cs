using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Методы
{
    class HomeWorkThree
    {

        public static double DoTaskOne(double a, double b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }
        public static void DoTaskTwo(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                InputOutputHelper.PrintMessage("Точка находится в 1 четверти оси координат.");
            }
            else if (x > 0 && y < 0)
            {
                InputOutputHelper.PrintMessage("Точка находится во 2 четверти оси координат.");
            }
            else if (x < 0 && y < 0)
            {
                InputOutputHelper.PrintMessage("Точка находится в 3 четверти оси координат.");
            }
            else if (x < 0 && y > 0)
            {
                InputOutputHelper.PrintMessage("Точка находится в 4 четверти оси координат.");
            }
            else
            {
                InputOutputHelper.PrintMessage("Точка находится на пересечении оси координат.");
            }
        }
        public static (double min, double medium, double max) DoTaskThree (double num1, double num2, double num3)
        {
            double min = num1 < num2 && num1 < num3 ? num1 : num2 < num1 && num2 < num3 ? num2 : num3;
            double medium = num1 > num2 && num1 < num3 ? num1 : num2 > num1 && num2 < num3 ? num2 : num3;
            double max = num1 > num2 && num1 > num3 ? num1 : num2 > num1 && num2 > num3 ? num2 : num3;
            return (min, medium, max);
        }
        public static int DoTaskFour(double a, double b, double c, ref double x1, ref double x2)
        
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) return 0;

            if (D == 0)
            {
                x1 = -b / 2 * a;
                return 1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                return 2;
            }
        }
        public static string DoTaskFive(int num)
        {
            string message = "";
            
            if (num >= 10 && num <= 99)
            {
                if (num >= 20)
                {
                    if (num >= 20 && num <= 29)
                    {
                        message += "двадцать";
                    }
                    else if (num >= 30 && num <= 39)
                    {
                        message += "тридцать";
                    }
                    else if (num >= 40 && num <= 49)
                    {
                        message += "сорок";
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
                        message += "девяносто";
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
                return message;
            }
            else
            {
               return ("Введенное число не соответствует заданным параметрам");
            }
        }
        public static string DoTaskSix(double a, double b, double c)
        {           
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                return ("Треугольник существует");
            }
            else
            {
                return ("Треугольник не существует");
            }
        }
    }   
}
