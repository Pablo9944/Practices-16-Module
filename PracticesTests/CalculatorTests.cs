using NUnit.Framework;
using Practices_16_Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalReturnTrueValue()
        {
            Calculator c = new Calculator();
            Assert.IsTrue(c.Additional(2, 2) == 4);

        }
        [Test]
        public void SubtractionReturnSumValue()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(4, c.Subtraction(6, 2));

        }
        [Test]
        public void MiltiplicationReturnSumValue()
        {
            Calculator c = new Calculator();
            Assert.IsFalse(c.Miltiplication(2, 2) == 6);

        }
        [Test]
        public void DivisionReturnSumValue()
        {
            Calculator c = new Calculator();
            Assert.NotZero(c.Division(9, 3));

        }
    }
}
