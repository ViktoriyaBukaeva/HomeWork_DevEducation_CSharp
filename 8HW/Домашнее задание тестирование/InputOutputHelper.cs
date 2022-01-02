using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class InputOutputHelper
    {
        public static int InputSaveInt(string message, int min, int max)
        {
            int InputNum;
            do
            {
                Console.Write(message);
                InputNum = Convert.ToInt32(Console.ReadLine());
            }
            while (min > InputNum || max < InputNum);
            return InputNum;
        }
        public static double InputSaveDouble(string message, double min, double max)
        {
            double InputNum;
            do
            {
                Console.Write(message);
                InputNum = Convert.ToDouble(Console.ReadLine());
            }
            while (min > InputNum || max < InputNum);
            return InputNum;
        }

        public static void PrintArreyInt(int[] arrey)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write($"{arrey[i]} ");
            }
            Console.WriteLine();
        }
        public static void PrintArreyInt(int[,] mas1, string space)
        {

            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    Console.Write($"{mas1[i, j]}{space}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintArreyDouble(double[] arrey)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write($"{arrey[i]} ");
            }
            Console.WriteLine();
        }
        public static void PrintArreyDouble(double[,] mas1)
        {

            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                {
                    Console.Write($"{mas1[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintMessages(string[] messages)
        {
            for (int i = 0; i < messages.Length; i++)
            {
                Console.WriteLine(messages[i]);
            }
        }
        public static int PrintSum(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine(sum);
            return sum;
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void PrintMeaningInt(int meaning)
        {
            Console.WriteLine(meaning);
        }

        public static void PrintMeaningDouble(double meaning)
        {
            Console.WriteLine(meaning);
        }

        public static double InputDouble(string message)
        {
            Console.Write(message);
            double x1 = Convert.ToDouble(Console.ReadLine());
            return x1;
        }
        public static int InputInt(string message)
        {
            Console.Write(message);
            int x1 = Convert.ToInt32(Console.ReadLine());
            return x1;
        }
    }
}
