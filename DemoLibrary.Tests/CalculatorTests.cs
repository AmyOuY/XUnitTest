using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValueShouldCalculate()
        {
            // Arrange
            double expected = 7;

            // Act
            double actual = Calculator.Add(4, 3);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(-5, 2, -3)]
        [InlineData(35.78, 12.21, 47.99)]
        [InlineData(double.MaxValue, 6, double.MaxValue)]
        public void Add_SimpleValuesShouleCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(5, -2, 7)]
        [InlineData(-8, -2, -6)]
        [InlineData(0.1, double.MinValue, double.MaxValue)]
        public void Subtract_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Subtract(x, y);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(3, -4, -12)]
        [InlineData(0, 3, 0)]
        [InlineData(double.MaxValue, -1, double.MinValue)]
        [InlineData(double.MinValue, -1, double.MaxValue)]
        [InlineData(double.MaxValue, 0, 0)]
        [InlineData(double.MinValue, 0, 0)]
        public void Multiple_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Multiply(x, y);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(7, 0);

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(7, 2, 3.5)]
        [InlineData(8, -2, -4)]
        [InlineData(0, -5, 0)]
        [InlineData(0, 8, 0)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
