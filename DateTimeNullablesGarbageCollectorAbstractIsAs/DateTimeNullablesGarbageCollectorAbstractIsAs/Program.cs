using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeNullablesGarbageCollectorAbstractIsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> myInt = null;
            bool? identity = null;
            identity = true;
            Console.WriteLine(identity);
            int y = myInt.GetValueOrDefault();
            Console.WriteLine(y);

            bool x = myInt.HasValue;
            Console.WriteLine(x);

            double? num = null;
            Console.WriteLine("Enter a double");
            string str = Console.ReadLine();
            if (str != null && str.Trim().Length > 0)
            {
                num = Convert.ToDouble(str);
            }
            Console.WriteLine(num);
            

            DateTime dateTime = new DateTime(2018,5,31);

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            //int days = DateTime.DaysInMonth(2104, 2);
            //Console.WriteLine(days);

            Console.WriteLine("Enter your birthday in yyyy-mm-dd format");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out dateTime))
            {
                DateTime now = DateTime.Now;
                TimeSpan timeSpan = now.Subtract(dateTime);
                Console.WriteLine("Days passed since your b'dy {0}",timeSpan.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            
            Console.ReadKey();
        }
    }
}
