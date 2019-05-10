using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebdriverTest
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;

        // can be used to provide medadata about the 
        // gives runtime details about testcases
        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            
            Console.WriteLine("Assembly initialize method will run before any of the assembly will run before any test method in assembly");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Console.WriteLine("Assembly Cleanup will run after the test in Assembly");
        }

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Url = "http://google.com";
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Test Initialize ran");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Test Cleanup ran");
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("TestRun directoty: {0}",
                TestContext.TestRunDirectory);
            TestContext.WriteLine("TestName: {0} ", TestContext.TestName);
            TestContext.WriteLine("Test Outcome: {0}", TestContext.CurrentTestOutcome);

            Console.WriteLine("test Method");
        }
      
        [TestMethod]
        public void TestMethod()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Test" + Keys.Enter);
            Assert.IsTrue(driver.Title.StartsWith("Test"));
        }

        [ClassCleanup]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
