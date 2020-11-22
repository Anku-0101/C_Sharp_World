using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class A
    {
        protected int x;
        public A(int y)
        {
            this.x = y;
            Console.WriteLine("A class called");
        }

        public int DoUpdate(int k)
        {
           // this.x = k;
            return x * x;
        }
    }
}
