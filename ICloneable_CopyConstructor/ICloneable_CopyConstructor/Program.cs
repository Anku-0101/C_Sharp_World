using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable_CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "Aman",
                LastName = "Mishra",
                Age = 22,
                address = new Address()
                {
                    Address1 = "Some City",
                    Address2 = "This Street"
                }
            };

            //If we are making any changes to person object or person1 object the other ones doesn't change
            //Because all the fields are value types
            Person person1 = new Person(person);
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Age);
            Console.WriteLine(person1.FirstName + " " + person1.LastName + " " + person1.Age);

            person1.FirstName = "Steve";
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.Age);
            Console.WriteLine(person1.FirstName + " " + person1.LastName + " " + person1.Age);
            Console.WriteLine();

            //If we are making any change to address of person the person1 objects automatically changes as 
            //address is a reference type, to prevent this ICloneable is used.
            Console.WriteLine(person.address.Address1);
            Console.WriteLine(person1.address.Address1);

            Console.WriteLine();
            person.address.Address1 = "new Street";
            Console.WriteLine(person.address.Address1);
            Console.WriteLine(person1.address.Address1);

            Console.ReadLine();
        }
    }
    
    class Person 
    {
        string firstName;
        string lastName;
        int age;
        Address _address;

        public Address address
        {
            get { return _address; }
            set { _address = value; }
        }
            

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; } 
        }

        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age 
        {
            get { return age; }
            set { age = value;} 
        }
        public Person()
        {

        }

        public Person(Person person) 
        {
            this.firstName = person.firstName;
            this.lastName = person.lastName;
            this.age = person.age;
            this._address = (Address)person._address.Clone();
        }

    }

    class Address : ICloneable
    {
        string address1;
        string address2;

        public Address()
        {
               
        }

        public Address(Address address)
        {
            this.address1 = address.address1;
            this.address2 = address.address2;
        }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }

        public object Clone()
        {
            return new Address(this);
        }
    }
}
