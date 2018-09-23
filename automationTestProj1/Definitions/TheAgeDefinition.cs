using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace automationTestProj1.Definitions
{
    [Binding]
    class TheAgeDefinition
    {
        private IWebDriver driver = new ChromeDriver();


        [Given(@"I go to theage website")]
        public void GivenIGoToTheageWebsite()
        {
            POM.POM p = new POM.POM(driver);
            p.login();
        }


        [When(@"I go somehwqere else")]
        public void WhenIGoSomehwqereElse()
        {
            POM.POM2 pom2 = new POM.POM2(driver);
            pom2.navigateURL2();   
        }



    }
}
