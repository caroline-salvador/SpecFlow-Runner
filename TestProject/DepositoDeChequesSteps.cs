using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class DepositoDeChequesSteps
    {
        [Given(@"Entrar no App Ailos > Selecionar uma cooperativa que foi habilitada para o serviço")]
        public void GivenEntrarNoAppAilosSelecionarUmaCooperativaQueFoiHabilitadaParaOServico()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Entrar na tela de Serviços do App Ailos em uma conta da respectiva cooperativa")]
        public void WhenEntrarNaTelaDeServicosDoAppAilosEmUmaContaDaRespectivaCooperativa()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"O menu de ""(.*)"" deve ser apresentado")]
        public void ThenOMenuDeDeveSerApresentado(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
