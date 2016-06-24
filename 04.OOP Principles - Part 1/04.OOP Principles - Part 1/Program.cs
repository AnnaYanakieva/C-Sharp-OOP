
namespace SchoolClasses
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Student pesho = new Student("Ivan","Ivanov","12b");
            //Console.WriteLine(pesho);
            //pesho.AddComment("Player in the basketball team");

            //Teacher georgiev = new Teacher("Ivan", "Georgiev")
            //    .AddDiscipline(new Discipline("Math"))
            //    .AddDiscipline(new Discipline("Physics"));
            //georgiev.AddComment("A very good teacher");
            //Console.WriteLine(georgiev);

            //Class green = new Class("12a").AddTeacher(georgiev);
            Student pesho = new Student("Pesho", "Georgiev", "12");
            Class newClass = new Class("12a");
        }
    }
}
