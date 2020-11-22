using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class B : A
    {
        static int k;
        public B(): base(k)
        {
            Console.WriteLine("class B called");
        }
    }
}
