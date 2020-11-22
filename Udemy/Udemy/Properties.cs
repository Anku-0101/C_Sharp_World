using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy
{
    class Properties 
    {
        public int count { get; private set; }
        public int age
        {
            private get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        void Access()
        {
          

            
        }
    }
}
