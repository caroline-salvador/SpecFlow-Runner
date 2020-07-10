using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class NewFeatureSteps
    {
        [Then(@"manual test ""(.*)""")]
        public void ThenManualTest(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
