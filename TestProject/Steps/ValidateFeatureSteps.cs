using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding, Scope(Tag = "automacao")]
    public class ValidateFeatureSteps
    {
        private readonly IWebDriver _webDriver;
        public ValidateFeatureSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        /*[Given(@"My manual test ""(.*)"""), Scope(Tag = "manual")]
        public void GivenMyManualTest(string status)
        {
            Assert.AreEqual("passou", status);
        }*/

        [Then(@"the NASDAQ stock symbol on the page should be ""(.*)""")]
        public void ThenTheNASDAQStockSymbolOnThePageShouldBe(string symbol)
        {
            var selector = By.XPath($"//a[@href=\"https://www.nasdaq.com/symbol/{symbol.ToLower()}\"]");
            var element = _webDriver.FindElement(selector);
            Assert.IsNotNull(element);
        }
    }
}
