using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace TestProject
{
   [Binding, Scope(Tag = "passou"), Scope(Tag = "falhou")]
    public class ManualSteps
    {
        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep()
        {
        }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(string multiLineStringParam)
        {
        }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(Table tableParam)
        {
        }
    }


}
