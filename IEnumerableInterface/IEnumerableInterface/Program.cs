using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    public class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee employee)
        {
            Emps.Add(employee);
        }
        
        public int Count
        {
            get
            {
                return Emps.Count();
            }
        }
        public IEnumerator GetEnumerator()
        {
            //return Emps.GetEnumerator(); 
            //returning GetEnumerator of List

            return new OrganizationEnumerator(this);
        }

        public Employee this[int index]
        {
            get
            {
                return Emps[index];
            }
        }
    }

    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int currentIndex;
        Employee CurrentEmployee;

        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            currentIndex = -1;
        }
        public object Current
        {
            get
            {
                return CurrentEmployee;   
            }
        }

        public bool MoveNext()
        {
            if (++currentIndex >= OrgColl.Count)
            {
                return false;
            }
            else
            {
                CurrentEmployee = OrgColl[currentIndex];
                return true;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class TestEmployee
    {
        static void Main()
        {
            Organization employees = new Organization();

            employees.Add(new Employee
            {
                Id = 101,
                Name = "Raju",
                Job = "Manager",
                Salary = 877772.45
            });

            employees.Add(new Employee
            {
                Id = 102,
                Name = "Aman",
                Job = "Developer",
                Salary = 87742.45
            });

            employees.Add(new Employee
            {
                Id = 108,
                Name = "Anil",
                Job = "Sales",
                Salary = 118772.45
            });

            employees.Add(new Employee
            {
                Id = 101,
                Name = "Vivek",
                Job = "HR",
                Salary = 108772.45
            });

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Job + " " + emp.Salary);
            }

            Console.ReadKey();
        }
    }
}
