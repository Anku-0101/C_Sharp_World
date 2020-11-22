using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        /// <summary>
        /// Driver method 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string pattern = @"\d";

            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 13321";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count,text);
            
            foreach(Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value,group[0].Index);
            }
            Console.ReadKey();
        }
    }
}
