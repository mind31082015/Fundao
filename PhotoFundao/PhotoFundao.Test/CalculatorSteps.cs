using NUnit.Framework;
using PhotoFundao.Domain;
using TechTalk.SpecFlow;
using static PhotoFundao.Test.Common.TestHelper;

namespace PhotoFundao.Test
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"A Calculator")]
        public void GivenACalculator()
        {
            var calculator = new Calculator();
            Bag.Calculator = calculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            var calculator = Bag.Calculator as Calculator;
            calculator.EnterNumber(number);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var calculator = Bag.Calculator as Calculator;
            var result = calculator.Add();
            Bag.Result = result;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            var result = Bag.Result;

            Assert.AreEqual(expectedResult, result);
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            var calculator = Bag.Calculator as Calculator;
            var result = calculator.Subtract();
            Bag.Result = result;
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            var calculator = Bag.Calculator as Calculator;
            var result = calculator.Multiply();
            Bag.Result = result;
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            var calculator = Bag.Calculator as Calculator;
            var result = calculator.Divide();
            Bag.Result = result;
        }

    }
}
