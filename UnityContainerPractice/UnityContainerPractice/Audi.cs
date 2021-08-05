using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerPractice
{
    class Audi : ICar
    {
        private int miles = 0;
        public Audi()
        {

        }
        public int Run()
        {
            return ++miles;
        }
    }
}
