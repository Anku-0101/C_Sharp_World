using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerImplementation;

namespace TestLog
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new StrandLogger(typeof(Program));
            ///StrandLogger strand = new StrandLogger(typeof(Program));
            

            logger.Error("Handle this error");
            logger.Info("Logging info logs");
            logger.Fatal("Logging fatal logs");
            logger.Debug("Debug log");
            Console.WriteLine("Handling Logs");
            Console.ReadLine();

        }
    }
}
