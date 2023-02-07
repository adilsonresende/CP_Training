using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CP_Training.Business;

namespace CP_Training.UnitTests
{
    public class MatrixesTests
    {
        private Matrixes _matrixes;
        [SetUp]
        public void Setup()
        {
            _matrixes = new Matrixes();
        }

        [Test]
        public void DiagonalDifference_WhenCalled_ReturnDiagonalDifferenceFromLeftAndRigthDiagonals()
        {
            List<List<int>> imput = new List<List<int>>()
            {
                new List<int>{ 11, 2, 4 },
                new List<int>{4, 5, 6},
                new List<int>{ 10, 8, - 12 }
            };

            int expecteResult = 15;

            int result = _matrixes.DiagonalDifference(imput);

            Assert.That(result == expecteResult);
        }
    }
}
