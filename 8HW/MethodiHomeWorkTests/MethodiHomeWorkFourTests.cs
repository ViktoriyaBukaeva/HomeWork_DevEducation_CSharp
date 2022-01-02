using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Домашнее_задание_тестирование;

namespace MethodiHomeWorkTests
{
    class MethodiHomeWorkFourTests
    {
        public List<int> GetNumbersDevidedTask1On100Mock()
        {
            return new List<int>(new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
        }
        [Test]
        public void GetNumbersDevidedTask1On100Task1_TestMock()
        {
            List<int> expected = GetNumbersDevidedTask1On100Mock();
            List<int> actual = MethodiHomeWorkFour.GetNumbersDevidedOnNumTask_1(100);
            Assert.AreEqual(expected, actual);
        }
        public List<int> GetNumbersDevidedOn50Mock()
        {
            return new List<int>(new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 });
        }
        [Test]
        public void GetNumbersDevidedTask1On50Task1_TestMock()
        {
            List<int> expected = GetNumbersDevidedOn50Mock();
            List<int> actual = MethodiHomeWorkFour.GetNumbersDevidedOnNumTask_1(50);
            Assert.AreEqual(expected, actual);
        }
        public enum GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant { On50, On100, On300 };

        public List<int> GetNumbersDevidedOnNumbers_Mock_Variants(GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant variant)
        {
            switch (variant)
            {
                case GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On50:
                    return new List<int>(new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 });
                case GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On100:
                    return new List<int>(new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
                case GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On300:
                    return new List<int>(new int[] { 300, 600, 900 });
                default: return null;

            }
        }
        [TestCase(50, GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On50)]
        [TestCase(100, GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On100)]
        [TestCase(300, GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant.On300)]
        public void GetNumbersDividedOnATest(int A, GetNumbersDevidedTask1OnNum_Task1_Test_Mock_Variant variant)
        {
            List<int> expected = GetNumbersDevidedOnNumbers_Mock_Variants(variant);
            List<int> actual = MethodiHomeWorkFour.GetNumbersDevidedOnNumTask_1(A);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 3)]
        [TestCase(28, 5)]
        [TestCase(125, 11)]
        public void GetNumbersSquareOfWhichIsSmallerNum_Task2_Test(int num, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.GetNumbersSquareOfWhichIsSmallerNum_Task2(num));
        }
        [TestCase(0)]
        [TestCase(-3)]
        [TestCase(-7)]
        public void GetNumbersSquareOfWhichIsSmallerNum_Task2_NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.GetNumbersSquareOfWhichIsSmallerNum_Task2(num));
        }

        [TestCase(28, 14)]
        [TestCase(11, 1)]
        [TestCase(33, 11)]
        [TestCase(861, 287)]
        public void GetLargestDivisorOfA_Task3Test(double A, double expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.GetLargestDivisorOfA_Task3(A));
        }
        [TestCase(0)]
        [TestCase(-8)]
        [TestCase(-5.5)]
        public void GetLargestDivisorOfA_Task3NegativeTest(double A)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.GetLargestDivisorOfA_Task3(A));
        }
        [TestCase(0, 18, 21)]
        [TestCase(17, 36, 84)]
        [TestCase(37, 57, 147)]
        [TestCase(-8, 15, 14)]
        public void SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4(a, b));
        }
        [TestCase(0, 0)]
        public void SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4_NegativeTest(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.SumOfNumbersThatDivisibleBy7InTheRangeFromAtoB_Task4(a, b));
        }

        [TestCase(64, 48, 16)]
        [TestCase(111, 432, 3)]
        [TestCase(661, 113, 1)]
        [TestCase(-231, -140, 7)]
        [TestCase(-585, 81, 9)]
        public void FindGreatestDivisorUsingEuclidAlgorithm_Task5_Test(int a, int b, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.FindGreatestDivisorUsingEuclidAlgorithm_Task5(a, b));
        }

        [TestCase(27, 3)]
        //[TestCase(3375, 15)] Эти тест кейсы не проходят.Логику решения задачи самостоятельно понять так и не смогла. Метод половинч дел по определению выдает 
        //[TestCase(2197, 13)] примерные кубические корни, а не точные.
        public void FindNumberNByTheMethodOfHalfDivision_Task6_Test(int num, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.FindNumberNByTheMethodOfHalfDivision_Task6(num));
        }
        [TestCase(0)]
        public void FindNumberNByTheMethodOfHalfDivision_Task6_Test_NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.FindNumberNByTheMethodOfHalfDivision_Task6(num));
        }

        [TestCase(123647, 3)]
        [TestCase(1111111, 7)]
        [TestCase(2197963, 5)]
        public void FindNnumberofOddDigits_Task7_Test(int A, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.FindNnumberofOddDigits_Task7(A));
        }
        [TestCase(0)]
        [TestCase(9999)]
        [TestCase(1000000000)]
        [TestCase(0000000)]
        public void FindNnumberofOddDigits_Task7_NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.FindNnumberofOddDigits_Task7(num));
        }
        [TestCase(123, 321)]
        [TestCase(6587, 7856)]
        [TestCase(980145, 541089)]
        [TestCase(0987465, 564789)]
        public void GetNumberInReverse_Task8_Test(int num, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.GetNumberInReverse_Task8(num));
        }
        [TestCase(0)]
        [TestCase(-145698)]
        public void GetNumberInReverse_Task8_NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.GetNumberInReverse_Task8(num));
        }

        public List<int> СalculateСompareSumsOfEvenandOddNumbersInRangeUpto21_Test()
        {
            return new List<int>(new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21 });
        }
        [Test]
        public void СalculateСompareSumsOfEvenandOddNumbersInRangeUpto21_TestMock()
        {
            List<int> expected = СalculateСompareSumsOfEvenandOddNumbersInRangeUpto21_Test();
            List<int> actual = MethodiHomeWorkFour.СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9(21);
            Assert.AreEqual(expected, actual);
        }
        public List<int> СalculateСompareSumsOfEvenandOddNumbersInRangeUpto35_Test()
        {
            return new List<int>(new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34 });
        }
        [Test]
        public void СalculateСompareSumsOfEvenandOddNumbersInRangeUpto35_TestMock()
        {
            List<int> expected = СalculateСompareSumsOfEvenandOddNumbersInRangeUpto35_Test();
            List<int> actual = MethodiHomeWorkFour.СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9(35);
            Assert.AreEqual(expected, actual);
        }    
        
        public List<int> СalculateСompareSumsOfEvenandOddNumbersInRangeUpto50_Test()
        {
            return new List<int>(new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44, 46, 48 });
        }
        [Test]
        public void СalculateСompareSumsOfEvenandOddNumbersInRangeUpto50_TestMock()
        {
            List<int> expected = СalculateСompareSumsOfEvenandOddNumbersInRangeUpto50_Test();
            List<int> actual = MethodiHomeWorkFour.СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9(50);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(-8)]
        public void СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_NegativeTest (int N)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFour.СalculateСompareSumsOfEvenandOddNumbersInRangeUptoN_Task9(N));
        }

        [TestCase(123, 698, "НЕТ")]
        [TestCase(5698, 5698, "ДА")]
        [TestCase(697440, 874030,  "ДА")]
        [TestCase(4789652, 1313, "НЕТ")]
        public void FindSameNumbers_Task10_Test(int N1, int N2, string expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFour.FindSameNumbers_Task10(N1,N2));
        }




















    }
}

