using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestWebsiteHopAmChuan
{
    [TestClass]
    public class Login_MetaID
    {
        private IWebDriver driver;
        private TestContext testContextInstance;
        public Login_MetaID()
        {
            driver = new ChromeDriver();
        }

        public void login (string username, string password)
        {
            // chuyển hướng tới trang chủ của MetaID
            driver.Navigate().GoToUrl("https://account.meta.vn/");
            // lấy element input username
            IWebElement e_username = driver.FindElement(By.Id("UserName"));
            e_username.SendKeys(username);
            // lấy element input password
            IWebElement e_password = driver.FindElement(By.Id("password-login"));
            e_password.SendKeys(password);
            // lấy element button đăng nhập
            IWebElement e_btnlogin = driver.FindElement(By.ClassName("btn-login"));
            e_btnlogin.Click();
        }

        public void loginWithNoADS(string usename, string password)
        {
            try
            {
                login(usename, password);
            }
            catch (NoSuchElementException)
            {
                login(usename, password);
            }
        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data_2\TestData_Login.csv", "TestData_Login#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 1: login thành công với user name và pasword
        public void LoginThanhCong_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            
            // đăng nhập tài khoản
            loginWithNoADS(username, password);

            // lấy element hiển thị câu chào mừng user khi đăng nhập thành công
            IWebElement actual_element = driver.FindElement(By.CssSelector(".content h1"));
            // lấy câu chào mừng user thực tế khi đăng nhập thành công
            string actual_content = actual_element.Text;
            // đặt câu chào mừng user đăng nhập thành công mà ta muốn mong đợi
            string expected_content = "Xin chào, Trịnh Thanh Hải";
            // so sánh câu chào mừng kỳ vọng với thực tế
            Assert.AreEqual(expected_content, actual_content);

            // so sanh url

            // lấy url hiện tại
            string actual_url = driver.Url;
            // Đặt url kỳ vọng
            string expected_url = "https://account.meta.vn/overview";
            // so sánh url kỳ vọng với thực tế
            Assert.AreEqual(expected_url, actual_url);

            Thread.Sleep(3000);
            driver.Quit();
            
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data_2\TestData_SaiUsername.csv", "TestData_SaiUsername#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 2: login thất bại vì sai username nhưng vẫn đúng password
        public void DangNhapThatBai_SaiUsername_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            
            // đăng nhập tài khoản
            loginWithNoADS(username, password);

            // lấy element errormessage khi sai username
            IWebElement e_errormessgae_username = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi sai username
            string actual_errormessage_username = e_errormessgae_username.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_username = "Không thể tìm thấy tài khoản của bạn";
            Assert.AreEqual(expected_errormessage_username, actual_errormessage_username);


            Thread.Sleep(3000);
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data_2\TestData_SaiPassword.csv", "TestData_SaiPassword#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 3: login thất bại vì sai password nhưng vẫn đúng username
        public void DangNhapThatBai_SaiPassword_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            
            // đăng nhập tài khoản
            loginWithNoADS(username, password);

            // lấy element errormessage khi sai password
            IWebElement e_errormessgae_password = driver.FindElement(By.CssSelector(".validation-summary-errors li"));
            // Lấy chuỗi errormessage thực tế khi sai password
            string actual_errormessage_password = e_errormessgae_password.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_password = "Đăng nhập không thành công, vui lòng thử lại";
            Assert.AreEqual(expected_errormessage_password, actual_errormessage_password);


            Thread.Sleep(3000);
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data_2\TestData_TrongUsername.csv", "TestData_TrongUsername#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 4: login thất bại vì bỏ trống usename
        public void DangNhapThatBai_BoTrongUsername_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            loginWithNoADS(username, password);

            // lấy element errormessage khi bỏ trống username
            IWebElement e_errormessgae_username = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi bỏ trống username
            string actual_errormessage_username = e_errormessgae_username.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_username = "Nhập tên đăng nhập của bạn";
            Assert.AreEqual(expected_errormessage_username, actual_errormessage_username);


            Thread.Sleep(3000);
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data_2\TestData_TrongPassword.csv", "TestData_TrongPassword#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 5: login thất bại vì bỏ trống password 
        public void DangNhapThatBai_BoTrongPassword_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            loginWithNoADS(username, password);

            // lấy element errormessage khi bỏ trống password
            IWebElement e_errormessgae_password = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi bỏ trống password
            string actual_errormessage_password = e_errormessgae_password.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_password = "Nhập mật khẩu của bạn";
            Assert.AreEqual(expected_errormessage_password, actual_errormessage_password);


            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}
