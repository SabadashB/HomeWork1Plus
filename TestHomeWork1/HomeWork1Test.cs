using NUnit.Framework;
using Homwork1Lib;

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
            double actualResults = Homework1.AtoPowerB(a, b);

            //Assert
            Assert.AreEqual(expected, actualResults);
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
    }
}