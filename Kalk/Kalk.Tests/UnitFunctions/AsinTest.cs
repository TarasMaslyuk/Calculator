using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Kalk.Tests.UnitFunctions
{
    [TestFixture]
    public class AsinTests
    {
        [Test]
        public void CalculateTest()
        {
            IUnitOperation calculator = UnitOperationFactory.CreateOperation("Asin");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }

    }
}