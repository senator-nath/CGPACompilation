using System;

namespace CGPACompilation
{
    internal class CalculateCgp
    {
        public CalculateCgp()
        {
            Console.WriteLine("Welcome to the GPA Calculator");

            int totalCourseUnitRegistered = 0;
            int totalCourseUnitPassed = 0;
            int totalWeightPoint = 0;
            int totalGradeUnit = 0;

            Console.WriteLine("\nPlease enter the scores for each course:");

            Console.WriteLine("| COURSE & CODE             | COURSE UNIT           | GRADE      | GRADE-UNIT         | WEIGHT Pt.       | REMARK            |");


            GradingSystem[] courses = new GradingSystem[6];

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Enter the course {i + 1} name and code: ");
                string nameAndCode = Console.ReadLine();

                Console.Write("Enter the course unit: ");
                int unit = int.Parse(Console.ReadLine());
                totalCourseUnitRegistered += unit;

                Console.Write("Enter the course score: ");
                int score = int.Parse(Console.ReadLine());

                GradingSystem course = new GradingSystem(nameAndCode, unit, score);
                courses[i] = course;

                Console.WriteLine($"| {course.NameAndCode,-27} | {course.CourseUnit,-21} | {course.Grade,-10} | {course.GradeUnit,-19} | {course.WeightPoint,-16} | {course.Remark,-17} |");

                if (course.Grade != "F")
                {
                    totalCourseUnitPassed += course.CourseUnit;
                }
                course.WeightPoint = course.CourseUnit * course.GradeUnit;
                totalWeightPoint += course.WeightPoint;
                totalGradeUnit += course.GradeUnit;
            }

            double gpa = (double)totalWeightPoint / totalGradeUnit;
            Console.WriteLine($"\nTotal Course Unit Registered is {totalCourseUnitRegistered}");
            Console.WriteLine($"Total Course Unit Passed is {totalCourseUnitPassed}");
            Console.WriteLine($"Total Weight Point is {totalWeightPoint}");
            Console.WriteLine($"Your GPA is = {gpa:F2} to 2 decimal places.");
        }

    }
}
