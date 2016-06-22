namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Georgiev", "523706", "+35987315811", "ivan.g@mail.bg", new List<double> { 2, 3 }, 2));
            students.Add(new Student("Georgi", "Dobromirov", "254805", "+35928753547", "georgi_dob@abv.bg", new List<double> { 4, 3, 6 }, 3));
            students.Add(new Student("Maria", "Georgieva", "678906", "+44879523571", "georgieva.maria@gmail.bg", new List<double> { 6, 6, 6 }, 3));
            students.Add(new Student("Lilia", "Pencheva", "178007", "+35929457852", "l.pencheva@abv.bg", new List<double> { 5, 6, 6 }, 2));

            #region Problem 9. Student groups
            var orderByGroupNumber =
                from stud in students
                where stud.GroupNumber == 2
                orderby stud.FirstName
                select stud;
            Console.WriteLine("Problem 9. Student groups:");
            foreach (var stud in orderByGroupNumber)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region Problem 10. Student groups extensions
            Console.WriteLine("Problem 10. Student groups extensions:");
            Console.WriteLine("Ordered with extension methods:");
            var orderByGroupLamda = students
                .Where(stud => stud.GroupNumber == 2)
                .OrderBy(stud => stud.FirstName);

            foreach (var stud in orderByGroupLamda)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region Problem 11. Extract students by email
            Console.WriteLine("Problem 11. Extract students by email:");
            Console.WriteLine("Students with email in abv.bg:");
            var studEmailAbv =
                from stud in students
                where stud.Email.Substring(stud.Email.Length - 6, 6) == "abv.bg"
                select stud;

            foreach (var stud in studEmailAbv)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region Problem 12. Extract students by phone
            Console.WriteLine("Problem 12. Extract students by phone:");
            Console.WriteLine("Students with phone numbers in Sofia:");

            var studentsPhoneInSofia =
                from stud in students
                where stud.Tel.Substring(0, 5) == "+3592"
                select stud;
            foreach (var stud in studentsPhoneInSofia)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion

            #region Problem 13. Extract students by marks
            Console.WriteLine("Problem 13. Extract students by marks:");
            var studentsWithExcellent =
                from stud in students
                where stud.Marks.Contains(6)
                select new { FullName = stud.FirstName + stud.LastName, Marks = string.Join(",", stud.Marks.ToArray()) };

            Console.WriteLine("Students with excellent marks : ");
            foreach (var stud in studentsWithExcellent)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion

            #region Problem 14. Extract students with two marks
            var studentsWithTwoMarks =
                from stud in students
                where stud.Marks.Count == 2
                select new { FullName = stud.FirstName + stud.LastName, Marks = string.Join(",", stud.Marks.ToArray()) };

            Console.WriteLine("Problem 14: Students with two marks : ");
            foreach (var stud in studentsWithTwoMarks)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }
            #endregion

            #region Problem 15. Extract marks
            var studentsEnrolledIn06 =
                from stud in students
                where stud.FN.Substring(4, 2) == "06"
                select stud;

            Console.WriteLine();
            Console.WriteLine("Problem 15. Extract marks:");
            Console.WriteLine("Students that enrolled in 2016: ");
            foreach (var stud in studentsEnrolledIn06)
            {
                Console.WriteLine("{0} {1} {2}", stud.FirstName, stud.LastName, string.Join(",", stud.Marks.ToArray()));
                Console.WriteLine();
            }
            #endregion

            #region Problem 18. Grouped by GroupNumber
            var groupedLinq =
                from stud in students
                group stud by stud.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;
            Console.WriteLine("Problem 18. Students grouped by group number:");
            foreach (var stud in groupedLinq)
            {
                Console.WriteLine("Group {0}: ", stud.Key);
                foreach (var s in stud)
                {
                    Console.WriteLine("{0} {1} ",s.FirstName, s.LastName);
                }
                Console.WriteLine();
            }
            #endregion

            #region Problem 19. Grouped by GroupName extensions
            var groupedExtMet = students
                .GroupBy(stud => stud.GroupNumber);

            Console.WriteLine("Problem 19. Grouped by GroupName extensions:");
            Console.WriteLine("Students grouped by group number with extension methods:");
            foreach (var stud in groupedExtMet)
            {
                Console.WriteLine("Group {0}: ", stud.Key);
                foreach (var s in stud)
                {
                    Console.WriteLine("{0} {1} ", s.FirstName, s.LastName);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
