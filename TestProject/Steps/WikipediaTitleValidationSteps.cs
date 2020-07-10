using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding, Scope(Tag = "automacao")]
    public class WikipediaTitleValidationSteps
    {
        private readonly IWebDriver _webDriver;
        public WikipediaTitleValidationSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        [Given(@"I have navigated to the ""(.*)"" page on Wikipedia")]
        public void GivenIHaveNavigatedToThePageOnWikipedia(string subject)
        {
            _webDriver.Url = $"https://en.wikipedia.org/wiki/{subject}";
        }

        [Then(@"the title of the page should be ""(.*)""")]
        public void ThenTheTitleOfThePageShouldBe(string title)
        {
            Assert.AreEqual(title, _webDriver.Title);
        }
    }
}
