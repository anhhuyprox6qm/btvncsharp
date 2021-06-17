namespace Lab5.Exercise_2
{
    public abstract class Person
    {
        public string PersonName { get; set; }
        public bool SeniorLecture { get; set; }
        public int Experience { get; set; }
        public abstract double CalculateSalary();
        public abstract double CalculateBonus();
    }
}