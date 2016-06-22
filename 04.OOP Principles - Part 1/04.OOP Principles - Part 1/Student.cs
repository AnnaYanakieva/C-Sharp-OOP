namespace SchoolClasses
{
    using System;

    public class Student : Person
    {
        private string uniqueClassNumber;
        public Student(string firstName, string lastName, string uniqueClassNumber):base(firstName, lastName)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber { get; set; }

    }
}
