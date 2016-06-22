namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();

        public Class(string uniqueTextIdentifier)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
        }

        public string UniqueTextIdentifier { get; set; }

        public Class AddTeacher(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
                this.teachers.Add(teacher);

            return this;
        }

        public Class RemoveTeacher(params Teacher[] teachers)
        {
            foreach (Teacher teacher in teachers)
                this.teachers.Remove(teacher);

            return this;
        }
    }
}
