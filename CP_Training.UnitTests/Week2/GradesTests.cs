using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CP_Training.Business;

namespace CP_Training.UnitTests
{
    public class GradesTests
    {
        private Grades _grades;

        [SetUp]
        public void Setup()
        {
            _grades = new Grades();
        }

        [Test]
        public void GradingStudents_WhenCalled_ReturnsRoundedGrade()
        {
            List<int> imput = new List<int> { 73, 67, 38, 33};
            List<int> expectedResult = new List<int> { 75, 67, 40, 33 };

            List<int> result = _grades.GradingStudents(imput);

            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}
