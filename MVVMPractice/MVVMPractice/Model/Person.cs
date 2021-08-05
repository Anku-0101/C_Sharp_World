using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPractice.Model
{
    public class Person
    {
        private string fName;

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }



    }
}
