using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Домашнее_задание_тестирование;


namespace MethodiHomeWorkTests
{
    class MethodiHomeWorkFiveTest
    {
        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, 3, 4)]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3 }, 0, 7)]
        [TestCase(new int[] { -3, -3, -3, -3, -3, -3, -3 }, 0, 7)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0 }, 7, 0)]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, 3, 4)]
        public void NumberEvenandOddArrayElements_Task1_Test(int[] m1, int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2), MethodiHomeWorkFive.NumberEvenandOddArrayElements_Task1(m1));
        }
        [Test]
        public void NumberEvenandOddArrayElements_Task1_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.NumberEvenandOddArrayElements_Task1(null));
        }

        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, new int[] { 1, 4, 5, 6, 9, 15, 7 })]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3 }, new int[] { 3, 3, 6, 3, 3, 6, 3 })]
        [TestCase(new int[] { -3, -3, -3, -3, -3, -3, -3 }, new int[] { -3, -3, -6, -3, -3, -6, -3 })]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, new int[] { 115, 116, 231, 224, 337, 561, 445 })]
        public void ReplaceTthirdElementArraySumOfPreviousTwo_Task2_Test(int[] m1, int[] expected)
        {
            Assert.AreEqual((expected), MethodiHomeWorkFive.ReplaceTthirdElementArraySumOfPreviousTwo_Task2(m1));
        }
        [Test]
        public void ReplaceTthirdElementArraySumOfPreviousTwo_Task2_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.ReplaceTthirdElementArraySumOfPreviousTwo_Task2(null));
        }

        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, new int[] { 1, 4, 5, 6, 9, 15, 7 }, new int[] { 1, 4, 5, 6, 9, 8, 7, 1, 4, 5, 6, 9, 15, 7 })]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3 }, new int[] { 3, 3, 6, 3, 3, 6, 3 }, new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 6, 3, 3, 6, 3 })]
        [TestCase(new int[] { -3, -3, -3, -3, -3, -3, -3 }, new int[] { -3, -3, -6, -3, -3, -6, -3 }, new int[] { -3, -3, -3, -3, -3, -3, -3, -3, -3, -6, -3, -3, -6, -3 })]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, new int[] { 115, 116, 231, 224, 337, 561, 445 }, new int[] { 115, 116, 221, 224, 337, 338, 445, 115, 116, 231, 224, 337, 561, 445 })]
        public void MergeTwoArraysIntoOne_Task3_Test(int[] m1, int[] m2, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.MergeTwoArraysIntoOne_Task3(m1, m2));
        }
        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, null)]
        [TestCase(null, new int[] {1, 4, 5, 6, 9, 8, 7 })]
        [TestCase(null, null)]
        public void MergeTwoArraysIntoOne_Task3__NegativeTest(int[] m1, int[] m2)
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.MergeTwoArraysIntoOne_Task3(m1, m2));
        }

        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, new int[] { 9, 8, 7, 6, 1, 4, 5 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, new int[] { 7, 6, 5, 8, 0, 1, 3 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, new int[] { -4, -3, -9, -5, -8, -2, -1 })]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, new int[] { 337, 338, 445, 224, 115, 116, 221 })]
        public void SwapFirstAndSecondHalfOfTheArray_Task4_Test(int[] m1, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.SwapFirstAndSecondHalfOfTheArray_Task4(m1));
        }
        [Test]
        public void SwapFirstAndSecondHalfOfTheArray_Task4_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.SwapFirstAndSecondHalfOfTheArray_Task4(null));
        }

        [TestCase(new int[] { 1, 4, 5, 6, 9, 8, 7 }, new int[] { 7, 1, 4, 5, 6, 9, 8 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, new int[] { 5, 0, 1, 3, 8, 7, 6 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, new int[] { -9, -8, -2, -1, -5, -4, -3 })]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, new int[] { 445, 115, 116, 221, 224, 337, 338 })]
        public void CyclicallyShiftTheArrayToRightBy1Element_Task5_Test(int[] m1, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightBy1Element_Task5(m1));
        }
        [Test]
        public void CyclicallyShiftTheArrayToRightBy1Element_Task5_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightBy1Element_Task5(null));
        }

        [TestCase(new int[] { 4, 5, 6, 9, 8, 7, 1 }, 3, new int[] { 8, 7, 1, 4, 5, 6, 9 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, 4, new int[] { 8, 7, 6, 5, 0, 1, 3 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, 2, new int[] { -3, -9, -8, -2, -1, -5, -4 })]
        [TestCase(new int[] { 115, 116, 221, 224, 337, 338, 445 }, 7, new int[] { 115, 116, 221, 224, 337, 338, 445 })]
        public void CyclicallyShiftTheArrayToRightByNElement_Task5_Test(int[] m1, int n, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightByNElement_Task5(m1, n));
        }
        [Test]
        public void CyclicallyShiftTheArrayToRightByNElement_Task5_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.CyclicallyShiftTheArrayToRightBy1Element_Task5(null));
        }

        [TestCase(new int[] { 4, 5, 6, 9, 8, 7, 1 }, new int[] { 5, 4, 9, 6, 7, 8, 1 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, new int[] { 1, 0, 8, 3, 6, 7, 5 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, new int[] { -2, -8, -5, -1, -3, -4, -9 })]
        [TestCase(new int[] { 115, 116, -221, 224, 337, -338, 445 }, new int[] { 116, 115, 224, -221, -338, 337, 445 })]
        public void ChangePositionsEvenElementsToOddOnesAndViceVersa_Task6(int[] m1, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.ChangePositionsEvenElementsToOddOnesAndViceVersa_Task6(m1));
        }
        [Test]
        public void ChangePositionsEvenElementsToOddOnesAndViceVersa_Task6_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.ChangePositionsEvenElementsToOddOnesAndViceVersa_Task6(null));
        }

        [TestCase(new int[] { 4, 5, 6, 9, 8, 7, 1 }, 1, 0)]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, 0, 30)]
        [TestCase(new int[] { -8, -2, -1, -5, 0, -3, -9 }, 0, -12)]
        [TestCase(new int[] { 115, 116, -221, 224, 0, -338, 445 }, 0, 107)]
        public void FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7_Test(int[] m1, int expected1, int expected2)
        {
            Assert.AreEqual((expected1, expected2), MethodiHomeWorkFive.FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7(m1));
        }
        [Test]
        public void FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.FindInArrayMinimumModuloElementAndSsumOfTheElementsAfterTheFirstZero_Task7(null));
        }

        [TestCase(new int[] { 4, 5, 6, 9, 8, 7, 1 }, new int[] { 1, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, new int[] { 0, 1, 3, 5, 6, 7, 8 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, new int[] { -9, -8, -5, -4, -3, -2, -1 })]
        [TestCase(new int[] { 115, 116, -221, 224, 337, -338, 445 }, new int[] { -338, -221, 115, 116, 224, 337, 445 })]
        public void ImplementArraySortingByTheInsertAlgorithm_Task8_Test(int[] m1, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.ImplementArraySortingByTheInsertAlgorithm_Task8(m1));
        }
        [Test]
        public void ImplementArraySortingByTheInsertAlgorithm_Task8_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.ImplementArraySortingByTheInsertAlgorithm_Task8(null));
        }

        [TestCase(new int[] { 4, 5, 6, 9, 8, 7, 1 }, new int[] { 1, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 0, 1, 3, 8, 7, 6, 5 }, new int[] { 0, 1, 3, 5, 6, 7, 8 })]
        [TestCase(new int[] { -8, -2, -1, -5, -4, -3, -9 }, new int[] { -9, -8, -5, -4, -3, -2, -1 })]
        [TestCase(new int[] { 115, 116, -221, 224, 337, -338, 445 }, new int[] { -338, -221, 115, 116, 224, 337, 445 })]

        public void ImplementArraySortingByTheSelectAlgorithm_Task9_Test(int[] m1, int[] expected)
        {
            Assert.AreEqual(expected, MethodiHomeWorkFive.ImplementArraySortingByTheSelectAlgorithm_Task9(m1));
        }
        [Test]
        public void ImplementArraySortingByTheSelectAlgorithm_Task9_NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkFive.ImplementArraySortingByTheSelectAlgorithm_Task9(null));
        }









    }
}
