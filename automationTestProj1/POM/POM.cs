using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium;

namespace automationTestProj1.POM
{
    class POM
    {
        private IWebDriver driver;
        //private IWebElement 


        public POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void login()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            //driver.Navigate().GoToUrl("http://www.theage.com.au/");
            //IWebElement loginbtn = driver.FindElement(By.XPath(".//*button[[@class,'_3S9ou'] and [contains(text()='Log In')]]"));

            //IWebElement loginbtn = driver.FindElement(By.XPath("//button[@class='_3S9ou']"));

            //loginbtn.Click();

        }



        public void clickHyperLink()
        {
            driver.Navigate().GoToUrl("http://www.theage.com.au/");
            //IWebElement loginbtn = driver.FindElement(By.XPath("//a[contains(text(),"'We need a refuge': "Locals confront minister after")]");
        }

    }
}
