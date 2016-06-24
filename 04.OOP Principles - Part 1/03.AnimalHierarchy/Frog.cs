namespace _03.AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, GenderType gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "Says kva-kva!";
        }
    }
}
