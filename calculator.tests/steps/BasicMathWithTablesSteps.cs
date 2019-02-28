using System.Linq;
using calculator.core;
using calculator.tests.steps.models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace calculator.tests.steps
{
    [Binding]
    public class BasicMathWithTablesSteps
    {
        private readonly BasicMathContext _context;

        public BasicMathWithTablesSteps(BasicMathContext context)
        {
            _context = context;
        }
        [Given(@"I have entered the following data into a calculator")]
        public void GivenIHaveEnteredTheFollowingDataIntoACalculator(Table table)
        {
            var input = table.CreateSet<CalculatorInput>();
            _context.Inputs = input.ToList();
        }

        [When(@"I press add after each set")]
        public void WhenIPressAddAfterEachSet()
        {
            var calculator = new Calculator();

            foreach (var calculatorInput in _context.Inputs)
            {
                var result = calculator.Add(calculatorInput.Value1, calculatorInput.Value2);
                _context.Results.Add(result);
            }
        }

        [Then(@"the calculator should show")]
        public void ThenTheCalculatorShouldShow(Table table)
        {
            var expectedValues = table.CreateSet<CalculatedResult>().ToList();

            for (var index=0;index< expectedValues.Count;index++)
            {
                var actual = _context.Results[index];
                var expected = expectedValues[index];

                Assert.Equal(expected.Value,actual);
            }
        }

    }
}