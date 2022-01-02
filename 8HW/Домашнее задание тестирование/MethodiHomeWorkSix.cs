using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkSix
    {
        public static int[,] ChangeTheSignArrayElementsEdgesTOpposite_Task1(int[,] arrey)
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
        public static int[,] CreateMultiplicationTable_Task_2()
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
        public static int[,] FillMatrixNxNZerosAnOnesInFormChessboard_Task3(int M)
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
        public static bool CheckingComplianceWithRestrictionsCOVID_Task4(int[,] arrey)
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
            return rules;
        }
        public static (double[], double[], double, double) GetFinance_Task5(double[,] arrey)
        {
            double amin = arrey[0, 0];
            double amax = arrey[0, 0];
            double[] sum_by_months = new double[arrey.GetLength(1)];
            double[] Sum_by_shop = new double[arrey.GetLength(0)];


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
                Sum_by_shop[i] = sum_by_shop;
            }
            for (int n = 0; n < sum_by_months.Length; n++)
            {
                sum_by_months[n] = sum_by_months[n] / arrey.GetLength(0);
            }
            return (Sum_by_shop, sum_by_months, amin, amax);
        }

        public static int FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6(int[,] arrey)
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

        public static char[,] FillInAnHourglassShapedarray_Task7(int M)
        {
            char[,] mas = new char[M, M];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1 || i >= j && i >= mas.GetLength(0) - j - 1) ? '*' : '-';
                }
            }
            return mas;
        }
        public static int[,] ImplementMultiplicationOfMatricesOfIntegers_Task8 (int[,] arrey1, int[,] arrey2)
        {
            if (arrey1.GetLength(0) != arrey2.GetLength(1))
            {
                throw new ArgumentException("Перемножение матриц невозможно");
            }

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
                return arrey3;
            }
            else
            {
                throw new ArgumentException("Перемножение матриц невозможно");
            }
        }
    }
}
