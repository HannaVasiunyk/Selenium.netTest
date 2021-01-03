using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTests
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\chrome");
            driver.Url = "https://www.seleniumeasy.com/";
            driver.Manage().Window.Maximize();
        }



        [Test]
        public void Test1()
        {

            IWebElement button = driver.FindElement(By.CssSelector(".dropdown.expanded.last > a"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.CssSelector(".dropdown-menu > li:nth-of-type(5) > a"));
            button2.Click();

            Assert.AreEqual("https://www.seleniumeasy.com/java-tutorials", driver.Url);
        }

        [Test]
        public void Test2()
        {

            IWebElement button = driver.FindElement(By.CssSelector("li:nth-of-type(3) h2"));
            button.Click();

            Assert.IsTrue(driver.FindElement(By.CssSelector("[title='Locators in protractor']")).Displayed);

        }

        [Test]
        public void Test3()
        {
            IWebElement webElement = driver.FindElement(By.Id("edit-search-block-form--2"));
            IWebElement button = driver.FindElement(By.CssSelector("#search-block-form .btn-danger"));
            webElement.SendKeys("testNg");
            button.Click();

            Assert.AreEqual("https://www.seleniumeasy.com/search/node/testNg", driver.Url);
        }

        [TearDown]
        public void close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

