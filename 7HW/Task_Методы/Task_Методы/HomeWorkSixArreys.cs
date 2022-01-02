using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Методы
{
    class HomeWorkSixArreys
    {
        public static int[,] DoTaskOne(int[,] arrey)
        {
            for (int j = 0; j < arrey.GetLength(1); j++)
            {
                arrey[0, j] *= -1;
                arrey[arrey.GetLength(0) - 1, j] *= -1;
            }
            for (int i = 1; i < arrey.GetLength(0) - 1; i++)
            {
                arrey[i, 0] *= -1;
                arrey[i, arrey.GetLength(1) - 1] *= -1;
            }

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    Console.Write($"{arrey[i, j]}\t");
                }
                Console.WriteLine();
            }
            return arrey;
        }
        public static int[,] DoTaskTwo()
        {
            int[,] TableMylt = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TableMylt[i, j] = (i + 1) * (j + 1);
                }
            }
            return TableMylt;
        }
        public static int[,] DoTaskThree(int M)
        {
            int[,] A = new int[M, M];
            bool color = false;
            for (int i = A.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = color ? 1 : 0;
                    color = !color;
                }
                if (M % 2 == 0) color = !color;
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
            return A;
        }
        public static string DoTaskFour(int[,] arrey)
        {
            bool rules = true;

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1) - 1; j++)
                {
                    if (arrey[i, j] == 1 && arrey[i, j + 1] == 1)
                    {
                        rules = false;
                        break;
                    }
                }
                if (!rules) break;
            }
            if (rules == false)
            {
                return "Ограничительные меры, связанные с COVID-19, не соблюдены";
            }
            else
            {
                return "Ограничительные меры, связанные с COVID-19, соблюдены";
            }
        }
        public static (double[], double[], double, double) DoTaskFiveGetFinance(double[,] arrey)
        {
            string[] messages = new string[arrey.GetLength(0)];
            double amin = arrey[0, 0];
            double amax = arrey[0, 0];
            double[] sum_by_months = new double[6] { 0, 0, 0, 0, 0, 0 };
            double[] Sum_by_shop = new double[6] { 0, 0, 0, 0, 0, 0 };


            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                double sum_by_shop = 0;
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    sum_by_shop += arrey[i, j];
                    sum_by_months[j] += arrey[i, j];

                    if (arrey[i, j] < amin) amin = arrey[i, j];
                    if (arrey[i, j] > amax) amax = arrey[i, j];
                }
                for (int k = 0; k < Sum_by_shop.GetLength(0); k++)
                {
                    Sum_by_shop[k] = sum_by_shop;
                }
                for (int n = 0; n < sum_by_months.Length; n++)
                {
                    sum_by_months [n] = sum_by_months[n] / arrey.GetLength(0);
                }
            }
            return (Sum_by_shop, sum_by_months, amin, amax);  
        }

        public static int DoTaskSix(int[,] arrey)
        {
            int count = 0;
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    int sosedi = (i > 0 ? arrey[i - 1, j] : 0)
                        + (i < arrey.GetLength(0) - 1 ? arrey[i + 1, j] : 0)
                        + (j > 0 ? arrey[i, j - 1] : 0)
                        + (j < arrey.GetLength(1) - 1 ? arrey[i, j + 1] : 0);
                    if (arrey[i, j] > sosedi)
                        count++;
                }
            }
            return count;
        }

        public static int[,] DoTaskSeven()
        {
            int[,] mas = new int[7, 7];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1 || i >= j && i >= mas.GetLength(0) - j - 1) ? 1 : 0;
                }
            }
            return mas;
        }
        public static void DoTaskEight(int[,] arrey1, int[,] arrey2)
        {
            if (arrey1.GetLength(1) == arrey2.GetLength(0))
            {
                int[,] arrey3 = new int[arrey1.GetLength(0), arrey2.GetLength(1)];
                for (int i = 0; i < arrey1.GetLength(0); i++)
                {
                    for (int j = 0; j < arrey2.GetLength(1); j++)
                    {
                        arrey3[i, j] = 0;
                        for (int k = 0; k < arrey1.GetLength(1); k++)
                        {
                            arrey3[i, j] += arrey1[i, k] * arrey2[k, j];
                        }
                    }
                }
                InputOutputHelper.PrintArreyInt(arrey3, " ");
            }
            else
            {
                InputOutputHelper.PrintMessage("Перемножение матриц невозможно");
            }
        }
    }
}


