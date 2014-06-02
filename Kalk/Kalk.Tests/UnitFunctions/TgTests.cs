using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class TgTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Tg");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }

    }
}