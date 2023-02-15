using System.Collections.Generic;
using NUnit.Framework;
using CP_Training.Business.Week2;

namespace CP_Training.UnitTests.Week2
{
    public class FlippingTheMatrixBusinessTests
    {
        private FlippingTheMatrixBusiness _flippingTheMatrixBusiness;

        [SetUp]
        public void Setup()
        {
            _flippingTheMatrixBusiness = new FlippingTheMatrixBusiness();
        }

        [Test]
        public void FlippingTheMatrix_WhenCalledWith2x2Matrix_ReturnsMaximunPossibleSum()
        {
            int expectedResult = 4;

            List<List<int>> matrix = new List<List<int>>() { new List<int> { 1, 2 }, new List<int> { 3, 4 } };

            int result = _flippingTheMatrixBusiness.FlippingMatrix(matrix);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void FlippingTheMatrix_WhenCalledWith4x4Matrix_ReturnsMaximunPossibleSum()
        {
            int expectedResult = 414;

            List<List<int>> matrix = new List<List<int>>() { new List<int> { 112, 42, 83, 119 }, new List<int> { 56, 125, 56, 49 }, new List<int> { 15, 78, 101, 43 }, new List<int> { 62, 98, 114, 108 } };

            int result = _flippingTheMatrixBusiness.FlippingMatrix(matrix);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
