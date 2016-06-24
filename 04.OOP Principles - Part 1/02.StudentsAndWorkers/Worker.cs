namespace _02.StudentsAndWorkers
{
    public class Worker:Human
    {
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary {get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double money = WeekSalary / WorkHoursPerDay;
            return money;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, money per hour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
    
}
