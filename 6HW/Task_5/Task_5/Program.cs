using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5) Фирма имеет 10 магазинов.Доходы каждого магазина за полугодие(6 месяцев с номерами 0 - 5) хранятся в двумерном вещественном массиве.
            // Заполнить массив случайными вещественными числами.
            // Высчитать:
            // а) суммарный доход по каждому магазину;
            // б) средний доход по каждому месяцу;
            // в) мин.и макс. доход за весь период.
            // Примечание: для получения вещественного случайного числа можно использовать rnd.NextDouble(),
            // но он даст только случайное вещественное число между 0 и 1 (например, 0.53457623123123).
            // Для получения нужного вам вещественного числа, его можно умножить на большое целое число.Так вы получите уже большое вещественное число.

            Random rnd = new Random();
            double[,] amounts = new double[10, 6];
            for (int i = 0; i < amounts.GetLength(0); i++)
            {
                for (int j = 0; j < amounts.GetLength(1); j++)
                {
                    amounts[i, j] = rnd.NextDouble() * 700000 + 300000;      // 300 тыс. - 1 миллиона
                    Console.Write("{0:f2}\t", amounts[i, j]);
                }
                Console.WriteLine();
            }
            double[] sum_by_months = new double[6] { 0, 0, 0, 0, 0, 0 };

            double amin = amounts[0, 0];
            double amax = amounts[0, 0];

            for (int i = 0; i < amounts.GetLength(0); i++)
            {
                double sum_by_shop = 0;
                for (int j = 0; j < amounts.GetLength(1); j++)
                {
                    sum_by_shop += amounts[i, j];
                    sum_by_months[j] += amounts[i, j];

                    if (amounts[i, j] < amin) amin = amounts[i, j];
                    if (amounts[i, j] > amax) amax = amounts[i, j];
                }
                Console.WriteLine("Сумма по {0}-му магазину = {1:f2}", i + 1, sum_by_shop);
            }

            Console.WriteLine("Средний доход по месяцам:");
            for (int i = 0; i < sum_by_months.Length; i++)
            {
                Console.WriteLine("{0}-й месяц: {1:f2}", i + 1, sum_by_months[i] / amounts.GetLength(0));
            }
            Console.WriteLine("Мин. доход = {0:f2}", amin);
            Console.WriteLine("Макс. доход = {0:f2}", amax);
        }
    }
}
