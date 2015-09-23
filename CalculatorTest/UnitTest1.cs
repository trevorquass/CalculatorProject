using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdditionOperator testAdditionOperator = new AdditionOperator();
            testAdditionOperator.AddInput();
            int expected = 8;
            int actual = result.AddInput();
            Assert.AreEqual(expected, actual);
        }
    }
}
