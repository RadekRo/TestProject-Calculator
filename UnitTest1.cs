using System.Diagnostics.CodeAnalysis;

namespace TestProject_Calculator
{
    public class Tests
    {
        [Test]
        public void WhenDivisionIsMadeAQuotientAndReminderObjectIsReturned()
        {
            int a = 1;
            int b = 2;

            var calculator = new Calculator();
            var divisionResult = calculator.Divide(a, b);

            Assert.That(divisionResult, Is.TypeOf<(int Quotient, int Remainder)>());
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b), "Cannot divide by zero!");
        }
        
    }
}