using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_IComparerInterfaces
{
    class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            //If ascending order is required then use this, for descending order change 1 to -1 and -1 to 1
            if (this.Sid > other.Sid) 
                return 1;
            
            else if (this.Sid < other.Sid) 
                return -1;
            
            else
                return 0;
        }
    }

}
