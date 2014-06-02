using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class AcosTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Acos");
            double result = calculator.Calculate((double)1/2);
            Assert.AreEqual(Math.PI/3, result, 0.0001);
        }

    }
}