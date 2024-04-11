using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator_21_Hai;

namespace CalculatorTester_21_Hai
{
    /// <summary>
    /// Summary description for UnitTest3
    /// </summary>
    [TestClass]
    public class UnitTest3
    {
        private List<int> a;
        private int n;
        private double x;
        private Polynomial_21_Hai Polynomial_21_Hai;

        [TestInitialize]
        public void init()
        {
            a = new List<int> {2,1,4};
            n = 2;
            x = 3.0;
            Polynomial_21_Hai = new Polynomial_21_Hai(n, a);
        
        }

        public TestContext TestContext { get; set; }

        [TestMethod] // TC 1: n = 2, a.Count() = 3, x = 3.0
        public void hople_21_Hai()
        {
            int expected = 41;
            int actual = Polynomial_21_Hai.Cal(x);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod] // TC 1: n = 2, a.Count() = 4 != n + 1 (2+1 = 3), x = 3.0, Exception expected = new ArgumentException("Invalid Data");
        public void khonghople_21_Hai()
        {
            a = new List<int> { 2, 1, 4, 7 };
            n = 2;
            x = 3.0;
            try
            {
                Polynomial_21_Hai = new Polynomial_21_Hai(n, a);
            }
            catch (Exception)
            {
                Assert.IsNotNull(Polynomial_21_Hai);
            }
           
        }

    }
}
