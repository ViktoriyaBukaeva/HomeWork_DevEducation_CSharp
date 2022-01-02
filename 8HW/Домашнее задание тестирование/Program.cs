using System;
using System.Collections.Generic;

namespace Домашнее_задание_тестирование
{
    class Program
    {
        static void Main(string[] args)
        {
            ////задача 1 ДЗ 1
            //int a_1_1 = InputOutputHelper.InputInt("введите значение a ");
            //int b_1_1 = InputOutputHelper.InputInt("введите значение b ");
            //List<string> result1_1 = MethodiHomeWorkOne.GetListHelloandBy_Task1(a_1_1, b_1_1);
            //foreach (string i in result1_1)
            //{
            //    Console.WriteLine(i);
            //}

            //////задача 2 ДЗ 2
            //try
            //{
            //    double a = InputOutputHelper.InputDouble("Введите координату 1: ");
            //    double b = InputOutputHelper.InputDouble("Введите координату 2: ");
            //    double r = InputOutputHelper.InputDouble("Введите радиус: ");
            //    bool result = MethodiHomeWorkTwo.FindaShotintheRadius_Task2(r, a, b);
            //    InputOutputHelper.PrintMessage(result.ToString()); // привела bool к строке 
            //}
            //catch (ArgumentException ex)
            //{
            //    InputOutputHelper.PrintMessage($"Возникла ошибка:{ex.Message}");
            //}
                  

            ////задача 2 ДЗ 3
            //double x_2_3 = InputOutputHelper.InputDouble("введите значение x = ");
            //double y_2_3 = InputOutputHelper.InputDouble("введите значение y = ");
            //try
            //{
            //    int res = MethodiHomeWorkThree.DetermineQuadrantTask_2(x_2_3, y_2_3);
            //    InputOutputHelper.PrintMessage($"Точка находится в {res} четверти оси координат.");
            //}
            //catch (Exception ex)
            //{
            //    InputOutputHelper.PrintMessage($"Возникла ошибка: {ex.Message}");
            //}
            ////или чтоб сразу
            ////    try
            ////{

            ////    InputOutputHelper.PrintMessage($"Точка находится в {MethodiHomeWorkThree.DoTaskTwo(12, 13)} четверти оси координат.");
            ////}
            ////catch (Exception ex)
            ////{
            ////    InputOutputHelper.PrintMessage($"Возникла ошибка: {ex.Message}");
            ////}



            //задача 3 ДЗ 3
            //double A_3_3 = InputOutputHelper.InputDouble("Введите любое число A: ");
            //double B_3_3 = InputOutputHelper.InputDouble("Введите любое число B: ");
            //double C_3_3 = InputOutputHelper.InputDouble("Введите любое число C: ");
            //(double min, double medium, double max) = MethodiHomeWorkThree.ReplaceNumberfromMinToMaxTask_3(13.1, 7.5, 3.53);
            //InputOutputHelper.PrintMessage($"{min}, {medium}, {max}");

            ////задача 4 ДЗ 3
            //double A_4 = InputOutputHelper.InputDouble("введите значение a = ");
            //double B_4 = InputOutputHelper.InputDouble("введите значение b = ");
            //double C_4 = InputOutputHelper.InputDouble("введите значение c = ");
            //double[] arrey = MethodiHomeWorkThree.ResolveQuadEquationTask_4(3, 4, 5);
            //InputOutputHelper.PrintArreyDouble(arrey);


            //////Задача 5 ДЗ 3
            //try
            //{
            //    //int num = InputOutputHelper.InputSaveInt("Введите двухзначное число больше 10: ", 10, 99);
            //    int num = InputOutputHelper.InputInt("Введите двухзначное число больше 10: ");
            //    string result5_3 = MethodiHomeWorkThree.GetUppercaseofNumberTask_5(num);
            //    InputOutputHelper.PrintMessage(result5_3);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    InputOutputHelper.PrintMessage($"Возникла ошибка:{ex.Message}");
            //}

          
            ////Задача 6 ДЗ 3
            //double A_6_3 = InputOutputHelper.InputDouble("Введите любое число A: ");
            //double B_6_3 = InputOutputHelper.InputDouble("Введите любое число B: ");
            //double C_6_3 = InputOutputHelper.InputDouble("Введите любое число C: ");
            //bool result6_3 = MethodiHomeWorkThree.DetermineTriangleTask_6(A_6_3, B_6_3, C_6_3);
            //if (result6_3)
            //{
            //    InputOutputHelper.PrintMessage("Треугольник существует");
            //}
            //else
            //{
            //    InputOutputHelper.PrintMessage("Треугольник не существует");
            //}

            ////______________________________________________________________

            ////////Задача 1 ДЗ 4
            //int A_1_4 = InputOutputHelper.InputSaveInt("Введите делитель: ", 1, 1000);
            //try // попытка выполнения кода метода, если что дальше поймай ошибку
            //{
            //    List<int> res = MethodiHomeWorkFour.GetNumbersDevidedOnNumTask_1(A_1_4);
            //    foreach (int i in res) // для каждого из коллекции выведи на экран
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    InputOutputHelper.PrintMessage($"Возникла ошибка: {ex.Message}");
            //}

            ////Задача 2 ДЗ 4
            //int A_2_4 = InputOutputHelper.InputInt("Введите положительное число: ");
            //int resultA_2_4 = MethodiHomeWorkFour.GetNumbersSquareOfWhichIsSmallerNum_Task2(A_2_4);
            //InputOutputHelper.PrintMeaningInt(resultA_2_4);

            ////Задача 3 ДЗ 4
            //double A_3_4 = InputOutputHelper.InputDouble("Введите целое положительное число: ");
            //double resultA_3_4 = MethodiHomeWorkFour.GetLargestDivisorOfA_Task3(A_3_4);
            //InputOutputHelper.PrintMeaningDouble(resultA_3_4);

            ////Задача 4 ДЗ 4
            //int a_4_4_1 = InputOutputHelper.InputInt("Введите целое число а: ");
            //int b_4_4_2 = InputOutputHelper.InputInt("Введите целое число b: ");
            //int result4_4 = MethodiHomeWorkFour.SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4(a_4_4_1, b_4_4_2);
            //InputOutputHelper.PrintMeaningInt(result4_4);

            ////Задача 5 ДЗ 4
            //int a_5_4_1 = InputOutputHelper.InputInt("Введите целое число а: ");
            //int b_5_4_2 = InputOutputHelper.InputInt("Введите целое число b: ");
            //int result5_4 = MethodiHomeWorkFour.FindGreatestDivisorUsingEuclidAlgorithm_Task5(a_5_4_1, b_5_4_2);
            //InputOutputHelper.PrintMeaningInt(result5_4);

            ////Задача 6 ДЗ 4
            //int a_6_4 = InputOutputHelper.InputInt("Введите целое положительное число а: ");
            //int result6_4 = MethodiHomeWorkFour.FindNumberNByTheMethodOfHalfDivision_Task6(a_6_4);
            //InputOutputHelper.PrintMeaningInt(result6_4);

            ////// Задача 7 ДЗ 4
            //int a_7_4 = InputOutputHelper.InputSaveInt("Введите число а произвольной длины (5 - 8 цифр): ", 10000, 99999999);
            //int result7_4 = MethodiHomeWorkFour.FindNnumberofOddDigits_Task7(a_7_4);
            //InputOutputHelper.PrintMeaningInt(result7_4);

            ////// Задача 8 ДЗ 4
            //int a_8_4 = InputOutputHelper.InputInt("Введите посследовательность цифр: ");
            //int result8_4 = MethodiHomeWorkFour.GetNumberInReverse_Task8(a_8_4);
            //InputOutputHelper.PrintMeaningInt(result8_4);

            //// Задача 9 ДЗ 4
            //int a_9_4 = InputOutputHelper.InputInt("Введите целое положительное число N: ");
            //List<int> result9_4 = MethodiHomeWorkFour.СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9(a_9_4);
            //foreach (int i in result9_4)
            //{
            //    Console.WriteLine(i);
            //}

            //// Задача 10 ДЗ 4
            //int N1_10_4 = InputOutputHelper.InputInt("Введите целое число N1: ");
            //int N2_10_4 = InputOutputHelper.InputInt("Введите целое число N2: ");
            //string result10_4 = MethodiHomeWorkFour.FindSameNumbers_Task10(N1_10_4, N2_10_4);
            

            ////_____________________________________________________________________________
            //// Задача 1 ДЗ 5
            //int[] m1 = ArreysHelpers.CreateArreyInt(10, 0, 100);
            //InputOutputHelper.PrintArreyInt(m1);
            //(int, int) a1_5 = MethodiHomeWorkFive.NumberEvenandOddArrayElements_Task1(m1);
            //int count_even = a1_5.Item1;
            //int count_odd = a1_5.Item2;
            //InputOutputHelper.PrintMessage("количество четных числе в массиве = " + count_even);
            //InputOutputHelper.PrintMessage("количество нечетных числе в массиве = " + count_odd);

            //// Задача 5 ДЗ 5
            //int[] m5_1 = new int[5] { 1, 2, 3, 4, 5 };
            //InputOutputHelper.PrintArreyInt(m5_1);
            //int[] m5_2 = MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightBy1Element_Task5(m5_1);
            //InputOutputHelper.PrintArreyInt(m5_2); //результат работы со сдвигом на 1 элемент
            //int n = InputOutputHelper.InputInt("Введите число, на которое будет сдвинут массив: ");
            //int[] m5_3 = MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightByNElement_Task5(m5_2, n);
            ////InputOutputHelper.PrintArreyInt(m5_3); //результат работы со сдвигом на 3 элемента

            ////////// Задача 7 ДЗ 5
            //int[] m_7 = ArreysHelpers.CreateArreyInt(10, -100, 100);
            //InputOutputHelper.PrintArreyInt(m_7);
            //(int, int) a7_5 = MethodiHomeWorkFive.FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7(m_7);
            //int b7_5 = a7_5.Item1;
            //int c7_5 = a7_5.Item2;      
            //InputOutputHelper.PrintMeaningInt(b7_5);
            //InputOutputHelper.PrintMeaningInt(c7_5);      

            ////____________________________________________________________________
            ////задача 4 домашка 6
            //int[,] mas = new int[3, 5]
            //{
            //{ 0, 1, 0, 1, 0 },
            //{ 1, 0, 1, 0, 1 },
            //{ 0, 0, 1, 1, 1 }
            //};
            //InputOutputHelper.PrintArreyInt(mas, " ");
            //bool rules = MethodiHomeWorkSix.CheckingComplianceWithRestrictionsCOVID_Task4(mas);
            //if (rules == false)
            //{
            //    InputOutputHelper.PrintMessage("Ограничительные меры, связанные с COVID-19, не соблюдены");
            //}
            //else
            //{
            //    InputOutputHelper.PrintMessage("Ограничительные меры, связанные с COVID-19, соблюдены");
            //}
            //// задача 5 домашка 6
            double[,] ArgumentFinanceReport = new double[5, 4]
            {
               { 5.00,  8.00,  8.00,  5.00},
               { 9.00,  9.00,  3.00,  5.00},
               { 1.00,  3.00,  4.00,  8.00},
               { 6.00,  2.00,  9.00,  3.00},
               { 4.00,  1.00,  7.00,  2.00},
            };
            (double[], double[], double, double)A_5_6 = MethodiHomeWorkSix.GetFinance_Task5(ArgumentFinanceReport);
            double[] b5_6 = A_5_6.Item1;
            double[] c5_6 = A_5_6.Item2;
            InputOutputHelper.PrintArreyDouble(b5_6);
            InputOutputHelper.PrintArreyDouble(c5_6);


            ////// задача 8 домашка 6
            //int[,] mas8_1 = ArreysHelpers.CreateBivariateRandomArrey(2, 3);
            //int[,] mas8_2 = ArreysHelpers.CreateBivariateRandomArrey(3, 2);
            //InputOutputHelper.PrintArreyInt(mas8_1, " ");
            //InputOutputHelper.PrintArreyInt(mas8_2, " ");
            //try // попытка выполнения кода метода, если что дальше поймай ошибку
            //{
            //    int[,] mas8_3 = MethodiHomeWorkSix.DoTaskEight(mas8_1, mas8_2);
            //    InputOutputHelper.PrintArreyInt(mas8_3, " ");
            //}
            //catch (Exception ex)
            //{
            //    InputOutputHelper.PrintMessage($"Возникла ошибка: {ex.Message}");
            //}
        }
    }
}
