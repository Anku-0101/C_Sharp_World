using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTextJSONTest
{
    [Serializable]
    class Employee
    {
        int empId;
        string name;
        int age;
        float salary;
        public Address address { get; set; }

        
        public Employee(int EmpId, string Name)
        {
            this.empId = EmpId;
            this.name = Name;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public void Introduce()
        {
            Console.WriteLine("Name of the employee is {0}", name);
            Console.WriteLine("Employee ID of the employee is {0}", empId);
            Console.WriteLine("Age of the employee is {0}", age);
            Console.WriteLine("Salary of the employee is {0}", salary);
            Console.WriteLine("Address : city {0}", address.City);
            Console.WriteLine("Address : PIN {0}", address.PINCode);
            Console.WriteLine("Address : HouseNumber {0}", address.HouseNumber);
            Console.WriteLine("Address : State {0}", address);
        }
    }
}
