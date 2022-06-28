using StudentGrades;

namespace StudentGrade.nUnitTests
{
    public class GradecalculatorTests
    {
        private Gradecalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new Gradecalculator();
        }

        [TestCase(91)]
        [TestCase(95)]
        [TestCase(96)]
        [TestCase(99)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            //Assert.AreEqual("A", grade);
            Assert.That(grade, Is.EqualTo("A"));
        }

        [TestCase(1)]
        [TestCase(55)]
        [TestCase(86)]
        [TestCase(-8)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            //Assert.AreNotEqual("A", grade);
            Assert.That(grade, Is.Not.EqualTo("A"));
        }
    }
}