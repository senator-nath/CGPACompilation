namespace CGPACompilation
{
    internal class GradingSystem
    {
        public string NameAndCode { get; set; }
        public int CourseUnit { get; set; }
        public double Score { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public int WeightPoint { get; set; }
        public string Remark { get; set; }

        public GradingSystem(string nameAndCode, int courseUnit, int score)
        {
            NameAndCode = nameAndCode;
            CourseUnit = courseUnit;
            Score = score;
            if (score >= 70)
            {
                Grade = "A";
                GradeUnit = 5;
                Remark = "Excellent";
            }
            else if (score >= 60)
            {
                Grade = "B";
                GradeUnit = 4;
                Remark = "very Good";
            }
            else if (score <= 50)
            {
                Grade = "C";
                GradeUnit = 3;
                Remark = "Good";
            }
            else if (score <= 45)
            {
                Grade = "D";
                GradeUnit = 2;
                Remark = "Fair";
            }
            else if (score <= 40)
            {
                Grade = "E";
                GradeUnit = 1;
                Remark = "Poor";
            }
            else
            {
                Grade = "F";
                GradeUnit = 0;
                Remark = "Poor";
            }

        }






    }

}

