using FakeItEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Домашнее_задание_тестирование;

namespace MethodiHomeWorkTests
{
    class MethodiHomeWorkOneTests
    {
        [TestCase(10, 0)]
        [TestCase(-5, -2)]
        [TestCase(-1, -0.5)]
        [TestCase(100, 1.2)]
        public void GetListHelloandBy_Task1Test(int a, double b)
        {
            List<string> expected = new List<string> { $"привет, { a } !", $"{ a } + { b } = { a + b }", $"пока, { b } ..." };
            List<string> actual = MethodiHomeWorkOne.GetListHelloandBy_Task1(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, 1, -8)]
        [TestCase(6, 8, 2063)]
        [TestCase(5, 2, -13.6)]
        [TestCase(3, 4, 271)]
        [TestCase(1.2, 3.2, 55.42)]

        public void SolveEquation_Task2Test(double a, double b, double expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkOne.SolveEquation_Task2(a, b), 0.1);
        }
        [TestCase(0, 0)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        public void SolveEquation_Task2NegativeTest(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => MethodiHomeWorkOne.SolveEquation_Task2(a, b));
        }

        [TestCase("1", "0", "0", "1")]
        [TestCase("0.1", "-3.1", "-3.1", "0.1")]
        [TestCase("c", "b", "b", "c")]
        [TestCase("!", ",", ",", "!")]
        [TestCase("A", "i", "i", "A")]
        public void RepleaceMeaning_Task_3Test(string s1, string s2, string expected, string expected2)
        {
            Assert.AreEqual((expected, expected2), MethodiHomeWorkOne.RepleaceMeaning_Task_3(s1, s2));
        }
        [TestCase(9, 5, 2, -0.33)]
        [TestCase(6, 2, 8, 1)]
        [TestCase(-3, -1, -6, 1.66)]
        [TestCase(0.25, 1.33, -9.88, -44.84)]
        public void SolveLinearEquation_Task4Test(double a, double b, double c, double expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkOne.SolveLinearEquationTask_4(a, b, c), 0.1);
        }

    }
}
