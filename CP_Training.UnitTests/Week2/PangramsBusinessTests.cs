using NUnit.Framework;
using CP_Training.Business.Week2;

namespace CP_Training.UnitTests.Week2
{
    public class PangramsBusinessTests
    {
        private PangramsBusiness _pangramsBusiness;

        [SetUp]
        public void Setup()
        {
            _pangramsBusiness = new PangramsBusiness();
        }

        [TestCase("We promptly judged antique ivory buckles for the next prize", "pangram")]
        [TestCase("We promptly judged antique ivory buckles for the prize", "not pangram")]
        public void Pangram_WhenCalled_ReturnIfStringIsAPangram(string imput, string expectedResult)
        {
            string result = _pangramsBusiness.Pangrams(imput);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
