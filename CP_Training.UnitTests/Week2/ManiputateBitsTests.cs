using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CP_Training.Business;

namespace CP_Training.UnitTests
{
    public class ManiputateBitsTests
    {
        private ManiputateBits _maniputateBits;
        [SetUp]
        public void Setup()
        {
            _maniputateBits = new ManiputateBits();
        }

        [TestCase(1, 4294967294)]
        [TestCase(0, 4294967295)]
        [TestCase(2147483647, 2147483648)]
        public void FlippingBits_WheCalled_ReturnsFlippedNumber(long number, long expectedResult)
        {
            long result = _maniputateBits.FlippingBits(number);

            Assert.That(result == expectedResult);
        }
    }
}
