using System;
using System.Linq;
using calculator.core;
using TechTalk.SpecFlow;
using Xunit;

namespace calculator.tests.steps
{
    [Binding]
    public class BasicMathSteps
    {
        private readonly BasicMathContext _context;

 
        public BasicMathSteps(BasicMathContext context)
        {
            _context = context;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(decimal value)
        {
            _context.Values.Add(value);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var calculator = new Calculator();

            var a = _context.Values[0];
            var b = _context.Values[1];

            _context.Result = calculator.Add(a, b);
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            var calculator = new Calculator();

            var a = _context.Values[0];
            var b = _context.Values[1];

            _context.Result = calculator.Subtract(a, b);
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            var calculator = new Calculator();

            var a = _context.Values[0];
            var b = _context.Values[1];

            _context.Result = calculator.Multiply(a, b);
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            var calculator = new Calculator();

            var a = _context.Values[0];
            var b = _context.Values[1];

            _context.Result = calculator.Divide(a, b);
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int value)
        {
            Assert.Equal(value, _context.Result);
        }
    }

}
