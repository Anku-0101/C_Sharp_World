using System;
using System.Collections.Generic;

namespace TryAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<object, object> keyValues = new Dictionary<object, object>();
            keyValues.Add(0, "A");
            Console.WriteLine(keyValues.TryAdd(0, "A"));  

            Console.WriteLine("Hello World!");
        }
    }
}
