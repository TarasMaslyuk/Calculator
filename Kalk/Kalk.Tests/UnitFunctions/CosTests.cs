using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Cos");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }

    }
}