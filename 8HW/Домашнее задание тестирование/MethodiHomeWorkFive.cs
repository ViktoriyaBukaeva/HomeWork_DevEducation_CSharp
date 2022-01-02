using System;
using System.Collections.Generic;
using System.Text;

namespace Домашнее_задание_тестирование
{
    public class MethodiHomeWorkFive
    {
        public static (int, int) NumberEvenandOddArrayElements_Task1(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            int count_even = 0;
            int count_odd = 0;
            for (int i = 0; i < m1.Length; i++)
            {
                if (m1[i] % 2 == 0)
                {
                    count_even++;
                }
                else
                {
                    count_odd++;
                }
            }
            return (count_even, count_odd);
        }
        public static int[] ReplaceTthirdElementArraySumOfPreviousTwo_Task2(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            for (int i = 0; i < m1.Length - 1; i = i + 3)
            {
                int a = i;
                int b = i + 1;
                int c = i + 2;
                m1[c] = m1[a] + m1[b];
            }
            return m1;
        }
        public static int[] MergeTwoArraysIntoOne_Task3(int[] m1, int[] m2)
        {
            if (m1 == null || m2 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            int[] m3 = new int[m1.Length + m2.Length];
            for (int i = 0; i < m3.Length; i++)
            {
                int num = 0;
                if (i < m1.Length)
                {
                    num = m1[i];
                }
                else
                {
                    int j = i - m1.Length;
                    num = m2[j];
                }
                m3[i] = num;
            }
            return m3;
        }
        public static int[] SwapFirstAndSecondHalfOfTheArray_Task4(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            int m1_pol = m1.Length / 2;
            int m2_pol = m1.Length - m1.Length / 2;
            for (int i = 0; i < m1_pol; i++)
            {
                int t = m1[i];
                m1[i] = m1[m2_pol + i];
                m1[m2_pol + i] = t;
            }
            return m1;
        }
        public static int[] CyclicallyShiftTheArrayToRightBy1Element_Task5(int[] m1)
        { // сдвиг на 1 элемент
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            int a = m1[m1.Length - 1];
            for (int i = m1.Length - 1; i >= 1; i--)
            {
                m1[i] = m1[i - 1];
            }
            m1[0] = a;
            return m1;
        }
        public static int[] CyclicallyShiftTheArrayToRightByNElement_Task5(int[] m1, int n)
        { // сдвиг на N элементов
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            for (int j = 0; j < n; j++)
            {
                int a = m1[m1.Length - 1];
                for (int i = m1.Length - 1; i >= 1; i--)
                {
                    m1[i] = m1[i - 1];
                }
                m1[0] = a;
            }
            return m1;
        }
        public static int[] ChangePositionsEvenElementsToOddOnesAndViceVersa_Task6(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            for (int i = 0; i < m1.Length - 1; i = i + 2)
            {
                int tmp = m1[i];
                m1[i] = m1[i + 1];
                m1[i + 1] = tmp;
            }
            return m1;
        }
        public static (int, int) FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            int min = (Math.Abs(m1[0]));
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < m1.Length; i++)
            {
                int a = Math.Abs(m1[i]); //а) минимальный по модулю элемент массива;
                if (a < min)
                {
                    min = a;
                }
                if (flag == true) //б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!
                {
                    sum += m1[i];
                }
                else
                {
                    if (m1[i] == 0)
                    {
                        flag = true;
                    }
                }
            }
            return (min, sum);
        }
        public static int[] ImplementArraySortingByTheInsertAlgorithm_Task8(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            for (int i = 1; i < m1.Length; i++)
            {
                int a = m1[i];
                int j = i;
                while (j > 0 && a < m1[j - 1])
                {
                    int tmp = m1[j];
                    m1[j] = m1[j - 1];
                    m1[j - 1] = tmp;
                    j--;
                }
            }
            return m1;
        }
        public static int[] ImplementArraySortingByTheSelectAlgorithm_Task9(int[] m1)
        {
            if (m1 == null)
            {
                throw new ArgumentException("Требуется передать заполненный массив");
            }
            for (int i = 0; i < m1.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < m1.Length; j++)
                {
                    if (m1[j] < m1[min])
                    {
                        min = j;
                    }
                }
                int tmp = m1[i];
                m1[i] = m1[min];
                m1[min] = tmp;
            }
            return m1;
        }
    }
}

