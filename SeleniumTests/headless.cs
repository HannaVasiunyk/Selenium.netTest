using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Headless
{
    public class Class1
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.google.com.ua";
        }

        [Test]
        public void Test1()
        {
            IWebElement button = driver.FindElement(By.CssSelector(".FPdoLc [value='Мені пощастить']"));
            button.Click();
            Assert.AreEqual("https://www.google.com/doodles", driver.Url);
        }
        
        [TearDown]
        public void Close()
        {
            driver.Quit();
        } 
    }
}
