using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkTwo
    {
        public static int SumOfThreeDigitNumber_Task1 (int num)
        {
            if (num > 999)
            {
                throw new ArgumentException("Введенное значение не должно быть больше 999");
            }
            if (num < 100)
            {
                throw new ArgumentException("Введенное значение не должно быть меньше 100");
            }
            int n1 = num % 10;
            int n2 = num / 100;
            int n3 = (num / 10) % 10;
            num = n1 + n2 + n3;
            return num;
        }

        public static bool FindaShotintheRadius_Task2 (double radius, double x1, double y1)
        {   
            if (radius == 0)
            {
                throw new ArgumentException("Радиус не может быть равен 0");
            }
            return Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(radius, 2);             
        }

        public static bool СompareAverageNumberwithExtremes_Task3 (int sum)
        {
            if (sum > 999)
            {
                throw new ArgumentException("Введенное значение не должно быть больше 999");
            }
            if (sum < 100)
            {
                throw new ArgumentException("Введенное значение не должно быть меньше 100");
            }
            int s1 = sum / 100;
            int s2 = (sum / 10) % 10;
            int s3 = sum % 10;
            if (s3 < s2 && s2 <= s1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int ChangePlaceForLastandFirstNumber_Task4(int sum)
        {
            if (sum > 999)
            {
                throw new ArgumentException("Введенное значение не должно быть больше 999");
            }
            if (sum < 100)
            {
                throw new ArgumentException("Введенное значение не должно быть меньше 100");
            }
            int s1 = sum / 100;
            int s2 = (sum / 10) % 10;
            int s3 = sum % 10;
            int tmp = s1;
            s1 = s3;
            s3 = tmp;
            return s1 * 100 + s2 * 10 + s3;
        }
        public static bool CheckFractionalPartOfTheNumber_Task5(double num)
        {
            int y9 = (int)num;
            bool meaning = num == y9;
            return meaning;
        }
    }
}
