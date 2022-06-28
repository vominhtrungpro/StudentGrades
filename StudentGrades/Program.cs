using StudentGrades;
//get percentage
var gradeCalculator = new Gradecalculator();

Console.Write("Enter the percentage: ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

Console.WriteLine($"Student grade: {grade}");