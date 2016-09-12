using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecflowDemo.Calculator.Specs.Tests
{
    [Binding, Scope(Tag = "Calculator")]
    public class CalculatorTestSteps
    {
        private int _eersteGetal;
        private int _tweedeGetal;
        private int _resultaat;
        private string _operatie;

        [Given(@"een eerste getal (.*)")]
        public void GivenEenEersteGetal(int eersteGetal)
        {
            _eersteGetal = eersteGetal;
        }

        [Given(@"een tweede getal (.*)")]
        public void GivenEenTweedeGetal(int tweedeGetal)
        {
            _tweedeGetal = tweedeGetal;
        }

        [Given(@"we een (\w*) willen uitvoeren")]
        public void GivenWeEenOperatieWillenUitvoeren(string operatie)
        {
            _operatie = operatie;
        }

        [When(@"we de berekening uitvoeren")]
        public void WhenWeDeBerekeningUitvoeren()
        {
            var calculator = new Calculator();
            switch (_operatie)
            {
                case "SOM":
                    _resultaat = calculator.Som(_eersteGetal, _tweedeGetal);
                    break;
                case "PRODUCT":
                    _resultaat = calculator.Product(_eersteGetal, _tweedeGetal);
                    break;
            }
        }

        [Then(@"verwachten we (.*)")]
        public void ThenVerwachtenWe(int verwacht)
        {
            Assert.AreEqual(verwacht, _resultaat);
        }



    }
}