using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class AtgTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Atg");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }

    }
}