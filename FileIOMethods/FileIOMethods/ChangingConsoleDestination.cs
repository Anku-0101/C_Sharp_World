using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOMethods
{
    /// <summary>
    /// Redirection of the standard streams can be accomplished in two ways. First, when you
    /// execute a program on the command line, you can use the<and> operators to redirect
    /// Console.In and/or Console.Out, respectively
    /// 
    /// 
    /// Console Class has three methods which can be used to change destination of Console input and output
    /// static void SetIn(TextReader newIn)
    /// static void SetOut(TextWriter newOut)
    /// static void SetError(TextWriter newError)
    /// </summary>
    class ChangingConsoleDestination
    {
        public static void ChangingDestination()
        {
            StreamWriter streamWriter = null;

            streamWriter = new StreamWriter("loggingFile.txt");
            Console.SetOut(streamWriter);
            Console.WriteLine("This is the start of the log file");

            for (int i = 3; i < 13; i++) Console.WriteLine(i);

            Console.WriteLine("This is the end of log file");
            streamWriter.Close();
        }
    }
}
