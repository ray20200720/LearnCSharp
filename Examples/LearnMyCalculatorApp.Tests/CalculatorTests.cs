using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LearnMyCalculatorApp;
using FluentAssertions;


namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void AddTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 1);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Subtract(1, 1);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(1, 1);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(1, 1);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            //Assert.AreEqual(1, actual);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void AddTestFluentassertion()
        {
            var calculator = new Calculator();
            var actual = calculator.Add(1, 1);

            // Non-fluent asserts:
            // Assert.AreEqual(actual, 2);
            // Assert.AreNotEqual(actual, 1);

            actual.Should().Be(2).And.NotBe(1);
        }
    }
}
