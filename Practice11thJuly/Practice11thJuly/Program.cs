using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11thJuly
{
    class Customer
    {
        public const int NO_OF_DAYS = 365;
        public static int numOfVisits;
        string name;
        public Customer()
        {
            Console.WriteLine("I am an instance constructor");
        }
        static Customer()
        {
            numOfVisits = 3;
            //this.name = "ABC";
            Console.WriteLine("I am a static constructor");
        }
    }
    class Methods
    {
        public int firstValue; 
        public int AddMultiply(int a, int b, ref int product, ref int sum)
        {
            sum = a + b;
            product = a * b;
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            float x = 0.00574f; // 5.74E-03
            string str = x.ToString("0.000E0");
            decimal d = Convert.ToDecimal(x);
            float y = 2.0000000f;
            int[] arr = new int[5];
             
            if (x % 1 == 0) Console.WriteLine("x is integer");
            if (y % 1 == 0) Console.WriteLine("y is integer");
            Console.WriteLine(str);
            //Methods methods = new Methods();
            //methods.firstValue = 21;
            //Methods methods1 = new Methods();
            //methods1 = methods;
            //Console.WriteLine(methods1.firstValue);
            //methods.firstValue = 23;
            //Console.WriteLine(methods1.firstValue);
            //int p, q, r=0, s=0;
            //p = 9;
            //q = 21;
            //methods.AddMultiply(p, q, ref r, ref s);

            ///Customer customer = new Customer();

            //Console.WriteLine(r);
            //Console.WriteLine(s);
            //Console.Beep(32767, 10000);


            Console.ReadKey();
        }
    }

    public abstract class Documents
    {
        public abstract void ScanDocuments();
        public abstract int NumberOfDocuments();
        public abstract void PrintDocuments();

        private int Add(int x, int y)
        {
            return 1;
        }

        private float Add(float x, float y)
        {
            return 1.2f;
        }
    }
}
