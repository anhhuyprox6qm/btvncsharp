namespace Lab5.Exercise_2
{
    public class HighSchoolTeacher:Person,IEmployeeAction
    {
        public string HighSchoolTeacherCode { get; set; }
        public int SkillLevel { get; set; }

        public string HighSchoolTeacherCode { get; set; }
        public double CalculateSalary()
        {
            return BaseSalary * Skilllevel + SeniorLecture + Bonus;
        }
     }
}    
