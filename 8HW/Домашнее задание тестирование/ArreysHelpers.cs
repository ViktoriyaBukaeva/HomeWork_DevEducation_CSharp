using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class ArreysHelpers
    {
        public static int[,] CreateBivariateRandomArrey(int a, int b)
        {
            Random rnd = new Random();
            int[,] mas1 = new int[a, b];
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    mas1[i, j] = rnd.Next(0, 100);
                }
            }
            return mas1;
        }
        public static double[,] CreateBivariateRandomArreyDouble1000(int a, int b)
        {
            Random rnd = new Random();
            double[,] arrey = new double[a, b];
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    arrey[i, j] = rnd.NextDouble() * 1000;
                }
            }
            return arrey;
        }
        public static int[] CreateArreyInt(int size, int a, int b)
        {
            Random rnd = new Random();
            int[] arrey = new int[size];
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                arrey[i] = rnd.Next(a, b);
            }
            return arrey;
        }
    }
}
