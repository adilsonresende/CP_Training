using CP_Training.Business;
using NUnit.Framework;

namespace CP_Training.UnitTests
{
    public class CamelCaseTests
    {
        private CamelCase _camelCase;
        [SetUp]
        public void Setup()
        {
            _camelCase = new CamelCase();
        }

        
        [TestCase("S;M;plasticCup()", "plastic cup")]
        [TestCase("C;V;mobile phone", "mobilePhone")]
        [TestCase("C;C;coffee machine", "CoffeeMachine")]
        [TestCase("S;C;LargeSoftwareBook", "large software book")]
        [TestCase("C;M;white sheet of paper", "whiteSheetOfPaper()")]
        [TestCase("S;V;pictureFrame", "picture frame")]
        [TestCase("S;V;iPad", "i pad")]
        [TestCase("C;M;mouse pad ", "mousePad()")]
        [TestCase("C;C;code swarm", "CodeSwarm")]
        [TestCase("S;C;OrangeHighlighter", "orange highlighter")]
        public void CameCase_WhenCalled_FormatStringAccordingToParameters(string imput, string expectedOutPut)
        {
            //Arrange

            //Act
            string result = _camelCase.Solution(imput);

            //Assert
            Assert.That(result == expectedOutPut);
        }
    }
}