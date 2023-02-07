using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests
{
    public class SparseArraryTests
    {
        private SparseArray _sparseArray;
        [SetUp]
        public void Setup()
        {
            _sparseArray = new SparseArray();
        }

        [Test]
        public void MatchingStrings_WhenCalled_ReturnNumberOfOcorrencies()
        {
            List<string> strings = new List<string> {"aba", "baba", "aba", "xzxb" };
            List<string> queries = new List<string> { "aba", "xzxb", "ab" };
            List<int>  expectedResult = new List<int> {2, 1, 0 };

            List<int> result = _sparseArray.MatchingStrings(strings, queries);

            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}