namespace _03.FirtsBeforeLast
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int Age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = Age;
        }
    }
}
