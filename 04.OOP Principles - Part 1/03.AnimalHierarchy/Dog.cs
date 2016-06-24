namespace _03.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, GenderType gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Says Bayyy!";
        }
    }
}
