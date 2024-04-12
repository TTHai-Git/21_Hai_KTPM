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
    public class Login_21_Hai
    {
        private IWebDriver driver;
       
        public Login_21_Hai()
        {
            driver = new ChromeDriver();

        }
        public void login(string username, string password)
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

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData_Login_21_Hai\testcase_1_1_21_Hai.csv", "testcase_1_1_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] // testcase_1_1: Đúng username và password của User đã đăng ký trước đó
        public void testcase_1_1_login_thanh_cong_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            login(username, password);

            // lấy element hiển thị câu chào mừng user khi đăng nhập thành công
            IWebElement actual_element = driver.FindElement(By.CssSelector(".content h1"));
            // lấy chuỗi chào mừng user thực tế khi đăng nhập thành công
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

            // tạm dừng 3 giây
            Thread.Sleep(3000);
            // sau đó đóng trình duyệt
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData_Login_21_Hai\testcase_1_2_21_Hai.csv", "testcase_1_2_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] // testcase_1_2: trống username, password tùy ý của User
        public void testcase_1_2_login_that_bai_bo_trong_username_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            login(username, password);

            // lấy element errormessage khi bỏ trống username
            IWebElement e_errormessgae_username = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi bỏ trống username
            string actual_errormessage_username = e_errormessgae_username.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_username = "Nhập tên đăng nhập của bạn";
            Assert.AreEqual(expected_errormessage_username, actual_errormessage_username);

            // tạm dừng 3 giây
            Thread.Sleep(3000);
            // sau đó đóng trình duyệt
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData_Login_21_Hai\testcase_1_3_21_Hai.csv", "testcase_1_3_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] // testcase_1_3: trống password, giữ nguyên username của User
        public void testcase_1_3_login_that_bai_bo_trong_password_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            login(username, password);

            // lấy element errormessage khi bỏ trống password
            IWebElement e_errormessgae_password = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi bỏ trống password
            string actual_errormessage_password = e_errormessgae_password.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_password = "Nhập mật khẩu của bạn";
            Assert.AreEqual(expected_errormessage_password, actual_errormessage_password);


            // tạm dừng 3 giây
            Thread.Sleep(3000);
            // sau đó đóng trình duyệt
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData_Login_21_Hai\testcase_1_4_21_Hai.csv", "testcase_1_4_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] // testcase_1_4: sai username, password tùy ý
        public void testcase_1_4_login_that_bai_username_sai_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            login(username, password);

            // lấy element errormessage khi sai username
            IWebElement e_errormessgae_username = driver.FindElement(By.ClassName("field-validation-error"));
            // Lấy chuỗi errormessage thực tế khi sai username
            string actual_errormessage_username = e_errormessgae_username.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_username = "Không thể tìm thấy tài khoản của bạn";
            Assert.AreEqual(expected_errormessage_username, actual_errormessage_username);


            // tạm dừng 3 giây
            Thread.Sleep(3000);
            // sau đó đóng trình duyệt
            driver.Quit();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\TestData_Login_21_Hai\testcase_1_5_21_Hai.csv", "testcase_1_5_21_Hai#csv", DataAccessMethod.Sequential)]
        [TestMethod] // testcase_1_5: sai password, giữ nguyên username của User
        public void testcase_1_5_login_that_bai_password_sai_21_Hai()
        {
            // đọc dữ liệu username và password từ file .csv
            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();

            // đăng nhập tài khoản
            login(username, password);

            // lấy element errormessage khi sai password
            IWebElement e_errormessgae_password = driver.FindElement(By.CssSelector(".validation-summary-errors li"));
            // Lấy chuỗi errormessage thực tế khi sai password
            string actual_errormessage_password = e_errormessgae_password.Text;
            // Đặt chuỗi errormessage kỳ vọng
            string expected_errormessage_password = "Đăng nhập không thành công, vui lòng thử lại";
            Assert.AreEqual(expected_errormessage_password, actual_errormessage_password);


            // tạm dừng 3 giây
            Thread.Sleep(3000);
            // sau đó đóng trình duyệt
            driver.Quit();
        }
    }
}
