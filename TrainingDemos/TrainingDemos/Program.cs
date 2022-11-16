using System;
using System.Collections.Generic;

namespace TrainingDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1. Generic Demo
            //GenericsDemo();

            //2. Collections Demo
            //CollectionsDemo();

            //3. Indexers Demo
            //IndexersDemo();

            //4. Reflection Demo
            //ReflectionDemo();

            //5. Delegate Demo
            //DelegateDemo();

            //6. MultiCast Delegate
            //MulticastDelegateDemo();

            //7. Events
            //EventsDemo();

            //8. AnynomousMethodLambdaExpression
            //AnynomousMethodLambdaExpressionDemo();

            //9. ExceptionHandling Demo
            ExceptionDemo();

            Console.ReadKey();

        }

        /// <summary>
        /// Method to show call Generic class and demo its features
        /// </summary>
        public static void GenericsDemo()
        {
            Generics<int> arr = new Generics<int>(10);
            arr.AddOrUpdate(2, 5);
            Console.WriteLine(arr.GetData(2));

            Generics<double> arr1 = new Generics<double>(25);
            arr1.AddOrUpdate(5, 9.8);
            Console.WriteLine(arr1.GetData(5));   
        }

        public static void CollectionsDemo()
        {
            Collections col = new Collections();
            col.AddNumberOfDays("January", 31);
            col.AddNumberOfDays("February", 28);
            col.AddNumberOfDays("April", 30);

            col.getDaysInMonth();

            col.AddObjects("C#");
            col.AddObjects("Monday");
            col.AddObjects(24);
            col.AddObjects('Q');
            col.AddObjects(4.9);

            col.GetObjects();
        }

        public static void IndexersDemo()
        {
            Person person = new Person();
            Console.WriteLine("First person name = {0} 2nd Person name = {1} ", person[0], person[1]);
        }

        public static void ReflectionDemo()
        {
            ReflectionDemo rf = new ReflectionDemo();
            rf.Demo();
        }

        public static void DelegateDemo()
        {
            Delegates delegates = new Delegates();
            delegates.CallSquareMethodByDelegate();
        }

        public static void MulticastDelegateDemo()
        {
            MulticaseDelegate multicaseDelegate = new MulticaseDelegate();
            multicaseDelegate.CallMultipleMethods(6);
        }

        public static void EventsDemo()
        {
            Events events = new Events();
            events.NotifyUsers();
        }

        public static void AnynomousMethodLambdaExpressionDemo()
        {
            AnynomousMethodLambdaExpression anynomousMethodLambdaExpression = new AnynomousMethodLambdaExpression();

            anynomousMethodLambdaExpression.AnynomousMethod();
            anynomousMethodLambdaExpression.LambdaExpression();
        }

        public static void ExceptionDemo()
        {
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.ExceptionDemo();
        }
    }
}

