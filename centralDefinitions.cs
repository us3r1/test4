using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace automationTestProj1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private IWebDriver _driver = new ChromeDriver();  


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            //ScenarioContext.Current.Pending();
            //test
            setup seleniumTests = new setup();
            seleniumTests.displayMessage("given");
        }
        
        [When(@"I press add")]
        public void WhenIPressAddBtn()
        {
            setup seleniumTests = new setup();
            seleniumTests.displayMessage("Given WHEN");

        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen()
        {
            //ScenarioContext.Current.Pending();
            setup seleniumTests = new setup();
            seleniumTests.SetupDLLTest();
        }

        [When(@"I press add btn")]
        public void WhenIPressAddBtn1()
        {
            setup seleniumTests = new setup();
            seleniumTests.displayMessage("Given WHEN");
        }

        [When(@"I press add btn (.*)")]
        public void WhenIPressAddBtn(int p0)
        {
            ScenarioContext.Current.Pending();
            setup seleniumTests = new setup();
            seleniumTests.displayMessage("when");
        }

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser()
        {
            //ScenarioContext.Current.Pending();
            //setup seleniumTests = new setup();
            //seleniumTests.displayMessage("given");


        }

        [When(@"i enter the weatherzone url and press go")]
        public void WhenIEnterTheWeatherzoneUrlAndPressGo()
        {
            //ScenarioContext.Current.Pending();
            setup seleniumTests = new setup();
            seleniumTests.SetupDLLTest();
        }

        [Then(@"the weatherzone webpage is displayed")]
        public void ThenTheWeatherzoneWebpageIsDisplayed()
        {
            //ScenarioContext.Current.Pending();
            setup seleniumTests = new setup();
            seleniumTests.displayMessage("then");
        }

        [Given(@"I am on the weatherzone website")]
        public void GivenIAmOnTheWeatherzoneWebsite()
        {
            //setup seleniumTests = new setup();
            //seleniumTests.openWeatherzoneWebsite();


            //_driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.weatherzone.com.au/");
        }

        //[When(@"i enter a postcode in the search field")]
        //public void WhenIEnterAPostcodeInTheSearchField(int postcode)
        //{
        //    setup seleniumTests = new setup();
        //    seleniumTests.enterPostcode(postcode);
        //    //seleniumTests
        //}

        [Then(@"the weather for that postcode area will be displayed\.")]
        public void ThenTheWeatherForThatPostcodeAreaWillBeDisplayed_()
        {

        }

        [When(@"i enter a postcode (.*) in the search field")]
        public void WhenIEnterAPostcodeInTheSearchField(int postcode)
        {
            //setup seleniumTests = new setup();
            //seleniumTests.enterPostcode(postcode);
            IWebElement postCodeSearch = _driver.FindElement(By.Id("location-search-box"));
            postCodeSearch.Clear();
            try
            {
                IWebElement postCodeSearchBtn = _driver.FindElement(By.Id("location-search-btn"));
                postCodeSearch.SendKeys("" + 3047);
                postCodeSearchBtn.Click();
            }
            catch
            {
                Console.WriteLine("exception" + (_driver.FindElement(By.Id("location-search"))));
            }

        }



        [Given(@"i have opened the website")]
        public void GivenIHaveOpenedTheWebsite()
        {
            POM.POM a = new POM.POM(_driver);
            a.login();

        }






        //[Then(@"the weather for (.*) is displayed.")]
        //public void ThenTheWeatherForIsDisplayed(string area)
        //{
        //    //ScenarioContext.Current.Pending();
        //}

        [Then(@"the weather for '(.*)' is displayed")]
        public void ThenTheWeatherForIsDisplayed(string p0)
        {
            setup seleniumTests = new setup();
            //seleniumTests.checkmatchingWeatherArea(p0);
        }

        [AfterScenario]
        public void disposewebdriver()
        {
            _driver.Dispose();
        }





    }
}
