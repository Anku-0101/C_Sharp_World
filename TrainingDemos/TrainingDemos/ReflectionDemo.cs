using System;
using System.Reflection;

namespace TrainingDemos
{
    public class ReflectionDemo
    {
        public void Demo()
        {
            Type t = typeof(string);

            // Use Reflection to find about
            // any sort of data related to type String
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
        }
    }
}

