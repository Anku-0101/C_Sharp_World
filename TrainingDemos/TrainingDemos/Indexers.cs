using System;
namespace TrainingDemos
{
    public class Person
    {
        string[] persons = { "John", "Alex", "Karl", "Michaela" };

        public string this[int index]
        {
            get
            {
                return persons[index];
            }
            set
            {
                persons[index] = value;
            }
        }
    }
}

