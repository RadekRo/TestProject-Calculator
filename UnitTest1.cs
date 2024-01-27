using System.Diagnostics.CodeAnalysis;
using TestProject_Calculator.Services;

namespace TestProject_Calculator
{
    public class Tests
    {
        private readonly CalculatorService _calculatorService;

        public Tests()
        {
            _calculatorService = new CalculatorService();
        }

        [Test]
        public void CheckIfResultOfTheDivisionIsATupleOfIntegers()
        {
            int a = 1;
            int b = 2;

            var divisionResult = _calculatorService.Divide(a, b);
            Assert.That(divisionResult, Is.TypeOf<(int Quotient, int Remainder)>());
        }

        [Test]
        public void WhenDivisionByZeroThrowAnException()
        {
            int a = 1;
            int b = 1;

            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(a, b), "Expected 0 as a second argument!");
        }

        [Test]
        public void CheckIfBothInputsAreIntegers()
        {
            int a = 'a';
            int b = 2;

            Assert.That(a, Is.TypeOf<int>());
            Assert.That(b, Is.TypeOf<int>());

            bool isAParseableInteger = int.TryParse(a.ToString(), out _);

            Assert.IsFalse(isAParseableInteger, "Character cannot be proceeded as integer value");
        }

    }
}