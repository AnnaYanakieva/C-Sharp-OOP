namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {

        private  List<Discipline> disciplines = new List<Discipline>();
        //public List<Discipline> Disciplines
        //{
        //    get { return new List<Discipline>(this.disciplines); }
        //    set { this.disciplines = value; }
        //}

        public Teacher(string firstName, string lastName):base(firstName, lastName)
        {
            
        }

        public Teacher AddDiscipline(params Discipline[] disciplines)
        {
            foreach (Discipline discipline in disciplines)
                this.disciplines.Add(discipline);

           return this;
        }

        public Teacher RemoveDiscipline(params Discipline[] disciplines)
        {
            foreach (Discipline discipline in disciplines)
                this.disciplines.Remove(discipline);

            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FirstName, this.LastName, this.disciplines.ToString());
        }
    }
}
