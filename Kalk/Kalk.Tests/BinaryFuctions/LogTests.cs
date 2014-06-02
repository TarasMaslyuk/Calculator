using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.BinaryFuctions
{
    [TestFixture]
    public class LogTests
    {
        [Test]
        public void CalculateTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation("Log");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }

    }
}