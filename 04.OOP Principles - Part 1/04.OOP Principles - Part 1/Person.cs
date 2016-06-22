namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : ICommentable
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter a name!");
                }

                this.firstName = value;

            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please enter a name!");
                }

                this.lastName = value;

            }
        }

        public void AddComment(string comment)
        {
            List<string> comments = new List<string>();
            comments.Add(comment);
            Console.WriteLine(string.Join(",", comment));
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
