using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    //Lamda expression is also included
    class AnonymousMethodPractice
    {
        public delegate string GetTextDelegate(string name);
        public delegate double GetResultDelegate(double a, double b);
        public static void AnonymousMain(string[] args)
        {
            //Creating an anonymous method
            GetTextDelegate getTextDelegate = delegate (string abc)
            {
                return "Hello ," + abc;
            };

            Console.WriteLine(getTextDelegate("Aman"));

            //Expression lambda
            GetTextDelegate getHello = (string name) => { return "Hello, " + name; };
            Console.WriteLine(getHello("How are you"));

            //Statement lambda
            GetTextDelegate getGoodbyetext = (string name) =>
            {
                Console.WriteLine("I'm inside of an statement");
                return "Goodbye, " + name;
            };
            Console.WriteLine(getGoodbyetext("Raj"));

            //Powerful lambda expression...
            GetTextDelegate getWelcomeText = name_ => "Welcome, " + name_;
            Console.WriteLine(getWelcomeText("New members"));


            GetResultDelegate getSum = (a, b) => a + b;

            DisplayNum(getSum);


            Display(getTextDelegate);

            Console.ReadKey();
        }

        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(4,5));
        }
        static void Display(GetTextDelegate del)
        {
            Console.WriteLine(del("My World "));
        }

    }
}
