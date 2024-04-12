using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MetaID_Test_21_Hai
{
    [TestClass]
    public class SearchProduct
    {
        private IWebDriver driver;
        public SearchProduct()
        {
            driver = new ChromeDriver();
        }

        public void serchByKeyWord(string kw)
        {
            try
            {
                driver.Navigate().GoToUrl("https://tinhocngoisao.com/");
                IWebElement e_search_input = driver.FindElement(By.Id("inputSearchAuto"));
                e_search_input.SendKeys(kw);
                IWebElement e_search_button = driver.FindElement(By.ClassName("btnSearch"));
                e_search_button.Click();

            }
            catch (NoSuchElementException)
            {
                driver.Navigate().GoToUrl("https://tinhocngoisao.com/");
                IWebElement e_search_input = driver.FindElement(By.Id("inputSearchAuto"));
                e_search_input.SendKeys(kw);
                IWebElement e_search_button = driver.FindElement(By.ClassName("btnSearch"));
                e_search_button.Click();
            }
          
        }

      
  
        public TestContext TestContext { get; set; }


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod] // TC 1: Serch thành công ra sản phẩm có chứa theo Keyword
        public void success_searchByKeyword()
        {
            serchByKeyWord("Core i5");
            IWebElement e_nofication_actual = driver.FindElement(By.CssSelector(".searchHead p"));
            string actual_noficaion = e_nofication_actual.Text;
            Assert.IsTrue(actual_noficaion.Contains("Tìm thấy"));

            Thread.Sleep(5000);
            driver.Quit();

        }

        [TestMethod] // TC 2: Serch thất bại không tồn tại sản phẩm có chứa theo Keyword
        public void fail_searchByKeyword()
        {
            serchByKeyWord("abc");
            IWebElement e_nofication_actual = driver.FindElement(By.CssSelector(".tabEmpty p"));
            string actual_noficaion = e_nofication_actual.Text;
            Assert.IsTrue(actual_noficaion.Contains("Không tìm thấy nội dung với từ khóa"));

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
