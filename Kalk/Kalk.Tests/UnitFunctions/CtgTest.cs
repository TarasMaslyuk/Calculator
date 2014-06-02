using System;
using Kalk.Factories;
using Kalk.Intefaces;
using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class CtgTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Ctg");
            double result = calculator.Calculate(Math.PI/4);
            Assert.AreEqual(1, result,00001);
        }

    }
}