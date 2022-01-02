using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7) В массиве из целочисленных элементов(включая отрицательные) вычислить:
            // а) минимальный по модулю элемент массива;
            // б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!

            int[] m2 = new int[5] { 3, 1, 2, 5, 9 };
            int min = (Math.Abs(m2[0]));
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < m2.Length; i++)
            {
                int a = Math.Abs(m2[i]); //а) минимальный по модулю элемент массива;
                if (a < min)
                {
                    min = a;
                }
                if (flag == true) //б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!
                {
                    sum += m2[i];
                }
                else
                {
                    if (m2[i] == 0)
                    {
                        flag = true;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
    }
}
