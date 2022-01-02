using NUnit.Framework;
using System;
using Домашнее_задание_тестирование;

namespace MethodiHomeWorkTests
{
    public class MethodiHomeWorkThreeTests
    {
        [TestCase(5.3, 4.1, 9.4)]
        [TestCase(3.2, 3.2, 10.24)]
        [TestCase(9, 10, -1)]
        [TestCase(-9.1, -10.2, -19.3)]
        [TestCase(0, 0, 0)]

        public void CompareCalculateAandBTask_1Test(double a, double b, double expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkThree.CompareCalculateAandBTask_1(a, b), 0.1); //указываем дельту (допустимое отклонение присравнении чисел)
        }
        [TestCase(2.5, -1.6, 2)]
        [TestCase(-2.5, 1.6, 4)]
        [TestCase(-2.5, -1.6, 3)]
        [TestCase(2.5, 1.6, 1)]
        public void DetermineQuadrantTask_2_Test(double x, double y, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkThree.DetermineQuadrantTask_2(x, y));
        }
        [TestCase(0, 2)]
        [TestCase(5, 0)]
        public void DetermineQuadrantTask_2NegativeTest(double x, double y)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkThree.DetermineQuadrantTask_2(x, y));
        }

        [TestCase(1.1, 3.2, 2.3, 1.1, 2.3, 3.2)]
        [TestCase(4.1, 3.5, 6.2, 3.5, 4.1, 6.2)]
        [TestCase(-3.1, 1, 0.1, -3.1, 0.1, 1)]
        [TestCase(13.1, 7.5, 3.53, 3.53, 7.5, 13.1)]
        [TestCase(-8, 21, 13, -8, 13, 21)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        public void ReplaceNumberfromMinToMaxTask_3_Test(double num1, double num2, double num3, double expected1, double expected2, double expected3)
        {
            Assert.AreEqual((expected1, expected2, expected3), MethodiHomeWorkThree.ReplaceNumberfromMinToMaxTask_3(num1, num2, num3));
        }

        [TestCase(1, -4, -5, new double[] { 5, -1 })]
        [TestCase(-1, 7, 8, new double[] { -1, 8 })]
        [TestCase(1, -6, 9, new double[] { 3 })]
        [TestCase(4, 4, 1, new double[] { -0.5 })]
        [TestCase(3, -4, 2, new double[] { })]
        [TestCase(3, 2, 3, new double[] { })]
        public void ResolveQuadEquationTask_4Test(double a, double b, double c, double[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkThree.ResolveQuadEquationTask_4(a, b, c));
        }

        [TestCase(10, "десять")]
        [TestCase(99, "девяносто девять")]
        [TestCase(15, "пятнадцать")]
        [TestCase(25, "двадцать пять")]
        [TestCase(36, "тридцать шесть")]
        public void GetUppercaseofNumberTask_5Test(int num, string expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkThree.GetUppercaseofNumberTask_5(num));
        }
        [TestCase(9)]
        [TestCase(100)]
        [TestCase(150)]
        [TestCase(-55)]
        public void GetUppercaseofNumberTask_5NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkThree.GetUppercaseofNumberTask_5(num));
        }

        [TestCase(5, 2, 4, true)]
        [TestCase(3, 4, 6, true)]
        [TestCase(9, 12, 14, true)]
        [TestCase(1, 2, 5, false)]
        [TestCase(1, 2, 3, false)]
        [TestCase(1, 2, 4, false)]
        public void DetermineTriangleTask_6Test(double a, double b, double c, bool expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkThree.DetermineTriangleTask_6(a, b, c));
        }
    }
}