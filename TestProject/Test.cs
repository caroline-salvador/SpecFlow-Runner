using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using TestProject.Report;

namespace TestProject
{
    [Binding]
    class Test
    {
        //Automação
        [Before, Scope(Tag = "automacao")]
        public void BeforeScenarioAutomacao(ScenarioContext scenario_context, FeatureContext feature_context)
        {
            var options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //options.AddArgument("--desable-notifications");

            //IWebDriver webDriver = new ChromeDriver(options);
            IWebDriver webDriver = new ChromeDriver(Environment.CurrentDirectory);
            scenario_context["WEB_DRIVER"] = webDriver;
        }

        //Manual
        [BeforeScenario, Scope(Tag = "passou"), Scope(Tag = "falhou"), Scope(Tag = "bloqueado")] 
        public void BeforeScenarioManual(ScenarioContext scenario_context, FeatureContext feature_context)
        {
            ManualTestReport.InsertReportData(feature_context.FeatureInfo.Title, 
                                          scenario_context.ScenarioInfo.Title, 
                                          scenario_context.ScenarioInfo.Tags[0]);
        }

        //Automação
        [After, Scope(Tag = "automacao")]
        public void AfterScenarioAutomacao(ScenarioContext context)
        {
            var driver = context["WEB_DRIVER"] as IWebDriver;
            driver.Quit();
        }

        [AfterTestRun]
        public static void AfterScenarioManual()
        {
            StreamWriter arquivo = new StreamWriter(@"C:\Users\caroline.salvador\Documents\arquivo.html");
            using (arquivo)
            {
                arquivo.WriteLine(ManualTestReport.GetReport());
            }
        }
    }
}
