using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    class Test
    {
        [Before, Scope(Tag = "automacao")]
        public void CreateWebDriver(ScenarioContext context)
        {
            var options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //options.AddArgument("--desable-notifications");

            //IWebDriver webDriver = new ChromeDriver(options);
            IWebDriver webDriver = new ChromeDriver(Environment.CurrentDirectory);
            context["WEB_DRIVER"] = webDriver;
        }

        [After, Scope(Tag = "automacao")]
        public void CloseWebDriver(ScenarioContext context)
        {
            var driver = context["WEB_DRIVER"] as IWebDriver;
            driver.Quit();
        }
    }
}
