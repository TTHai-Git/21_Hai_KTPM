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
    public class Login
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        public void TruyCapTrangChu()
        {
            driver.Navigate().GoToUrl("https://hopamchuan.com/");
        }


        public TestContext TestContext { get; set; }
        

        public void login(string username, string password)
        {
            // Truy cập vào trang chủ
            TruyCapTrangChu();

            /// Truy cập vào trang đăng nhập
            IWebElement e_login = driver.FindElement(By.Id("login-link"));
            e_login.Click();
            /// Nhập username
            IWebElement e_user = driver.FindElement(By.Name("identity"));
            e_user.SendKeys(username);
            /// Nhập password
            IWebElement e_pass = driver.FindElement(By.Name("password"));
            e_pass.SendKeys(password);
            /// Click button đăng nhập
            IWebElement e_btnlogin = driver.FindElement(By.Id("submit-btn"));
            e_btnlogin.Click();
        }

        public void loginWithNoADS(string username, string password)
        {
            try
            {
                login(username, password);
            }catch(NoSuchElementException) {
                login(username, password);
            }
        }

        public string Getuser()
        {
            IWebElement e_user = driver.FindElement(By.ClassName("username"));
            string user = e_user.Text;
            return user;
            
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestDataLogin.csv", "TestDataLogin#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 1: login thành công với user name và pasword
        public void DangNhapThanhCong_21_Hai()
        {
            // đọc dữ liệu đầu vào
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
            loginWithNoADS(username, password);
            // Lấy url thực tế là url sau khi click button Đăng Nhập
            string actualurl = driver.Url;
            // đặt url kỳ vọng so với thực tế
            string expectedurl = "https://hopamchuan.com/";
            // so sánh url kì vọng so với thực tế
           Assert.AreEqual(actualurl, expectedurl);
            // kiểm tra xem có tồn tại user tên là "Ngô Trung Trí" hay không?
            Assert.IsTrue(Getuser().Contains("Ngô Trung Trí"));
            /// Dừng 3 giây rùi đóng Chrome
            Thread.Sleep(5000);
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestDataLogin_ThieuUserName.csv", "TestDataLogin_ThieuUserName#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 2: login thất bại vì thiếu username.
        public void DangNhapThatBai_ThieuUserName_21_Hai()
        {
            // đọc dữ liệu đầu vào
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
            loginWithNoADS(username, password);
            // Lấy errormessage thực tế là url sau khi click button Đăng Nhập
            IWebElement e_errormessage = driver.FindElement(By.ClassName("error-message"));
            string actual_e_errormessage = e_errormessage.Text;
            // đặt errormessage kỳ vọng so với thực tế
            string expected_errormessage = "Tên tài khoản hoặc Email không được bỏ trống.";
            // so sánh errormessage kì vọng so với thực tế
            Assert.AreEqual(actual_e_errormessage, expected_errormessage);
            /// Dừng 3 giây rùi đóng Chrome
            Thread.Sleep(3000);
            driver.Quit();

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestDataLogin_ThieuPassWord.csv", "TestDataLogin_ThieuPassWord#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 3: login thất bại vì thiếu password.
        public void DangNhapThatBai_ThieuPassWord_21_Hai()
        {
            // đọc dữ liệu đầu vào
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
            loginWithNoADS(username, password);
            // Lấy errormessage thực tế sau khi click button Đăng Nhập
            IWebElement e_errormessage = driver.FindElement(By.ClassName("error-message"));
            string actual_e_errormessage = e_errormessage.Text;
            // đặt errormessage kỳ vọng 
            string expected_errormessage = "Mật khẩu không được bỏ trống.";
            // so sánh errormessage kì vọng so với errormessgae thực tế
            Assert.AreEqual(actual_e_errormessage, expected_errormessage);
            /// Dừng 3 giây rùi đóng Chrome
            Thread.Sleep(3000);
            driver.Quit();

        }

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestDataLogin_ThieuUser.csv", "TestDataLogin_ThieuUser#csv", DataAccessMethod.Sequential)]
        //[TestMethod] // TC 4: login thất bại vì thiếu username và password.
        //public void DangNhapThatBai_ThieuUserNameVaPassWord_21_Hai()
        //{
        //    // đọc dữ liệu đầu vào
        //    string username = TestContext.DataRow[0].ToString();
        //    string password = TestContext.DataRow[1].ToString();
        //    // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
        //    loginWithNoADS(username, password);
        //    // Lấy errormessage thực tế sau khi click button Đăng Nhập
        //    IWebElement e_errormessage = driver.FindElement(By.ClassName("error-message"));
        //    string actual_e_errormessage = e_errormessage.Text;
        //    // đặt errormessage kỳ vọng
        //    string expected_errormessage = "Tên tài khoản hoặc Email không được bỏ trống. Mật khẩu không được bỏ trống.";
        //    // so sánh errormessage kì vọng so với errormessage thực tế
        //   Assert.AreEqual(actual_e_errormessage, expected_errormessage);
        //    /// Dừng 3 giây rùi đóng Chrome
        //    Thread.Sleep(3000);
        //    driver.Quit();

        //}

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestData_SaiUserName_DungPassWord.csv", "TestData_SaiUserName_DungPassWord#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 5: login thất bại vì sai username nhưng đúng password.
        public void DangNhapThatBai_SaiUserName_DungPassWord_21_Hai()
        {
            // đọc dữ liệu đầu vào
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
            loginWithNoADS(username, password);
            // Lấy errormessage thực tế sau khi click button Đăng Nhập
            IWebElement e_errormessage = driver.FindElement(By.ClassName("error-message"));
            string actual_e_errormessage = e_errormessage.Text;
            // đặt errormessage kỳ vọng
            string expected_errormessage = "Tài khoản hoặc mật khẩu không đúng";
            // đặt errormessage kỳ vọng so với errormessage thực tế
            Assert.AreEqual(actual_e_errormessage, expected_errormessage);
            /// Dừng 3 giây rùi đóng Chrome
            Thread.Sleep(3000);
            driver.Quit();

        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\data\TestData_SaiPassWord_DungUserName.csv", "TestData_SaiPassWord_DungUserName#csv", DataAccessMethod.Sequential)]
        [TestMethod] // TC 6: login thất bại vì sai password nhưng đúng username.
        public void DangNhapThatBai_DungUserName_SaiPassWord_21_Hai()
        {
            // đọc dữ liệu đầu vào
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            // thực hiện phương thức đăng nhập và điền tự động username , password vừa đọc
            loginWithNoADS(username, password);
            // Lấy errormessage thực tế sau khi click button Đăng Nhập
            IWebElement e_errormessage = driver.FindElement(By.ClassName("error-message"));
            string actual_e_errormessage = e_errormessage.Text;
            // đặt errormessage kỳ vọng 
            string expected_errormessage = "Tài khoản hoặc mật khẩu không đúng";
            // so sánh errormessage kì vọng so với errormessage thực tế
            Assert.AreEqual(actual_e_errormessage, expected_errormessage);
            /// Dừng 3 giây rùi đóng Chrome
            Thread.Sleep(3000);
            driver.Quit();

        }

    }
}
