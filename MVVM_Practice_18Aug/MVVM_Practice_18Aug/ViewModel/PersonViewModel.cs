using MVVM_Practice_18Aug.Command;
using MVVM_Practice_18Aug.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Practice_18Aug.ViewModel
{
    class PersonViewModel : INotifyPropertyChanged
    {
        Person person;

        public Person Person_
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
                //OnPropertyChanged("Person_");
            }
        }

        ObservableCollection<Person> persons;
        public ObservableCollection<Person> Persons
        {
            get
            {
                return persons;
            }
           
        }

        public PersonViewModel()
        {
            person = new Person();
            persons = new ObservableCollection<Person>();
        }

        public ICommand submitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if(submitCommand == null)
                {
                    submitCommand = new RelayCommand(Submit, CanSubmit);
                }
                return submitCommand;
            }
        }

        private void Submit(object parameter)
        {
            persons.Add(person);
        }

        private bool CanSubmit(object parameter)
        {
            if(string.IsNullOrEmpty(person.FirstName) || string.IsNullOrEmpty(person.LastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
