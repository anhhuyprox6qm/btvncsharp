namespace Lab5.Exercise_2
{
    public abstract class Person
    {
        public string IdentityNumber { get; set; }
        public string FullName { get; set; }
        public string BaseSalary { get; set; }
        public string PersonName { get; set; }
        public int SkillLevel { get; set; }
        public double SeniorLecture { get; set; }
        public double Bonus { get; set; }
        public abstract double CalculateSalary();
    }
}