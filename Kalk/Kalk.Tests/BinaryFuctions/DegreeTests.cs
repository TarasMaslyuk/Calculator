using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.BinaryFuctions
{
    [TestFixture]
    public class DegreeTests
    {
        [Test]
        public void CalculateTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation("Degree");
            double result = calculator.Calculate(1, 3);
            Assert.AreEqual(1, result);
        }

    }
}