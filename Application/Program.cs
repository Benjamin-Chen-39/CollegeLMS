using System;
using Library;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            College BardenCollege = new College();

            Console.WriteLine("Welcome to Barden University! Enter your name: ");
            string name = Console.ReadLine();
            Admin newAdmin = new Admin("Admin " + name);
            Teacher newTeacher = new Teacher("Teacher " + name);

            Console.WriteLine("As an admin, you can add and view teachers. Enter a teacher's name: ");
            string inputTeacher = Console.ReadLine();

            Console.WriteLine("Enter another teacher's name: ");
            string inputTeacher2 = Console.ReadLine();

            newAdmin.AddTeacher(inputTeacher, BardenCollege);
            newAdmin.AddTeacher(inputTeacher2, BardenCollege);

            Console.WriteLine($"The teachers here are:");

            foreach (var teacher in BardenCollege.Teachers)
            {
                Console.WriteLine($"{teacher}");
            }

            Console.WriteLine($"You are now Teacher {name}. What course do you teach? ");
            string subject = Console.ReadLine();
            Course currentCourse = BardenCollege.GetCourse(subject);









        }
    }
}
