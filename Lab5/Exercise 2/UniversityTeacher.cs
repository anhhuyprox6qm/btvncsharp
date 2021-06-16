namespace Lab5.Exercise_2
{
    public class UniversityTeacher:Person
    {
        public string UniversityTeacherCode { get; set; }
        public int EnglishSkillLevel { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary*SkillLevel+EnglishSkillLevel
        }
    }
}