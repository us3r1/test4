using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationTestProj1.POM
{
    class POM2
    {
        private IWebDriver driver;

        public POM2(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void navigateURL2()
        {
            driver.Navigate().GoToUrl("http://news.com.au");
        }


    }
}
