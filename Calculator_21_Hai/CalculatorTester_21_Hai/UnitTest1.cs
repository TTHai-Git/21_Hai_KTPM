using Calculator_21_Hai;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CalculatorTester_21_Hai
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation_21_Hai c_hai_21;
        
        [TestInitialize]
        public void SetUp()
        {
            c_hai_21 = new Calculation_21_Hai(22, 2);
        }
        [TestMethod] //TC1: a = 22, b = 2, kq = 24
        public void Test_Cong_21_Hai()
        {
            int expected, actual;
            expected = 24;
            actual = c_hai_21.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC2: a = 22, b = 2, kq = 20
        public void Test_Tru_21_Hai()
        {
            int expected, actual;
            expected = 20;
            actual = c_hai_21.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC3: a = 22, b = 2, kq = 44
        public void Test_Nhan_21_Hai()
        {
            int expected, actual;
            expected = 44;
            actual = c_hai_21.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC4: a = 22, b = 2, kq = 11
        public void Test_Chia_21_Hai()
        {
            int expected, actual;
            expected = 11;
            actual = c_hai_21.Execute("/");
            Assert.AreEqual(expected, actual);
            
        }

        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod] //TC5: phép chia cho 0
        public void Test_ChiaZero_21_Hai()
        {
            c_hai_21 = new Calculation_21_Hai(22, 0);
            c_hai_21.Execute("/");
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\TestData_21_Hai.csv", "TestData_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_21_Hai()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation_21_Hai cc_21_Hai = new Calculation_21_Hai(a, b);
            int actual = cc_21_Hai.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data\DataTest_cotToanTu_21_Hai.csv", "DataTest_cotToanTu_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_2_21_Hai()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString().Remove(0,1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());
            Calculation_21_Hai cc_21_Hai = new Calculation_21_Hai(a, b);
            int actual = cc_21_Hai.Execute(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
