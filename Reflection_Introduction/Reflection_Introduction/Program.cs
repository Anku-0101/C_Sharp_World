using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Introduction
{
    public class MainClass
    {
        private static void Main()
        {
            Type T = Type.GetType("Reflection_Introduction.Customer");
            PropertyInfo[] properties = T.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.ReadKey();
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public Customer(int ID, string name)
        {
            this.Id = ID;
            this.Name = name;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0} ", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
