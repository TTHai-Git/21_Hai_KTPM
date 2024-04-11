using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator_21_Hai;

namespace CalculatorTester_21_Hai
{
    [TestClass]
    public class UnitTest2
    {
        private power power_21_Hai;
        [TestInitialize]
        public void UnitTest()
        {
            power_21_Hai = new power();
        }
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData_Power_21_Hai.csv", "TestData_Power_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void testPower_21_Hai()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = power_21_Hai.Power(x, n);
            Assert.AreEqual(expected, actual);

        }
    }
}
