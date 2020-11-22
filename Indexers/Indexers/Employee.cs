using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Employee
    {
        int empNum;
        string eName;
        double salary;
        string location;

        public Employee(int EmpNum, string EName, double Salary, string Location)
        {
            this.empNum = EmpNum;
            this.eName = EName;
            this.salary = Salary;
            this.location = Location;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0) return empNum;
                if (index == 1) return eName;
                if (index == 2) return salary;
                if (index == 3) return location;
                else return null;
            }
            set
            {
                if (index == 0) empNum = (int)value;
                if (index == 1) eName  = (string)value;
                if (index == 2) salary = (double)value;
                if (index == 3) location = (string)value;
            }
        }

        public object this[string index] //Indexers can be parametrized
        {
            get
            {
                if (index.ToUpper() == "EMPNO") return empNum;
                if (index.ToUpper() == "EMPNAME") return eName;
                if (index.ToUpper() == "SALARY") return salary;
                if (index.ToUpper() == "LOCATION") return location;
                else return null;
            }

            set
            {
                if (index.ToUpper() == "EMPNO")     empNum      = (int)value;
                if (index.ToUpper() == "EMPNAME")   eName       = (string)value;
                if (index.ToUpper() == "SALARY")    salary      = (double)value;
                if (index.ToUpper() == "LOCATION")  location    = (string)value;
            }
        }
    }
}
