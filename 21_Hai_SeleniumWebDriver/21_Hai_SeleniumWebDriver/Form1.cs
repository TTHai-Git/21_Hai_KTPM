using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _21_Hai_SeleniumWebDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // đóng màn hình đen khi chạy
            ChromeDriverService chrome_21_Hai = ChromeDriverService.CreateDefaultService();
            chrome_21_Hai.HideCommandPromptWindow = true;

            // điều hướng trình duyệt
            IWebDriver driver_21_Hai = new ChromeDriver(chrome_21_Hai);
            //driver_21_Hai.Navigate().GoToUrl("https://lms.ou.edu.vn/");

            // Nhập url : vnexpress.net, nhấn open Url
            //driver_21_Hai.Navigate().GoToUrl(txt_URL.Text);

            // Không nhập url : nhấn open Url, textbox sẽ nhận Url mà bạn code
            //if (String.IsNullOrEmpty(txt_URL.Text) == false) driver_21_Hai.Navigate().GoToUrl(txt_URL.Text);

            // lấy url
            //string link_hientai_21_Hai = driver_21_Hai.Url;
            //Console.WriteLine(link_hientai_21_Hai);

            // lấy title
            //string title_hientai_21_Hai = driver_21_Hai.Title;
            //Console.WriteLine(title_hientai_21_Hai);

            // lấy pagesource
            //string pagesource_hientai_21_Hai = driver_21_Hai.PageSource;
            //Console.WriteLine(pagesource_hientai_21_Hai);

            // các lệnh điều hướng:
            driver_21_Hai.Navigate().GoToUrl("https://www.google.com.vn/");
            Thread.Sleep(5000);
            driver_21_Hai.Navigate().GoToUrl("https://lms.ou.edu.vn");
            Thread.Sleep(5000);
            driver_21_Hai.Navigate().Back();
            Thread.Sleep(5000);
            driver_21_Hai.Navigate().Forward();
            Thread.Sleep(5000);
            driver_21_Hai.Navigate().Refresh();

            //đóng trình duyệt
            Thread.Sleep(5000);
            driver_21_Hai.Close();

            // đóng mọi cửa sổ liên kết
            //driver_21_Hai.Quit();


        }
    }
}
