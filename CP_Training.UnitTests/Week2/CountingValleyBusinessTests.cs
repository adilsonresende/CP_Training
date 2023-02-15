using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CP_Training.Business.Week2;

namespace CP_Training.UnitTests.Week2
{
    public class CountingValleyBusinessTests
    {
        private CountingValleyBusiness _countingValleyBusiness;

        [SetUp]
        public void Setup()
        {
            _countingValleyBusiness = new CountingValleyBusiness();
        }

        [TestCase(8, "UDDDUDUU", 1)]
        public void CountingValley_WhenCalled_ReturnsNumberOfVales(int steps, string path, int expectedResult)
        {
            int result = _countingValleyBusiness.CountingValleys(steps, path);

            Assert.That(result == expectedResult);
        }
    }
}
