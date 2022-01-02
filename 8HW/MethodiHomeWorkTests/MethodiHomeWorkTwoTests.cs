using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Домашнее_задание_тестирование;

namespace MethodiHomeWorkTests
{
    class MethodiHomeWorkTwoTests
    {
        [TestCase(145, 10)]
        [TestCase(398, 20)]
        [TestCase(649, 19)]
        [TestCase(111, 3)]
        [TestCase(763, 16)]
        public void SumOfThreeDigitNumber_Task1Test(int num, int expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkTwo.SumOfThreeDigitNumber_Task1(num));
        }
        [TestCase(1000)]
        [TestCase(99)]
        [TestCase(87)]
        [TestCase(1001)]
        [TestCase(-999)]
        public void SumOfThreeDigitNumber_Task1NegativeTest(int num)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkTwo.SumOfThreeDigitNumber_Task1(num));
        }

        [TestCase(8, 2, 5, true)]
        [TestCase(-7, -3, -3, true)]
        [TestCase(-0.1, 2.5, -2.5, false)]
        [TestCase(11, 12, 13, false)]
        public void FindaShotintheRadius_Task2Test(double radius, double x1, double y1, bool excepted)
        {
            Assert.AreEqual(excepted, MethodiHomeWorkTwo.FindaShotintheRadius_Task2(radius, x1, y1));
        }

        [TestCase(0, 2, 5)]
        [TestCase(0, -8, 5)]
        public void FindaShotintheRadius_Task2NegativeTest(double radius, double x1, double y1)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkTwo.FindaShotintheRadius_Task2(radius, x1, y1));
        }

        [TestCase(431, true)]
        [TestCase(965, true)]
        [TestCase(665, true)]
        [TestCase(667, false)]
        [TestCase(123, false)]
        public void СompareAverageNumberwithExtremes_Task3Test(int sum, bool excepted)
        {
            Assert.AreEqual(excepted, MethodiHomeWorkTwo.СompareAverageNumberwithExtremes_Task3(sum));
        }
        [TestCase(1000)]
        [TestCase(99)]
        public void СompareAverageNumberwithExtremes_Task3NegativeTest(int sum)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkTwo.СompareAverageNumberwithExtremes_Task3(sum));
        }

        [TestCase(431, 134)]
        [TestCase(965, 569)]
        [TestCase(665, 566)]
        [TestCase(667, 766)]
        [TestCase(123, 321)]
        public void ChangePlaceForLastandFirstNumber_Task4Test(int sum, int excepted)
        {
            Assert.AreEqual(excepted, MethodiHomeWorkTwo.ChangePlaceForLastandFirstNumber_Task4(sum));
        }

        [TestCase(1000)]
        [TestCase(99)]
        public void ChangePlaceForLastandFirstNumber_Task4NegativeTest(int sum)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkTwo.ChangePlaceForLastandFirstNumber_Task4(sum));
        }
        [TestCase(156.0, true)]
        [TestCase(156.2, false)]
        [TestCase(-156.0, true)]
        [TestCase(-156.2, false)]
        [TestCase(0, true)]
        public void CheckFractionalPartOfTheNumber_Task5(double num, bool expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkTwo.CheckFractionalPartOfTheNumber_Task5(num));
        }







    }
}

