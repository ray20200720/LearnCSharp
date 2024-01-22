using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestMainLibraryExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMainLibraryExample.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void TestMethod1()
        {
            // Arrange
            var calculator = new Calculator();
            
            // Act
            var actual = calculator.Add(1, 1);
            var subtractActual = calculator.Subtract(actual, 1) == 1;

            // Assert
            Assert.IsNotNull(calculator);   //檢查指定的物件是否為 Null，並在值為 Null 時擲回例外狀況。
            Assert.AreEqual(2, actual);     //檢查兩個輸入物件或值是否相等。
            Assert.IsTrue(subtractActual);  //檢查輸入條件是否為 true。 另外還有 IsFalse，用於判斷條件為 false。
            StringAssert.Contains(actual.ToString(), "2");  //檢查字串是否包含特定的子字串。 
            StringAssert.Contains(calculator.ToString(), "LearnMyCalculatorApp.Calculator");
        }
    }
}