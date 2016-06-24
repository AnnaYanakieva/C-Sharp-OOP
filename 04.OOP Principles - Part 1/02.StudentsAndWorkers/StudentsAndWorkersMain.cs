namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StudentsAndWorkersMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
                {
                    new Student("Pesho", "Ivanov", 2),
                    new Student("Gosho","Petrov",6),
                    new Student("Maria","Petrova",6),
                    new Student("Daniel","Atanasov",3),
                    new Student("Natalia","Elenkova",5),
                    new Student("Aleksander","Naidenov",2),
                    new Student("Atanas","Kirilov",6),
                    new Student("Naiden","Videnov",4),
                    new Student("Georgi","Mladenov",5),
                    new Student("Traicho","Georgiev",3)
            };

            var sortedByGrade =
                from stud in students
                orderby stud.Grade ascending
                select stud;

            Console.WriteLine("Students sorted by grade in ascending order:");

            foreach (Student stud in sortedByGrade)
            {
                Console.WriteLine(stud);
            }

            var workers = new List<Worker>()
            {
                new Worker("Trayan","Dimitrov",400,30),
                new Worker("Blagoy","Georgiev",300,30),
                new Worker("Nikolay","Petrov",500,35),
                new Worker("Georgi","Antonov",600,40),
                new Worker("Penka","Stamatova",300,20),
                new Worker("Jivko","Ivanov",650,40),
                new Worker("Ivan","Stoyanov",400,20),
                new Worker("Kaloyan","Slavov",250,20),
                new Worker("Ognyan","Nikolov",450,35),
                new Worker("Maria","Petkova",750,40),
                new Worker("Yovko","Yovkov",730,40),
            };

            var sortedByMoneyPerHour =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine();
            Console.WriteLine("Workers sorted by money per hour in descending order");
            foreach (Worker worker in sortedByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            List<Human> mergedList = new List<Human>();

            mergedList.AddRange(students);
            mergedList.AddRange(workers);

            var sortedHumans =
                from human in mergedList
                orderby human.FirstName, human.LastName ascending
                select human;

            Console.WriteLine();
            Console.WriteLine("Humans sorted by first name and last name.");
            foreach (Human human in sortedHumans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
