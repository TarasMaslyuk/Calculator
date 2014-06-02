using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.BinaryFuctions
{
    [TestFixture]
    public class DividerTests
    {
        [Test]
        public void CalculateTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation("Divider");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }

    }
}