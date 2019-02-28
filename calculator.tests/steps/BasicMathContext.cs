using System.Collections.Generic;
using calculator.tests.steps.models;

namespace calculator.tests.steps
{
    public class BasicMathContext
    {
        public List<decimal> Values { get; set; } = new List<decimal>();

        public decimal Result { get; set; }

        public List<CalculatorInput> Inputs { get; set; } = new List<CalculatorInput>();
        public List<decimal> Results { get; set; } = new List<decimal>();
    }
}