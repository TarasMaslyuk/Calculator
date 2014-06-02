using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.BinaryFuctions
{
    [TestFixture]
    public class AdderTests
    {
        [Test]
        public void CalculateTest()
        {
            IBinaryOperation calculator = BinaryOperationFactory.CreateOperation("Adder");
            double result = calculator.Calculate(1, 3);
            Assert.AreEqual(4,result);
        }
         
    }
}