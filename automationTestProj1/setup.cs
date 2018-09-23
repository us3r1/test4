using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationTestProj1
{
    [TestClass]
    public class setup
    {
        private IWebDriver chromeDriver;// = new ChromeDriver();

        [TestMethod]
        public void SetupDLLTest()
        {
            //IWebDriver chromeDriver = new ChromeDriver();
            //chromeDriver = new ChromeDriver();
            //var driver = new ChromeDriver();
            //chromeDriver.Navigate().GoToUrl("http://www.weatherzone.com.au/");
        }

        [TestMethod]
        //public void displayMessage(String message)
        public void displayMessage()
        {
            Console.WriteLine("test1 ");
            
        }

        [TestMethod]
        public void displayMessage(String message)
        //public void displayMessage()
        {
            Console.WriteLine("test2 ");

        }

        [TestMethod]
        public void openWeatherzoneWebsite()
        {
            //using is used because it disposed the web element once the test is complete
            using (chromeDriver = new ChromeDriver())
            {
                //chromeDriver.Navigate().GoToUrl("http://www.weatherzone.com.au/");
                //check that you are on the correct page by reading the page title
                Assert.AreEqual("Weather - Australia 7 day forecasts and weather radar - Weatherzone", chromeDriver.Title.ToString());
                chromeDriver.Manage().Window.Maximize();
                IWebElement postCodeSearch = chromeDriver.FindElement(By.Id("location-search-box"));
                postCodeSearch.Clear();
                try
                {
                    IWebElement postCodeSearchBtn = chromeDriver.FindElement(By.Id("location-search-btn"));
                    postCodeSearch.SendKeys("" + 3047);
                    postCodeSearchBtn.Click();
                }
                catch
                {
                    Console.WriteLine("exception" + (chromeDriver.FindElement(By.Id("location-search"))));
                }

            }
            //var chromeDriver = new ChromeDriver();

            //chromeDriver.Close();

        }




        [TestMethod]
        public void enterPostcode(int postcode)
        {
            chromeDriver = new ChromeDriver();
            //chromeDriver.Manage().Window.Maximize();
            //chromeDriver.Navigate().GoToUrl("http://www.weatherzone.com.au/");
            IWebElement postCodeSearch = chromeDriver.FindElement(By.Id("location-search-box"));
            postCodeSearch.Clear();
            try
            {
                IWebElement postCodeSearchBtn = chromeDriver.FindElement(By.Id("location-search-btn"));
                postCodeSearch.SendKeys("" + postcode);
                postCodeSearchBtn.Click();
            }
            catch
            {
                Console.WriteLine("exception" + (chromeDriver.FindElement(By.Id("location-search"))));
            }
            chromeDriver.Close();

        }

        [TestMethod]
        public void checkmatchingWeatherArea(string area)
        {
            //chromeDriver = new ChromeDriver();
            //IWebElement postCodeSearchBtn;
            //try
            //{
            //    postCodeSearchBtn = chromeDriver.FindElement(By.Id("location-search"));
            //}
            //catch
            //{
            //    //Console.WriteLine("exception" + (chromeDriver.FindElement(By.Id("location-search"))));
            //}


        }
    }
}
