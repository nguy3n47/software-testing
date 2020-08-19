using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using excel = Microsoft.Office.Interop.Excel;

namespace Selenium_Data_Driven
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}data.xlsx";
            excel.Application xapp = new excel.Application();
            excel.Workbook x1workbook = xapp.Workbooks.Open(database);
            excel._Worksheet x1worksheet = x1workbook.Sheets[1];
            excel.Range x1range = x1worksheet.UsedRange;
            string email;
            string pass;

            for (int i = 1; i <= 3; i++)
            {
                email = x1range.Cells[1][i].value2;
                pass = x1range.Cells[2][i].value2;

                IWebDriver driver = new ChromeDriver();
                driver.Url = "http://localhost:3000/admin-login.html";
                driver.Manage().Window.Maximize();
                Thread.Sleep(100);

                driver.FindElement(By.Id("email")).SendKeys(email);
                driver.FindElement(By.Id("password")).SendKeys(pass + Keys.Enter);

                Thread.Sleep(2000);

                driver.Close();
            }
        }
    }
}
