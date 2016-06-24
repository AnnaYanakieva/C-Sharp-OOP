namespace _03.AnimalHierarchy
{
    public class Cat:Animal,ISound
    {
        public Cat(string name, int age,GenderType gender) : base(name, age, gender)
        {

        }

         public override string  ProduceSound()
        {
            return "Says Myauuu!";
        }
    }
}
