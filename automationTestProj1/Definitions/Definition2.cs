using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationTestProj1.Definitions
{
    [Binding]
    class Definition2
    {
        private IWebDriver driver = new ChromeDriver();

        [When(@"I go to another website")]
        public void WhenIGoToAnotherWebsite()
        {
            POM.POM pom1 = new POM.POM(driver);
            pom1.clickHyperLink();
        }

        public void pluralsightTraining()
        {
            var searchbox = driver.FindElement(By.Id("abc"));
            searchbox.SendKeys("value to be entered into the search field");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //this means that you are trying to match multiple items that have the same 
            //name, but this will take the first instance of an item with that name.
            var radiobutton = driver.FindElements(By.Name("colour"))[0];

            //this will go to the radio button and return back the value of the radio button so that
            //it can be compared and the value checked upon.
            radiobutton.GetAttribute("value");


        }


    }
}
