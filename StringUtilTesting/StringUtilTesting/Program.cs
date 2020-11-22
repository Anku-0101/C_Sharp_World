using System;
using System.Text;

namespace StringUtilTesting
{
    class Program
    {

        public static int Split(string aString, string[] tokens, char delim)
        {

            int maxTokens = tokens.Length;
            int nTokens = 0;
            int start = 0;
            int end = aString.IndexOf(delim);

            if (end < 0)
            {
                tokens[nTokens++] = aString;
                return nTokens;
            }

            while ((end > 0) && (nTokens < maxTokens))
            {
                //Subtring methods overload are little different in Java and in C#
                //In C# public string Substring(int startIndex, int length)
                //In Java public String substring(int begIndex, int endIndex)
                tokens[nTokens++] = aString.Substring(start, end - start);
                start = end + 1;
                end = aString.IndexOf(delim, start);

            }
            // Add the trailing string,  if there is room and if it is not empty.
            if (nTokens < maxTokens)
            {
                string trailingString = aString.Substring(start);
                if (trailingString.Length > 0)
                {
                    tokens[nTokens++] = trailingString;
                }
            }
            return nTokens;
        }

        static void Main(string[] args)
        {
            string sIn = "This is a test string used for splitting";
            string[] tokensExpected = { "Th", "s", "s a test str", "ng used for spl", "tt", "ng" };
            string[] tokensActual = new string[6];
            char delim = 'i';
            Split(sIn, tokensActual, delim);

            foreach (string s in tokensActual)
            {
                Console.WriteLine(s);
            }

            //string sIn = "This is a test string used for splitting";
            //char delim = 'i';

            //string[] tokensExpected1 = { "Thi", "s i", "s a test stri", "ng used for splitting" };
            //string[] tokensActual1 = new string[4];
            //SplitConcatenateExcessTokens(sIn, tokensActual1, delim);

            //foreach (string s in tokensActual1)
            //{
            //    Console.WriteLine(s);
            //}

            //string inString = "14186";
            //byte[] inByteArray = StringToBytes(inString);
            //Console.WriteLine(BytesToHexString(inByteArray));

        }

    }
    }

