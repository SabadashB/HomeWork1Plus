using NUnit.Framework;
using Homwork1Lib;
using System;

namespace TestHomeWork1
{
    public class HomeWork1Test
    {
        [TestCase(2, 4, 13)]
        [TestCase(4, 3, -29)]
        [TestCase(6, 8, 47)]
        [TestCase(5, 4, -41)]
        public void Task1_ShouldCalculate(int a, int b, int expected)
        {
            //Act
            double actualResults = Homework1.Task1(a, b);

            //Assert
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(2)]
        public void Task1_ShouldShow_Message(int a)
        {
            try
            {
                Homework1.Task1(a, a);
            }
            catch(DivideByZeroException ex)
            {
                Assert.AreEqual("(B - A) cannot be zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(8, 4, 2, 0)]
        [TestCase(5, 8, 0, 5)]
        public void Task3_ShouldCalculate_Division_And_Remainder(int a, int b, int divisionExpected, 
            int remainderExpected)
        {
            (int divisionActualResults, int remainderActualResults) = Homework1.Task3(a, b);
            Assert.AreEqual(divisionExpected, divisionActualResults);
            Assert.AreEqual(remainderExpected, remainderActualResults);
        }

        [TestCase(2, 4, 8, 2)]
        public void Task4_ShouldCalculate(double a, double b, double c, double expected)
        {
            double actualResults = Homework1.Task4(a, b, c);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(4, 2, 8, 2, 0, 2)]
        public void Task5_ShouleCalculate(double x1, double y1, double x2, double y2, double x1Expected,
            double x2Expected)
        {
            (double x1Result, double x2Result) = Homework1.Task5(x1, y1, x2, y2);
            Assert.AreEqual(x1Expected, x1Result);
            Assert.AreEqual(x2Expected, x2Result);
        }

        [TestCase(4, 2, 6)]
        [TestCase(4, 4, 16)]
        [TestCase(2, 4, -2)]
        public void Task6_ShouldCalculate(int a, int b, int Expected)
        {
            int actualResults = Homework1.Task6(a, b);
            Assert.AreEqual(Expected, actualResults);
        }

        [TestCase(2, 2, 1)]
        [TestCase(-1, 2, 2)]
        [TestCase(-3, -4, 3)]
        [TestCase(4, -4, 4)]
        public void Task7_ShouldCalculateQuarter(int x, int y, int Expected)
        {
            int actualResults = Homework1.Task7(x, y);
            Assert.AreEqual(Expected, actualResults);
        }

        [TestCase(4, 2, 4, null, null)]
        [TestCase(2, 5, -3, 0.5, -3)]
        [TestCase(1, -6, 9, 3, 3)]
        public void Task9_ShouleCalculate_QuadraticEquation(double a, double b, double c,
            double? x1Expected, double? x2Expected)
        {
            (double? x1Result, double? x2Result) = Homework1.Task9(a, b, c);
            Assert.AreEqual(x1Expected, x1Result);
            Assert.AreEqual(x2Expected, x2Result);
        }

        [TestCase("25", "Twenty five")]
        public void Task10_ShouleTransformValueToText(string a, string expected)
        {
            string actualResult = Homework1.Task10(a);
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(5, 2, 25)]
        [TestCase(-1, 4, 1)]
        [TestCase(-1, 3, -1)]
        [TestCase(0, 3, 0)]
        public void AtoPowerB_ShouldCalculatePower(int a, int b, int expected)
        {
            int actualResults = Homework1.GetAToPowerB(a, b);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(7, 142)]
        public void CountOf_ValuesWichDividedByA(int a, int expected)
        {
            int actualResults = Homework1.DividedbyA(a);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(12, 3)]
        public void CountOf_SquareLessThenA(int a, int expected)
        {
            int actualResults = Homework1.GetSquareLessA(a);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(1, 15, 21)]
        [TestCase(15, 1, 21)]
        public void SumOf_FromAtoBLessThen7(int a, int b, int expected)
        {
            int actualResults = Homework1.GetSumAtoBdivide7(a, b);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(7, 13)]
        public void NumberOfFibonachi(int a, int expected)
        {
            int actualResults = Homework1.GetNumberFibonachi(a);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(123, 55, false)]
        [TestCase(153, 53, true)]
        public void FindSameNumbers(int a, int b, bool expected)
        {
            bool actualResults = Homework1.GetSameNumbers(a, b);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(22, 0)]
        [TestCase(32, 1)]
        [TestCase(33, 2)]
        public void CountOf_OddInValue(int a, int expected)
        {
            int actualResults = Homework1.GetOddCount(a);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11}, 1)]
        [TestCase(new[] { -22, 11 }, 0)]
        public void FoundMinIndex_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.ArrayMinID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [Test]
        public void FoundMaxIndex_WhenNullPassed_ShuldReturnExeption()
        {
            try
            {
                Homework1.ArrayMinID(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No min element in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11 }, 0)]
        [TestCase(new[] { -22, 11 }, 1)]
        public void FoundMaxIndex_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.ArrayMaxID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [Test]
        public void FoundMinIndex_WhenNullPassed_ShuldReturnExeption()
        {
            try
            {
                Homework1.ArrayMaxID(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No max element in empty array", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11 }, 22)]
        [TestCase(new[] { -22, 11 }, 11)]
        public void FoundMax_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.ArrayMax(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11 }, 11)]
        [TestCase(new[] { -22, 11 }, -22)]
        public void FoundMin_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.ArrayMin(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 22)]
        [TestCase(new[] { 22, 11, 5 }, 27)]
        [TestCase(new[] { -22, 11, 5 }, -17)]
        public void SumOfOddID_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.SumOddID(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22 }, 0)]
        [TestCase(new[] { 22, 11, 5 }, 2)]
        [TestCase(new[] { -22, 11, 6 }, 1)]
        public void CountOfOdd_ShouldReturnValue(int[] array, int expected)
        {
            int actualResults = Homework1.CountOdd(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22, 12 }, new[] { 12, 22 })]
        public void ArrayReverse_ShouldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = Homework1.ArrayReverse(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 22, 12, 15 }, new[] { 15, 12, 22 })]
        [TestCase(new[] { 22, 12 }, new[] { 12, 22 })]
        public void ArrayHalfSwap_ShouldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = Homework1.ArrayHalfSwap(array);
            Assert.AreEqual(expected, actualResults);
        }

        [TestCase(new[] { 12, 22 }, new[] { 22, 12 })]
        public void ArraySortBubleDown_ShouldReturnArray(int[] array, int[] expected)
        {
            int[] actualResults = Homework1.ArrayInsertSortDown(array);
            Assert.AreEqual(expected, actualResults);
        }
    }
}
