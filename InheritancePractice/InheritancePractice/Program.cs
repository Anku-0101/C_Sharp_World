using System;

namespace InheritancePractice
{
    class A
    {
        public int fieldA;
        public void Print()
        {
            Console.WriteLine("printing A");
        }
    }

    class B : A
    {
        public int fieldB;
        public virtual void Print()
        {
            Console.WriteLine("Printing B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a= new B();
            
            a.Print();
            Console.ReadKey();
        }
    }
}
