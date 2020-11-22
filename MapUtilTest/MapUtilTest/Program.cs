using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtilTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<object, object> mydata = new Dictionary<object, object>();
            //mydata.Try
            MapUtil.Put(mydata, 5, "Name");  // Reported Error
            MapUtil.Put(mydata, 5, "AGE");
            Console.WriteLine(mydata[5]);
            Console.WriteLine(mydata.ContainsKey(2));
            

            IDictionary<object, object> keyValues = MapUtil.CreateMap(); // Reported Error
            MapUtil.Put(keyValues, "Banglore", "Address");
            Console.WriteLine(keyValues["Banglore"]);
            
            Console.ReadKey();
        }
    }
}