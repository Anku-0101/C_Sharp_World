using System;
namespace TrainingDemos
{
    delegate int Transformer(int x); // Delegates' signature must match with the method signature
    public class Delegates
    {
        public int Square(int num)
        {
            return num * num;
        }

        public void CallSquareMethodByDelegate()
        {
            Console.WriteLine("Enter the number");
            int i = int.Parse(Console.ReadLine());

            Transformer t = Square;
            int res = t.Invoke(i); // t(i) // call delegate directly

            Console.WriteLine("Square of number = " + res);
        }
        
    }


}

