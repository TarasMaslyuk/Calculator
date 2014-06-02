using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.BinaryFuctions
{
    [TestFixture]
    public class SubstracterTests
    {
        [Test]
        public void CalculateTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation("Substracter");
            double result = calculator.Calculate(1, 3);
            Assert.AreEqual(-2, result);
        }

    }
}