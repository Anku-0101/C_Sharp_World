using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDotNetSkool
{
    interface ICursor
    {
        void calculate();
    }
    class A
    {
        public void DisplayA()
        {
            Console.WriteLine("Displaying A");
        }
    }

    class B : A
    {
        public void Add(int x, int p)
        {
            Console.WriteLine("Sum is ", x+p);
        }
    }
    class Program
    {
        //The following methods are not overloaded
        //public int Add(int x, int y)
        //{
        //    return x + y;
        //}

        

        //public string Add(int x, int y)
        //{
        //    return "The sum is x + y";
        //}

        //The following methods too are not overloaded
        //public int Multiply(int x, out int y)
        //{
        //    y = 1;
        //    return x * y;
        //}

        //public int Multiply(int x, ref int y)
        //{
        //    return x * y;
        //}
        static void Main(string[] args)
        {
            string str = "87";
            int num;
            bool isParsable = int.TryParse(str,out num);

            Console.WriteLine(isParsable);
            Console.WriteLine(num);

            int p = 8, q = 9;

            int ans1, ans2;
            Add(p, q,out ans1,out ans2);
            Program program = new Program();
            program.diff(p, q);

            A b = new B(); // Right as base class reference can always point to derived class but vice versa is not true
            //B b = new A();  This reference is not true
            Console.ReadKey();
        }

        public static int Add(int x, int y, out int sum, out int multiply)
        {
            sum = x + y;
            multiply = x * y;
            return x;
        }

        public int diff(int x, int y)
        {
            return x > y ? x - y : y - x;
        }
    }
}
