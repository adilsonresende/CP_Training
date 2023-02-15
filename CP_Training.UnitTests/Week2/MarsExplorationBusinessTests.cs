using NUnit.Framework;
using CP_Training.Business.Week2;

namespace CP_Training.UnitTests.Week2
{
    public class MarsExplorationBusinessTests
    {
        private MarsExplorationBusiness _marsExplorationBusiness;

        [SetUp]
        public void Setup()
        {
            _marsExplorationBusiness = new MarsExplorationBusiness();
        }

        [TestCase("SOSOOSOSOSOSOSSOSOSOSOSOSOS", 12)]
        [TestCase("SOSSPSSQSSOR", 3)]
        [TestCase("SOSSOT", 1)]
        public void MarsEploration_WhenCalled_ReturnsNumberOfWordsChanged(string imput, int exepctedResult)
        {
            int result = _marsExplorationBusiness.MarsExploration(imput);

            Assert.That(exepctedResult, Is.EqualTo(result));
        }
    }
}
