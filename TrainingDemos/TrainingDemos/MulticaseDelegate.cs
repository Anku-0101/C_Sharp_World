using System;
namespace TrainingDemos
{
    public delegate void Compute(int val);
    public class MulticaseDelegate
    {

        public void Square(int x)
        {
            Console.WriteLine("Square of " + x + " = " + x*x);
        }

        public void Cube(int x)
        {
            Console.WriteLine("Cube of " + x + " = " + x*x*x);
        }

        public void CallMultipleMethods(int num)
        {
            Compute c = Square;
            c += Cube;

            c.Invoke(num); // c(num)
           
        }
    }
}

