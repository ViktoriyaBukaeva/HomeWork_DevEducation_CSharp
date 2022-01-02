using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkFour
    {
        public static List<int> GetNumbersDevidedOnNumTask_1(int num)
        {
            if (num > 1000)
            {
                throw new ArgumentException("Входное А больше 1000");
            }
            if (num == 0)
            {
                throw new ArgumentException("Входное А равно 0");
            }
            if (num < 0)
            {
                throw new ArgumentException("Входное А меньше 0");
            }
            List<int> res = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                if (i % num == 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }

        public static int GetNumbersSquareOfWhichIsSmallerNum_Task2(int num)
        {
            if (num <= 0)
            {
                throw new ArgumentException("Введите число больше 0");
            }
            int k = 1;
            while (k * k < num)
            {
                k++;
            }
            k--;
            return k;
        }
        public static double GetLargestDivisorOfA_Task3(double A)
        {
            if (A <= 0)
            {
                throw new ArgumentException("Введите число больше 0");
            }
            double i = 2;
            while (i <= A)
            {
                double j = A / i;

                if (j == (int)j)
                {
                    return j;
                }
                else
                {
                    i++;
                }
            }
            return i;
        }
        public static int SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                throw new ArgumentException("Диапазон введенных чисел должен быть больше 0");
            }
            int sum = 0;
            if (a > b)
            {
                int tmp = a;
                b = a;
                a = tmp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static int FindGreatestDivisorUsingEuclidAlgorithm_Task5(int a, int b)
        {
            if (a < 0)
            {
                a = Math.Abs(a);
            }
            if (b < 0)
            {
                b = Math.Abs(b);
            }
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return b;
        }
        public static int FindNumberNByTheMethodOfHalfDivision_Task6(int num)
        {
            int i = 0; // leftlimit
            int r = num; //rightlimit num = n
            int N = 1; // center
            if (num <= 0)
            {
                throw new ArgumentException("Введите целое число больше 0");
            }
            while (i != N && i < r - 1)
            {
                N = (i + r) / 2; // num или
                if (Math.Pow(N, 3) == num)
                    break;
                if (Math.Pow(N, 3) > num)
                    r = N;
                else
                    i = N;
            }
            return N;
        }
        public static int FindNnumberofOddDigits_Task7(int A)
        {
            if (A < 0)
            {
                throw new ArgumentException("Введите число а произвольной длины (5 - 8 цифр)");
            }
            if (A < 10000)
            {
                throw new ArgumentException("Введите число а произвольной длины (5 - 8 цифр)");
            }
            if (A > 99999999)
            {
                throw new ArgumentException("Введите число а произвольной длины (5 - 8 цифр)");
            }
            int count = 0;
            while (A > 0)
            {
                int b = A % 10;

                if (b % 2 != 0)
                {
                    count++;
                }
                A /= 10;
            }
            return count;
        }
        public static int GetNumberInReverse_Task8(int num)
        {
            if (num <= 0)
            {
                throw new ArgumentException("Число не может быть отрицательным");
            }
            int d_num = num.ToString().Length;
            int pos = 0;
            int res = 0;
            while (num > 0)
            {
                res += (num % 10) * (int)Math.Pow(10, d_num - pos - 1);
                pos++;
                num /= 10;
            }
            return res;
        }
        public static List<int> СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9 (int N)
        {
            if (N <= 0)
            {
                throw new ArgumentException("Число не может быть отрицательным");
            }
            List<int> res = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                int current = i;
                while (current != 0)
                {
                    int b = current % 10;
                    if (b % 2 != 0)
                    {
                        sum1 = sum1 + b;
                    }
                    else
                    {
                        sum2 = sum2 + b;
                    }
                    current = current / 10;
                }
                if (sum2 > sum1)
                {
                    res.Add(i);
                }
            }
            return res;
        }
        public static string FindSameNumbers_Task10 (int N1, int N2)
        {
            bool flag = false;
            while (N1 != 0 && flag == false)
            {
                int b1 = N1 % 10;
                int N2copy = N2;

                while (N2copy != 0 && flag == false)
                {
                    int b2 = N2copy % 10;

                    if (b1 == b2)
                    {
                        flag = true;
                    }
                    N2copy = N2copy / 10;
                }
                N1 = N1 / 10;
            }
            if (flag == true)
            {
               return "ДА";
            }
            else
            {
                return "НЕТ";
            }
        }
    }
}
