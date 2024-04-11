using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator_21_Hai;

namespace CalculatorTester_21_Hai
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation_21_Hai calculation_21_Hai;
        [TestInitialize]
        public void init()
        {
            calculation_21_Hai = new Calculation_21_Hai(22, 11);
        }
        [TestMethod] //TC1: a = 22, b = 11, kq = 33
        public void Test_Cong_21_Hai()
        {
            int expected, actual;
            expected = 33;
            actual = calculation_21_Hai.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC2: a = 22, b = 11, kq = 11
        public void Test_Tru_21_Hai()
        {
            int expected, actual;
            expected = 11;
            actual = calculation_21_Hai.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC3: a = 22, b = 11, kq = 242
        public void Test_Nhan_21_Hai()
        {
            int expected, actual;
            expected = 242;
            actual = calculation_21_Hai.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC4: a = 22, b = 11, kq = 2
        public void Test_Chia_21_Hai()
        {
            int expected, actual;
            expected = 2;
            actual = calculation_21_Hai.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC5: a = số bất kỳ, b = 0, kq = Passed
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_21_Hai()
        {
            calculation_21_Hai = new Calculation_21_Hai(22, 0);
            calculation_21_Hai.Execute("/");
        }

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",  @".\Data\TestData_21_Hai.csv", "TestData_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_Cong_21_Hai()
        {
            //int a = int.Parse(TestContext.DataRow[0].ToString());
            //int b = int.Parse(TestContext.DataRow[1].ToString());
            //int expected = int.Parse(TestContext.DataRow[2].ToString());

            calculation_21_Hai = new Calculation_21_Hai(int.Parse(TestContext.DataRow[0].ToString()), int.Parse(TestContext.DataRow[1].ToString()));
            //int actual = calculation_21_Hai.Execute("+");
            Assert.AreEqual(int.Parse(TestContext.DataRow[2].ToString()), calculation_21_Hai.Execute("+"));
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData_2_21_Hai.csv", "TestData_2_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_2_Operation_21_Hai()
        {
            //int a = int.Parse(TestContext.DataRow[0].ToString());
            //int b = int.Parse(TestContext.DataRow[1].ToString());
            //string operation = TestContext.DataRow[2].ToString().Remove(0,1);
            //int expected = int.Parse(TestContext.DataRow[3].ToString());

            calculation_21_Hai = new Calculation_21_Hai(int.Parse(TestContext.DataRow[0].ToString()), int.Parse(TestContext.DataRow[1].ToString()));
            //int actual = calculation_21_Hai.Execute(TestContext.DataRow[2].ToString().Remove(0,1));
            Assert.AreEqual(int.Parse(TestContext.DataRow[3].ToString()), calculation_21_Hai.Execute(TestContext.DataRow[2].ToString().Remove(0, 1)));
        }

    }
}
