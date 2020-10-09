using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Code_First_app
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                // Create and save a new student
                Console.Write("Enter the new students name: ");
                var name = Console.ReadLine();

                var student = new Student { StudentName = name };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Blogs from the database
                var students = from b in db.Students
                            orderby b.StudentName
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var newStudent in students)
                {
                    Console.WriteLine(newStudent.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public Grade Grade { get; set; }
        }

        public class Grade
        {
            public int GradeID { get; set; }
            public string GradeName { get; set; }
            public string Section { get; set; }
        }

        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }
        }

    }    

}
