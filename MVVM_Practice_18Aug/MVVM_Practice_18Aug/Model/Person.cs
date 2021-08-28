using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Practice_18Aug.Model
{
    class Person 
    {
        private string fName;

        public string FirstName
        {
            get { return fName; }
            set 
            { 
                fName = value;
                
            }
        }

        private string lName;

        public string LastName
        {
            get { return lName; }
            set 
            { 
                lName = value;
                
            }
        }

        private string fullName;

        public string FullName
        {
            get { return fName + " " + lName; }
        }

       

       


    }
}
