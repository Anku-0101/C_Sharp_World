using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerPractice
{
    public class Ford : ICar
    {
        private int miles = 0;

        public int Run()
        {
            return ++miles;
        }
    }
}
