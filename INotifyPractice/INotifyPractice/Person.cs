using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPractice
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName 
        { 
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
                OnPropertyChanged("FullName");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
                OnPropertyChanged("FullName");
            }
        }

        public string FullName 
        {
            get
            {
                return firstName + " " + lastName ;
            }
            set
            {
                OnPropertyChanged("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
