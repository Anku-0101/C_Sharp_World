using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log4NetLibrary;

namespace TestLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogService logService = new FileLogService(typeof(Program));

            logService.Debug("Debug started");
            logService.Error("Logging Error");
            logService.Fatal("Fatal message");
            Console.WriteLine("Fatal message");
            Console.WriteLine("Debugging");
            Console.ReadLine();
        }
    }
}
