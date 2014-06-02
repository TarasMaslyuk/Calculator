using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class Log10Tests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Log10");
            double result = calculator.Calculate(100);
            Assert.AreEqual(2, result);
        }

    }
}