using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Домашнее_задание_тестирование;

namespace MethodiHomeWorkTests
{
    class MethodiHomeWorkSixTests
    {
        public enum ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock { On4x3, On3x3 };

        public int[,] ChangeTheSignArrayElementsEdgesTOpposite_Task1_Mock(ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock variant)
        {
            switch (variant)
            {
                case ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock.On4x3:
                    return new int[,] {
                        {-1, -2, -2, -1},
                        {-1,  2,  2, -1},
                        {-1, -2, -2, -1}
                    };
                case ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock.On3x3:
                    return new int[,] {
                        {-1, -2, -1},
                        {-1,  2, -1},
                        {-1, -2, -1}
                    };
                default: return null;
            }
        }
        public enum ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument { On4x3, On3x3 };
        public int[,] ChangeTheSignArrayElementsEdgesTOpposite_Task1_Argument(ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument variant)
        {
            switch (variant)
            {
                case ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument.On4x3:
                    return new int[,] {
                        {1, 2, 2, 1},
                        {1, 2, 2, 1},
                        {1, 2, 2, 1}
                    };
                case ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument.On3x3:
                    return new int[,] {
                        {1, 2, 1},
                        {1, 2, 1},
                        {1, 2, 1}
                    };
                default: return null;
            }
        }
        [TestCase(ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument.On4x3,
            ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock.On4x3)]
        [TestCase(ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument.On3x3,
            ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock.On3x3)]
        public void ChangeTheSignArrayElementsEdgesTOpposite_Task1_Test(ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforArgument enter, ChangeTheSignArrayElementsEdgesTOpposite_Task1_VariantsforMock exit)
        {
            int[,] expected = ChangeTheSignArrayElementsEdgesTOpposite_Task1_Mock(exit);
            int[,] argument = ChangeTheSignArrayElementsEdgesTOpposite_Task1_Argument(enter);
            int[,] actual = MethodiHomeWorkSix.ChangeTheSignArrayElementsEdgesTOpposite_Task1(argument);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreateMultiplicationTable_Task_2()
        {
            int[,] expected = new int[9, 9]
            {
                { 1, 2,  3,  4,  5,  6,  7,  8,  9 },
                { 2, 4,  6,  8,  10, 12, 14, 16, 18 },
                { 3, 6,  9,  12, 15, 18, 21, 24, 27 },
                { 4, 8,  12, 16, 20, 24, 28, 32, 36 },
                { 5, 10, 15, 20, 25, 30, 35, 40, 45 },
                { 6, 12, 18, 24, 30, 36, 42, 48, 54 },
                { 7, 14, 21, 28, 35, 42, 49, 56, 63 },
                { 8, 16, 24, 32, 40, 48, 56, 64, 72 },
                { 9, 18, 27, 36, 45, 54, 63, 72, 81 }
            };
            int[,] actual = MethodiHomeWorkSix.CreateMultiplicationTable_Task_2();
            Assert.AreEqual(expected, actual);
        }

        public enum FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock { On3x3, On4x4 };
        public int[,] FillMatrixNxNZerosAnOnesInFormChessboard_Task3_Mock(FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock variant)
        {
            switch (variant)
            {
                case FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock.On4x4:
                    return new int[,] {
                        {1, 0, 1, 0},
                        {0, 1, 0, 1},
                        {1, 0, 1, 0},
                        {0, 1, 0, 1}
                    };
                case FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock.On3x3:
                    return new int[,] {
                        {0, 1, 0},
                        {1, 0, 1},
                        {0, 1, 0}
                    };
                default: return null;
            }
        }
        [TestCase(4, FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock.On4x4)]
        [TestCase(3, FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock.On3x3)]
        public void FillMatrixNxNZerosAnOnesInFormChessboard_Task3_Test(int enter, FillMatrixNxNZerosAnOnesInFormChessboard_Task3_VariantsForMock exit)
        {
            int[,] expected = FillMatrixNxNZerosAnOnesInFormChessboard_Task3_Mock(exit);
            int[,] actual = MethodiHomeWorkSix.FillMatrixNxNZerosAnOnesInFormChessboard_Task3(enter);
            Assert.AreEqual(expected, actual);
        }

        public enum CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock { On3x5, On3x4 };
        public int[,] CheckingComplianceWithRestrictionsCOVID_Task4_MockArgument(CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock variant)
        {
            switch (variant)
            {
                case CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock.On3x4:
                    return new int[,] {
                        {1, 0, 1, 0},
                        {0, 1, 0, 1},
                        {1, 0, 1, 0},
                    };
                case CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock.On3x5:
                    return new int[,] {
                        {0, 1, 0, 1, 1},
                        {1, 0, 1, 1, 0},
                        {0, 1, 1, 0, 0}
                    };
                default: return null;
            }
        }
        [TestCase(CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock.On3x5, false)]
        [TestCase(CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock.On3x4, true)]
        public void CheckingComplianceWithRestrictionsCOVID_Task4_Test(CheckingComplianceWithRestrictionsCOVID_Task4_VariantsForMock enter, bool expected)
        {
            int[,] argument = CheckingComplianceWithRestrictionsCOVID_Task4_MockArgument(enter);
            bool actual = MethodiHomeWorkSix.CheckingComplianceWithRestrictionsCOVID_Task4(argument);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 26.00, 26.00, 16.00, 20.00, 14.00 }, new double[] { 5.00, 4.60, 6.20, 4.60 }, 1.00, 9.00)]

        public void GetFinance_Task5_Test(double[] expectedSumByShop, double[] expextedMediumSumByMonths, double expextedMin, double expextedMax)
        {
            //Given
            double[,] ArgumentFinanceReport = new double[5, 4]
            {
               { 5.00,  8.00,  8.00,  5.00},
               { 9.00,  9.00,  3.00,  5.00},
               { 1.00,  3.00,  4.00,  8.00},
               { 6.00,  2.00,  9.00,  3.00},
               { 4.00,  1.00,  7.00,  2.00},
            };

            //when
            (double[] actualSumByShop, double[] actualMediumSumByMonths, double actualMin, double actualMax) =
                MethodiHomeWorkSix.GetFinance_Task5(ArgumentFinanceReport);

            //then
            Assert.AreEqual(actualSumByShop, expectedSumByShop);
            Assert.AreEqual(actualMediumSumByMonths, expextedMediumSumByMonths);
            Assert.AreEqual(actualMin, expextedMin);
            Assert.AreEqual(actualMax, expextedMax);
        }

        public enum FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult { Result0, Result1, Result2 };
        public int[,] FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_Result
            (FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult variant)
        {
            switch (variant)
            {
                case FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result1:
                    return new int[,]
                    {
                           { 0, 4, 7},
                           { 5, 9, 2},
                           { 5, 4, 5},
                    };
                case FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result0:
                    return new int[,]
                    {
                           { 0, 3, 2},
                           { 0, 2, 2},
                           { 1, 1, 2},
                    };
                case FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result2:
                    return new int[,]
                    {
                           { 0, 3, 1},
                           { 0, 1, 1},
                           { 1, 1, 3},
                    };
                default: return null;
            }
        }
        [TestCase(FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result1, 1)]
        [TestCase(FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result0, 0)]
        [TestCase(FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult.Result2, 2)]
        public void FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_Test
            (FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_VariantsforResult enter, int expected)
        {
            int[,] argument = FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6_Result(enter);
            int actual = MethodiHomeWorkSix.FindNumberElementsGreaterAllNeighborsAtTheSameTime_Task6(argument);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FillInAnHourglassShapedarray_Task7_Test()
        {
            char[,] expected = new char[5, 5]
            {
                {'*', '*', '*', '*', '*'},
                {'-', '*', '*', '*', '-'},
                {'-', '-', '*', '-', '-'},
                {'-', '*', '*', '*', '-'},
                {'*', '*', '*', '*', '*'},
            };
            char[,] actual = MethodiHomeWorkSix.FillInAnHourglassShapedarray_Task7(5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ImplementMultiplicationOfMatricesOfIntegers_Task8_Test()
        {
            //Given
            int[,] arrey1 = new int[3, 2] {
            {0, 2},
            {5, 9},
            {0, 9}
             };
            int[,] arrey2 = new int[2, 3] {
            {1, 2, 3 },
            {2, 3, 1 }
            };
            int[,] expected = new int[3, 3]{
            {4,  6,  2},
            {23, 37, 24},
            {18, 27, 9},
            };
            //when
            int[,] actual = MethodiHomeWorkSix.ImplementMultiplicationOfMatricesOfIntegers_Task8(arrey1, arrey2);            
            //then
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ImplementMultiplicationOfMatricesOfIntegers_Task8_NegativeTest()
        {
            int[,] arrey1 = new int[3, 2] {
            {0, 2},
            {5, 9},
            {0, 9}
             };
            int[,] arrey2 = new int[2, 2] {
            {1, 2 },
            {2, 3 }
            };
            Assert.Throws<ArgumentException>(() => MethodiHomeWorkSix.ImplementMultiplicationOfMatricesOfIntegers_Task8(arrey1, arrey2));
        }
    }
}

