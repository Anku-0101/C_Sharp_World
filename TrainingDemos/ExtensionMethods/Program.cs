using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension method Demo
            TestAnimalClass();
            Console.ReadKey();
            

            // Q. Extend string class and add a method " ReverseString()"
        }

        public static void TestAnimalClass()
        {
            Animal animal = new Animal();
            animal.SetColor("White");
            animal.SetNumberOfLegs(4);
            animal.SetSpecies("Cow");

            Console.WriteLine("Color  = " + animal.GetColor());


            Console.WriteLine("Number of legs = " + animal.GetNumberOfLegs().ToString());
            Console.WriteLine("Species = "+ animal.GetSpecies());
           
        }
    }

    
}

