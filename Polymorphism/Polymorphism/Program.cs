using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEvents;
            bool play = true;
            
            while(play)
            {
                numEvents = dice.Next(1, 4);
                switch(numEvents)
                {
                    case 1:
                        Console.WriteLine("Yes");
                        break;

                    case 2:
                        Console.WriteLine("No");
                        break;

                    case 3:
                        Console.WriteLine("Maybe");
                        break;
                    default:
                        break;
                    
                }
                Console.WriteLine("Want to play more? (Y/N)");
                string str = Console.ReadLine();
                char ch = str[0];
                if (ch == 'Y') play = true;
                else play = false;
                   
            }
            Console.Read();
            
        }
        public void UsingFileStreamAndFileClass()
        {
            FileStream fileStream = new FileStream(@"D:\ReaderIO\textfile.txt", FileMode.Open);

            byte[] arr = new byte[50];
            fileStream.Read(arr, 0, 45);

            foreach (var v in arr)
            {
                Console.WriteLine((char)v);

            }
            Console.ReadKey();

            //Using File static class
            string text = File.ReadAllText(@"D:\ReaderIO\textfile.txt");
            Console.WriteLine(text);
            Console.ReadLine();

            string[] lines = { "first line ", "Second line", "ThirdLine" };

            File.WriteAllLines(@"D:\ReaderIO\textfilewriter.txt", lines);

            string fileName = Console.ReadLine();
            string input = Console.ReadLine();

            File.WriteAllText(@"D:\ReaderIO\" + fileName + ".txt", input);

            // Using helps us to open and close streamWriter automatically 
            using (StreamWriter file = new StreamWriter(@"D:\ReaderIO\streamfile.txt"))
            {
                foreach (string str in lines)
                {
                    if (str.Contains("Third"))
                    {
                        file.WriteLine(str);
                    }
                }
            }
        }
    }
}
