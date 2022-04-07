using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter your info. \nFirst Name: ");
                var Fname = Console.ReadLine();
                Console.Write("Last Name: ");
                var Lname = Console.ReadLine();


                var student = new Student { Name = Fname + " " + Lname };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.Name
                            select s;

                Console.WriteLine("Students: \n\n");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.WriteLine("Press key to exit...");
            Console.ReadKey();
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }       

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int StudentID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public int ID { get; set; }
        public virtual Student Student { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
