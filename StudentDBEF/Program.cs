using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter your Name");
                var sName = Console.ReadLine();

                var name = new Student { StudFName = "Asefa" };
                db.Students.Add(name);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.StudFName
                            select s;
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudFName);
                }
            }
    }

    public class Student
    {
 
        public int studId { get; set; }
        public string StudFName { get; set; }
        public string StudLName { get; set; }
        public DateTime DateOfBirth { get; set; }


        public virtual List<Course> Courses { get; set; }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }

        public int studId { get; set; }
        public virtual Student Student { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
    }
}
}
