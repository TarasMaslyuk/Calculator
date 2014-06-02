using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class ExpTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Exp");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }

    }
}