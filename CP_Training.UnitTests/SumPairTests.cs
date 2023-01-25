using CP_Training.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.UnitTests
{
    public class SumPairTests
    {
        private SumPairs _sumPairs;

        [SetUp]
        public void SetUp()
        {
            _sumPairs = new SumPairs();
        }

        [TestCase(6, 3)]
        public void DivisibleSumPairs_WhenCalled_ReturnsNumberOfPossibleDivisions(int n, int k)
        {
            //Arrange
            int expectedResult = 5;
            List<int> ar = new List<int>() { 1, 3, 2, 6, 1, 2 };

            //Act
            int result = _sumPairs.DivisibleSumPairs(n, k, ar);

            //Assert
            Assert.That(result == expectedResult);
        }
    }
}
