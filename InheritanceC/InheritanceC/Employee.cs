using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Employee
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected float salary { get; set; }


        protected virtual void Work()
        {

        }
    }
}
