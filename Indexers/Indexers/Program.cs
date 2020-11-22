using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(41, "Ram", 78787878.22, "Mumbai");

            Console.WriteLine("Employee number is {0}",employee[0]);
            Console.WriteLine("Employee name is {0}",employee[1]);
            employee[0] = 43;
            employee["empName"] = "Shyam";
            Console.WriteLine("Employee number is {0}", employee["empNO"]);
            Console.WriteLine("Employee name is {0}", employee["empNAME"]);
            Console.ReadKey();
        }
    }
}
