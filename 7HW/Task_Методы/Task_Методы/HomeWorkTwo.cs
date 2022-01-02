using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Методы
{
    class HomeWorkTwo
    {
        public static int[] DoTaskOne(int num)
        {
            int n1 = num % 10;
            int n2 = num / 100;
            int n3 = (num / 10) % 10;
            int[] mas = new int[3] { n1, n2, n3 };
            return (mas);
        }
        public static bool DoTaskTwo(double radius, double x1, double y1)
        {
            bool condition = Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(radius, 2);
            return condition;
        }
        public static bool DoTaskThree(int sum)
        {
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
            // bool result = s3 < s2 && s2 <= s1;
            // return result;
        }
        public static int DoTaskFour(int sum)
        {
            int s1 = sum / 100;
            int s2 = (sum / 10) % 10;
            int s3 = sum % 10;
            int tmp = s1;
            s1 = s3;
            s3 = tmp;
            return s1 * 100 + s2 * 10 + s3;          
        }
        public static bool DoTaskFive (double num)
        {
            int y9 = (int)num;
            bool meaning = num == y9;
            return (meaning);
        }  
    }
}
