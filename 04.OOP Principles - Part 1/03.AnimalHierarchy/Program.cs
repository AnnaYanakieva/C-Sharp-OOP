using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.AnimalHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Cat("Pesho",1,GenderType.male),
                new Cat("Gosho",5,GenderType.male),
                new Dog("Rex",4,GenderType.male),
                new Dog("Leksi",3,GenderType.female),
                new Frog("Jaburana",7,GenderType.female),
                new Frog("Princ Charoven",5,GenderType.male),
                new Kitten("Kitty",1),
                new TomCat("Tom",1)
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name} : {animal.ProduceSound()}");
            }
            Console.WriteLine();

            var cats = animals.OfType<Cat>().ToList();
            var dogs = animals.OfType<Dog>().ToList();
            var frogs = animals.OfType<Frog>().ToList();

            Console.Write("Cats avg age:");
            Console.WriteLine(cats.Average(cat => cat.Age));

            Console.Write("Dogs avg age:");
            Console.WriteLine(dogs.Average(dog => dog.Age));

            Console.Write("Frogs avg age:");
            Console.WriteLine(frogs.Average(frog => frog.Age));

        }
    }
}
