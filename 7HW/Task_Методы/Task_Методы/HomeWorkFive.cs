using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Методы
{
    class HomeWorkFive
    {
        public static void DoTaskOne(int[] m1)
        {
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
            InputOutputHelper.PrintMessage("количество четных числе в массиве = " + count_even);
            InputOutputHelper.PrintMessage("количество нечетных числе в массиве = " + count_odd);
        }
        public static int[] DoTaskTwo(int[] m1)
        {
            for (int i = 0; i < m1.Length - 1; i = i + 3)
            {
                int a = i;
                int b = i + 1;
                int c = i + 2;
                m1[c] = m1[a] + m1[b];
            }
            return m1;
        }
        public static int[] DoTaskThree(int[] m1, int[] m2)
        {
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
        public static int[] DoTaskFour(int[] m1)
        {
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
        public static int[] DoTaskFive(int[] m1)
        { // сдвиг на 1 элемент
            int a = m1[0];
            for (int i = 0; i < m1.Length - 1; i++)
            {
                m1[i] = m1[i + 1];
            }
            m1[m1.Length - 1] = a;
            return m1;
        }
        public static int[] DoTaskFive_1(int[] m1)
        { // сдвиг на N элементов
            int a = m1[0];
            int n = 3;
            for (int j = 0; j < n; j++)
            {
                a = m1[0];
                for (int i = 0; i < m1.Length - 1; i++)
                {
                    m1[i] = m1[i + 1];
                }
                m1[m1.Length - 1] = a;
            }
            return m1;
        }
        public static int[] DoTaskSix(int[] m1)
        {
            for (int i = 0; i < m1.Length - 1; i = i + 2)
            {
                int tmp = m1[i];
                m1[i] = m1[i + 1];
                m1[i + 1] = tmp;
            }
            return m1;
        }
        public static void DoTaskSeven(int[] m1)
        {
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
            InputOutputHelper.PrintMeaningInt(min);
            InputOutputHelper.PrintMeaningInt(sum);
        }
        public static int[] DoTaskEight(int[] m1)
        {
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
        public static int[] DoTaskNine(int[] m1)
        {
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

