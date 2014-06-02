using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Sqrt");
            double result = calculator.Calculate(4);
            Assert.AreEqual(2, result);
        }

    }
}