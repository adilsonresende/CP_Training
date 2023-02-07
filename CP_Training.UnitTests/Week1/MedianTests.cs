using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests
{
    public class MedianTests
    {
        private Median _median;
        [SetUp]
        public void Setup()
        {
            _median = new Median();
        }

        [Test]
        public void MatchingStrings_WhenCalled_ReturnNumberOfOcorrencies()
        {
            List<int> n = new List<int> {0, 1, 2, 4, 6, 5, 3 };
            int expectedResult = 3;
            int result = _median.FindMedian(n);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
