using System.Diagnostics.CodeAnalysis;

namespace TestProject_Calculator
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void WhenDivisionIsMadeAQuotientAndReminderObjectIsReturned()
        {
            int a = 1;
            int b = 2;

            var DivisionResult = Divide(a, b);

            Assert.That(DivisionResult, Has.Property("Quotient").InstanceOf<int>());
            Assert.That(DivisionResult, Has.Property("Remainder").InstanceOf<int>());

            Assert.Throws<DivideByZeroException>(() => Divide(a, b), "Divide by zero exception!");
        }
        
    }
}