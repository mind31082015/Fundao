﻿using NUnit.Framework;
using TechTalk.SpecFlow;

namespace PhotoFundaoTest
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
            var calculator = Bag.Calculator;
            calculator.EnterNumber(number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var calculator = Bag.Calculator;
            var result = calculator.Add();
            Bag.Result = result;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            var result = Bag.Result;

            Assert.AreEqual(expectedResult, result);
        }
    }
}