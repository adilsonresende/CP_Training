using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP_Training.Business;
using NUnit.Framework;

namespace CP_Training.UnitTests
{
    public class LonleyIntegerTests
    {
        private FindLonelyNumber _findLonelyNumber;

        [SetUp]
        public void Setup()
        {
            _findLonelyNumber = new FindLonelyNumber();
        }

        [Test]
        public void LonelyInteger_WhenCalled_ReturnSingleOccuringInteger()
        {
            List<int> a = new List<int> {1, 2, 3, 4, 3, 2 , 1};
            int expectedResult = 4;

            int result = _findLonelyNumber.LonelyInteger(a);

            Assert.That(result == expectedResult);
        }
    }
}
