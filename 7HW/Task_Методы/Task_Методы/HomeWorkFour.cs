using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Методы
{
    class HomeWorkFour
    {
        public static void DoTaskOne(int num)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % num == 0)
                {
                    InputOutputHelper.PrintMeaningInt(i);
                }
            }
        }

        public static void DoTaskTwo(int num)
        {
            int k = 1;
            while (k * k < num)
            {
                k++;
            }
            k--;
            InputOutputHelper.PrintMeaningInt(k);
        }

        public static void DoTaskThree(double A)
        {
            double i = 2;
            while (i <= A)
            {
                double j = A / i;

                if (j == (int)j)
                {
                    InputOutputHelper.PrintMeaningDouble(j);
                    break;
                }
                else
                {
                    i++;
                }
            }
        }

        public static void DoTaskFour(int a, int b)
        {
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
            InputOutputHelper.PrintMeaningInt(sum);
        }
        public static void DoTaskFive(int a, int b)
        {
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
            InputOutputHelper.PrintMeaningInt(b);
        }
        public static void DoTaskSix(int num)
        {
            int i = 0;
            int r = num;
            int N = -1;

            while (i != N)
            {
                N = (i + r) / 2;
                if (Math.Pow(N, 3) == num)
                    break;
                if (Math.Pow(N, 3) > num)
                    r = N;
                else
                    i = N;
            }
            InputOutputHelper.PrintMeaningInt(N);
        }
        public static void DoTaskSeven(int A)
        {
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
            InputOutputHelper.PrintMeaningInt(count);
        }
        public static void DoTaskEight(int num)
        {
            int d_num = num.ToString().Length;
            int pos = 0;
            int res = 0;
            while (num > 0)
            {
                res += (num % 10) * (int)Math.Pow(10, d_num - pos - 1);
                pos++;
                num /= 10;
            }
            InputOutputHelper.PrintMeaningInt(res);
        }
        public static void DoTaskNine(int N)
        {
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
                    InputOutputHelper.PrintMeaningInt(i);
                }
            }
        }
        public static void DoTaskTen(int N1, int N2)
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
                InputOutputHelper.PrintMessage("ДА");
            }
            else
            {
                InputOutputHelper.PrintMessage("НЕТ");
            }
        }
    }
}
