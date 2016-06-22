namespace _03.FirtsBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentMain
    {
        static void Main()
        {
            Student firstStudent = new Student("Pesho", "Georgiev", 18);
            Student secondStudent = new Student("Aleksandar", "Lozanov", 32);
            Student thirdStudent = new Student("Georgi", "Ognyanov", 40);
            Student fourthStudent = new Student("Blagoy", "Peichev", 20);
            Student fifthStudent = new Student("Gosho", "Aleksiev", 21);

            var studentList = new List<Student>();
            studentList.Add(firstStudent);
            studentList.Add(secondStudent);
            studentList.Add(thirdStudent);
            studentList.Add(fourthStudent);
            studentList.Add(fifthStudent);

            var result =
                studentList.Where(stud => string.Compare(stud.FirstName, stud.LastName, StringComparison.Ordinal) < 0)
                .OrderBy(stud => stud.FirstName)
                .ThenBy(stud => stud.LastName);
            Console.WriteLine("Problem 3: Students with first name before last name:");
            var sortedListByName = new List<Student>();
            foreach (var item in result)
            {
                sortedListByName.Add(item);
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            var resultByAge =
                from stud in studentList
                where stud.Age >= 18 && stud.Age <= 24
                select stud;
            Console.WriteLine();
            Console.WriteLine("Problem 4: Students with age between 18 and 24:");
            foreach (var stud in resultByAge)
            {
                Console.WriteLine("{0} {1} {2}", stud.FirstName, stud.LastName, stud.Age);
            }

            var studentsByFirstAndLastDesc =
                                 studentList
                                .OrderByDescending(stud => stud.FirstName)
                                .ThenByDescending(stud => stud.LastName);
            Console.WriteLine();
            Console.WriteLine("Problem 5: Ordered by first name and last name in descending order Lambda.");
            foreach (var stud in studentsByFirstAndLastDesc)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }

            var sortedByNameLinq =
                from stud in studentList
                orderby stud.FirstName descending, stud.LastName descending
                select stud;
            Console.WriteLine();
            Console.WriteLine("Sorted with Linq in descending order:");
            foreach (var stud in sortedByNameLinq)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }
        }
    }
}
