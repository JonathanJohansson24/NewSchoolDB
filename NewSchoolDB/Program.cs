using NewSchoolDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NewSchoolDB.Models;

namespace NewSchoolDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SchoolDbContext db = new SchoolDbContext();

            Menu(db);
        }

        public static void Menu(SchoolDbContext db)
        {
            bool keepGoing = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome, you are now able to make one out of 3 choices: ");
                Console.WriteLine(@$"
1: Amount of teachers at the school: 
2. Show all students, including information: 
3. Show all active courses: 
");
                Console.WriteLine("Make your pick 1-3");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        AmountOfTeachers(db);

                        break;
                    case 2:
                        ShowAllStudents(db);
                        break;
                    case 3:
                        ShowActiveCourses(db);
                        break;
                    default:
                        Console.WriteLine("Invalid input...");
                        break;

                }
                Console.WriteLine("Do you wish to continue? Y/N");
                string userinput = Console.ReadLine().ToLower();
                if (userinput != "y")
                {
                    keepGoing = false;
                }
            } while (keepGoing);
        }
        public static void AmountOfTeachers(SchoolDbContext db)
        {
            Console.Clear();
            Console.WriteLine($@"Here's a list for each department");
            var setRoles = db.EmployeesRole
               .Where(r => r.RoleMeaning == "LanguageTeacher" || r.RoleMeaning == "ChemPhysTeacher" || r.RoleMeaning == "ProgMathTeacher")
               .Select(r => r.ID)
               .ToList();

            var countByRole = db.Employees
                .Where(e => setRoles.Contains(e.Role.ID))
                .GroupBy(e => e.Role.RoleMeaning)
                .Select(group => new { Role = group.Key, Count = group.Count() })
                .ToList();

            foreach (var dep in countByRole)
            {
                Console.WriteLine($@"
Department = {dep.Role} 
Number of teachers = {dep.Count}
");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ShowAllStudents(SchoolDbContext db)
        {
            Console.Clear();
            var result = db.Students
                .Include(s => s.Grades)
                 .ThenInclude(c => c.Course)
                    .Include(s => s.Grades)
                        .ThenInclude(g => g.GradingScales);

            Console.WriteLine("\t\tHere comes all of our current students");


            foreach (var s in result)
            {
                Console.WriteLine($@"
Student ID = {s.ID}
Firstname = {s.Stu_FirstName}
Lastname = {s.Stu_LastName}
Social Security Number = {s.Stu_SocialNumber}
Classname = {s.Class_Name}"
);
                foreach (Grade grade in s.Grades)
                {
                    string coursename = grade.Course?.Course_Name;
                    string gradingscale = grade.GradingScales.Grade_Meaning;
                    Console.WriteLine($"\nCourse = {coursename} \nGrade = {gradingscale}");
                }
                Console.ReadKey();

                Console.Clear();
            }

            Console.Clear();
        }
        public static void ShowActiveCourses(SchoolDbContext db)
        {
            var activecourses = db.Courses.Where(c => c.IsActive == true);
            Console.Clear();
            Console.WriteLine(@"Here are the active courses: ");
            Console.ReadKey();
            Console.Clear();
            foreach (Course course in activecourses)
            {
                Console.WriteLine(@$"
{course.Course_Name}
");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
