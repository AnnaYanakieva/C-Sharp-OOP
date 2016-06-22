namespace _09.StudentGroups
{
    using System.Collections.Generic;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;            
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\nFN: {2} Phone: {3} Email: {4}\nMarks: {5} Group: {6}", this.FirstName, this.LastName, this.FN, this.Tel, this.Email, string.Join(",", this.Marks), this.GroupNumber);
        }
    }
}
