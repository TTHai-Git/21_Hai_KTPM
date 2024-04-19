using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.ObjectModel;

namespace TestWebsite_21_Hai
{
    
    [TestClass]
    public class _21_Hai_Bai_1_N1_B4_D39
    {
        private IWebDriver driver;
        public _21_Hai_Bai_1_N1_B4_D39()
        {
            driver = new ChromeDriver();
        }


        public TestContext TestContext { get; set; }


        [TestMethod]
        public void testInputString_21_Hai()
        {
            // chuyển hướng tới trang chủ google
            driver.Navigate().GoToUrl("https://www.google.com/");

            // Lấy element input của thanh search của google
            IWebElement search_input = driver.FindElement(By.Name("q"));

            //Gửi chuỗi "Tu hoc java nhe" tự động điền vào element search_input
            search_input.SendKeys("Tu hoc java nhe");

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testInputString_Facbook_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element input email
            IWebElement e_email = driver.FindElement(By.Name("email"));
            //Gửi chuỗi "2151050112hai@ou.edu.vn" tự động điền vào element input email
            e_email.SendKeys("2151050112hai@ou.edu.vn");

            // Lấy element input password
            IWebElement e_password = driver.FindElement(By.Name("pass"));
            //Gửi chuỗi "1224567890" tự động điền vào element input password
            e_password.SendKeys("1234567890");

            // Lấy element button login
            IWebElement e_btn_login = driver.FindElement(By.Name("login"));
            //Tạo sự kiện click lên button login để đăng nhập
            e_btn_login.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testInputString_Facbook_ByIdAndName_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element input email
            IWebElement e_email = driver.FindElement(By.Id("email"));
            //Gửi chuỗi "2151050112hai@ou.edu.vn" tự động điền vào element input email
            e_email.SendKeys("2151050112hai@ou.edu.vn");

            // Lấy element input password
            IWebElement e_password = driver.FindElement(By.Name("pass"));
            //Gửi chuỗi "1224567890" tự động điền vào element input password
            e_password.SendKeys("1234567890");

            // Lấy element button login
            IWebElement e_btn_login = driver.FindElement(By.Name("login"));
            //Tạo sự kiện click lên button login để đăng nhập
            e_btn_login.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void testInputString_Facbook_ByClassName_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element input email
            IWebElement e_email = driver.FindElement(By.ClassName("inputtext"));
            //Gửi chuỗi "2151050112hai@ou.edu.vn" tự động điền vào element input email
            e_email.SendKeys("2151050112hai@ou.edu.vn");

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testInputString_Facbook_ByLinktext_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element thẻ a (href = hyperlink)
            IWebElement e_link = driver.FindElement(By.LinkText("Forgotten password?"));
            //Tạo sự kiện click lên hyper link của element thẻ a (e_link)
            e_link.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testInputString_Facbook_ByCssSelector_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element thẻ a (href = hyperlink)
            IWebElement e_link = driver.FindElement(By.LinkText("Forgotten password?"));
            //Tạo sự kiện click lên hyper link của element thẻ a (e_link)
            e_link.Click();

            // Lấy element input tìm tài khoản theo email
            IWebElement e_input_find_email = driver.FindElement(By.CssSelector("input[type='text']"));
            //Gửi chuỗi "test email by cssselector" tự động điền vào element input tìm tài khoản theo email
            e_input_find_email.SendKeys("test email by cssselector");

            // Lấy element button tìm kiếm
            IWebElement e_button_find = driver.FindElement(By.CssSelector("#did_submit"));
            //Tạo sự kiện click  element button để tìm kiếm
            e_button_find.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testInputString_Facbook_ByXpath_21_Hai()
        {
            // chuyển hướng tới trang đăng nhập của facbook
            driver.Navigate().GoToUrl("https://www.facebook.com");

            // Lấy element thẻ a (href = hyperlink)
            IWebElement e_link = driver.FindElement(By.LinkText("Forgotten password?"));
            //Tạo sự kiện click lên hyper link của element thẻ a (e_link)
            e_link.Click();

            // Lấy element input tìm tài khoản theo email
            IWebElement e_input_find_email = driver.FindElement(By.XPath("//*[@id=\"identify_email\"]"));
            //Gửi chuỗi "test email by cssselector" tự động điền vào element input tìm tài khoản theo email
            e_input_find_email.SendKeys("test_email_by_xpath"); // Điền 1 email tồn tài của tài khoản để test case thực hiện thành công nha !!!

            // Lấy element button tìm kiếm
            IWebElement e_button_find = driver.FindElement(By.XPath("//*[@id=\"did_submit\"]"));
            //Tạo sự kiện click  element button để tìm kiếm
            e_button_find.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testFindTagName_Wikipedia_IWantToLoveYou_21_Hai()
        {
            // chuyển hướng tới trang Wikipedia có bài đăng về I Want To Love You
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/I_Want_to_Love_You");

            // Lấy nhiều elemenets với TagName là h2
            ReadOnlyCollection<IWebElement> elements_h2 = driver.FindElements(By.TagName("h2"));

            // Duyệt qua từ element trong elemenets với TagName là h2
            foreach (var element_h2 in elements_h2)
            {
                // Xuất chuỗi văn bản của từng element với tagname h2
                Console.WriteLine(element_h2.Text);
            }

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void testUploadFileOrPicture_guru99_21_Hai()
        {
            // chuyển hướng tới trang guru99 vào mục test/upload
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/upload/");

            // lấy element input file upload lên
            IWebElement e_input_upload = driver.FindElement(By.ClassName("upload_txt"));
            // Lấy đường dẫn file cần upload chọn cho element input file upload
            e_input_upload.SendKeys("E:\\Hinh Nen\\1 - GWX1jyz.jpg");

            // lấy element checkbox 
            IWebElement e_checkbox = driver.FindElement(By.ClassName("field_check"));
            // Tạo hành động click check lên element checkbox trước bấm button submit để upload file
            e_checkbox.Click();

            // lấy element button submit để upload file lên
            IWebElement e_button_submit_file = driver.FindElement(By.Name("send"));
            // Tạo hành động click element button submit để upload file lên 
            e_button_submit_file.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }
        [TestMethod]
        public void test_PopupHandling_Accept_21_Hai()
        {
            // Chuyển hướng tới trang test/delete_customer.php của website demo.guru99.com
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");

            // lấy element input customer id
            IWebElement e_input_cusid = driver.FindElement(By.Name("cusid"));
            // Gửi chuỗi "53920" vào element input customer id
            e_input_cusid.SendKeys("53920");

            // Lấy element button submit
            IWebElement e_input_submit = driver.FindElement(By.Name("submit"));
            // Tạo sự kiện click lên element button submit
            e_input_submit.Click();

            // accept PopupHandling
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void test_PopupHandling_Dismiss_21_Hai()
        {
            // Chuyển hướng tới trang test/delete_customer.php của website demo.guru99.com
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");

            // lấy element input customer id
            IWebElement e_input_cusid = driver.FindElement(By.Name("cusid"));
            // Gửi chuỗi "53920" vào element input customer id
            e_input_cusid.SendKeys("53920");

            // Lấy element button submit
            IWebElement e_input_submit = driver.FindElement(By.Name("submit"));
            // Tạo sự kiện click lên element button submit
            e_input_submit.Click();

            // cancel PopupHandling
            driver.SwitchTo().Alert().Dismiss();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void test_PopupHandling_Reset_21_Hai()
        {
            // Chuyển hướng tới trang test/delete_customer.php của website demo.guru99.com
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/delete_customer.php");

            // lấy element input customer id
            IWebElement e_input_cusid = driver.FindElement(By.Name("cusid"));
            // Gửi chuỗi "53920" vào element input customer id
            e_input_cusid.SendKeys("53920");

            Thread.Sleep(5000);

            // Lấy element button reset
            IWebElement e_input_reset = driver.FindElement(By.Name("res"));
            // Tạo sự kiện click lên element button reset để clean element input customer id
            e_input_reset.Click();

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
