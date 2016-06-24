namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Animal:ISound
    {
        private string name;
        private int age;
        private GenderType gender;

       
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, GenderType gender) : this(name, age)
        {
            this.Gender = gender;

        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("This is not a valid age!");
                }
                this.age = value;
            }
        }
        public GenderType Gender
        {
            get { return this.gender; }
            private set
            { this.gender = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }

        public abstract string ProduceSound();
       
    }
}
