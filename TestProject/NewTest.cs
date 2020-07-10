using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class ValidateFeatureSteps
    {
        [Given(@"I have navigate ""(.*)""")]
        public void GivenIHaveNavigate(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Page title ""(.*)""")]
        public void ThenPageTitle(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"page title ""(.*)""")]
        public void ThenPageTitle(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
