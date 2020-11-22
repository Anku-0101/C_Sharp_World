using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_IComparerInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student
            {
                Sid = 101,
                Name = "Abhay",
                Class = 10,
                Marks = 57.98f
            };

            Student s2 = new Student
            {
                Sid = 103,
                Name = "Aman",
                Class = 8,
                Marks = 68.12f
            };

            Student s3 = new Student
            {
                Sid = 105,
                Name = "Mahesh",
                Class = 10,
                Marks = 98.54f
            };

            Student s4 = new Student
            {
                Sid = 102,
                Name = "Shivam",
                Class = 7,
                Marks = 78.55f
            };

            List<Student> students = new List<Student>()
            {
                s1,s2,s3,s4
            };

            students.Sort(); // TO Short via SID
            
            CompareStudent obj = new CompareStudent();
            students.Sort(obj);

            foreach(Student student in students)
            {
                Console.WriteLine(student.Sid + " " + student.Name + " " + student.Class + "  " + student.Marks);
            }
            Console.ReadKey();
        }
    }
}
