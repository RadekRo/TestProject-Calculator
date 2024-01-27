using System.Diagnostics.CodeAnalysis;

namespace TestProject_Calculator
{
    public class Tests
    {
        public Calculator calculator = new();

        [Test]
        public void CheckIfResultOfTheDivisionIsATupleOfIntegers()
        {
            int a = 1;
            int b = 2;

            var divisionResult = calculator.Divide(a, b);
            Assert.That(divisionResult, Is.TypeOf<(int Quotient, int Remainder)>());
        }

        [Test]
        public void WhenDivisionByZeroThrowAnException()
        {
            int a = 1;
            int b = 0;

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b), "Cannot divide by zero!");
        }
        
    }
}