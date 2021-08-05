using Agilent.MHDA.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClassLibrary_Net_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new StrandLogger(typeof(Program));
            ///StrandLogger strand = new StrandLogger(typeof(Program));


            logger.Error("Handle this error A");
            logger.Info("Logging info logs A");
            logger.Fatal("Logging fatal logs A");
            logger.Debug("Debug log A");
            Console.WriteLine("Handled Logs");
            Console.ReadLine();

        }
    }
}
