using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class DelegatesPractice
    {
        public delegate double PerformCalculation(double x, double y);

        public static double Addition(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }
        public static double Multiplication(double a, double b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
        public static double Subtraction(double a, double b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }
        public static void DelegatesMain(string[] args)
        {
            PerformCalculation getSum = Addition;
            PerformCalculation getquotient = Division;


            //Console.WriteLine(getSum(5.4, 5.2));


            PerformCalculation multiCastDelegate = getSum + getquotient + Multiplication;
            multiCastDelegate += Subtraction;
            multiCastDelegate(15, 3);

            Console.WriteLine();
            multiCastDelegate -= Addition;
            multiCastDelegate(10, 2);

            Console.ReadKey();
        }
    }
}
