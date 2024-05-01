using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace tinhocngoisao_Test_21_Hai
{
   
    [TestClass]
    public class searchProductsByKeyword_21_Hai
    {
        private IWebDriver driver;
        public searchProductsByKeyword_21_Hai()
        {
            driver = new ChromeDriver();
        }


        public TestContext TestContext { get; set; }

        public void SearchProductsByKeyword(string keyword)
        {
            // chuyển hướng tới trang chủ trang website tin học ngôi sao
            driver.Navigate().GoToUrl("https://tinhocngoisao.com/");

            // lấy element input từ khóa cần search cho sản phẩm
            IWebElement e_input_kw = driver.FindElement(By.Id("inputSearchAuto"));
            // bỏ keyword cần tìm cho sản phẩm vào element input
            e_input_kw.SendKeys(keyword);

            // lấy element button nhấn để tìm kiếm
            IWebElement e_button_search = driver.FindElement(By.ClassName("btnSearch"));
            // tạo click event handle lên button tìm kiếm để bắt đầu tìm kiếm sản phẩm theo từ khóa
            e_button_search.Click();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV"
            , @".\TestData_searchProductsByKeyword_21_Hai\testcase_2_1_21_Hai.csv", "testcase_2_1_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] //TC 2.1: Tìm thấy danh sách các sản phẩm theo từ khóa thành công
        public void testcase_2_1_tontaicacsanphamtheotukhoa_thanh_cong_21_Hai()
        {
            // đọc từ khóa từ file dữ liệu test data .csv
            string kw = TestContext.DataRow[0].ToString();

            // thực hiện tìm kiếm sản phẩm theo từ khóa
            SearchProductsByKeyword(kw);

            // Đặt câu thông báo kỳ vọng khi tìm sản phẩm theo từ khóa
            string expected_search_success_nofication = "Tìm thấy";

            // lấy element chứa câu thông báo tìm thấy sản phẩm theo từ khóa
            IWebElement e_search_success_nofication = driver.FindElement(By.CssSelector(".searchHead p"));
            // Lấy câu thông báo thực tế khi tìm thấy sản phẩm theo từ khóa từ element
            string actual_search_success_nofication = e_search_success_nofication.Text;

            IWebElement e_search_success_kw = driver.FindElement(By.CssSelector("#insSearchPage > div.container > div > div.searchHead > p > span > b"));
            string actual_search_success_kw = e_search_success_kw.Text;

            // so sánh câu thông báo kỳ vọng với câu thông báo thực tế khi tìm thấy sản phẩm theo từ khóa
            Assert.IsTrue(actual_search_success_nofication.Contains(expected_search_success_nofication));

            Assert.IsTrue(actual_search_success_kw.Contains(kw));

            // Đếm ngược hết 3s thì đóng trình duyệt để kết thúc test case
            Thread.Sleep(3000);
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV"
            , @".\TestData_searchProductsByKeyword_21_Hai\testcase_2_2_21_Hai.csv", "testcase_2_2_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] //TC 2.2: Tìm thấy danh sách các sản phẩm theo từ khóa thành công
        public void testcase_2_2_khongtontaicacsanphamtheotukhoa_that_bai_21_Hai()
        {
            // đọc từ khóa từ file dữ liệu test data .csv
            string kw = TestContext.DataRow[0].ToString();

            // thực hiện tìm kiếm sản phẩm theo từ khóa
            SearchProductsByKeyword(kw);

            // Đặt câu thông báo kỳ vọng khi không tìm thấy sản phẩm có từ khóa đó
            string expected_search_fail_nofication = "Không tìm thấy";

            // lấy element chứa câu thông báo không tìm thấy sản phẩm có từ khóa đó
            IWebElement e_search_fail_nofication = driver.FindElement(By.CssSelector(".tabEmpty p"));
            // Lấy câu thông báo thực tế khi không tìm thấy sản phẩm có từ khóa đó từ element
            string actual_search_fail_nofication = e_search_fail_nofication.Text;

            IWebElement e_search_fail_kw = driver.FindElement(By.CssSelector("#insSearchPage > div.container > div > div > p > strong"));
            string actual_search_fail_kw = e_search_fail_kw.Text;

            // so sánh câu thông báo kỳ vọng với câu thông báo thực tế khi không tìm thấy sản phẩm có từ khóa đó
            Assert.IsTrue(actual_search_fail_nofication.Contains(expected_search_fail_nofication));

            Assert.IsTrue(actual_search_fail_kw.Contains(kw));

            // Đếm ngược hết 3s thì đóng trình duyệt để kết thúc test case
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}
