using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace SeleniumWebdriver
{
    [TestClass]
    class FirstTest
    {
        [TestMethod]
        public void test()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://google.com";

            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("Test" + Keys.Enter);
        }
        
    }
}
