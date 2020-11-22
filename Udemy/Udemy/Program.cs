using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist =new List<string> { "Aman", "Pam","Roy","Jackob","Dwight","Michal","Norman","Stevie"};
            GetpartyFriend getpartyFriend = new GetpartyFriend();
            List<string> result = getpartyFriend.GetPartyFriends(mylist, 3);
            
            foreach(string str in result)
            {
                Console.WriteLine(str);
            }
            Console.Read();
        }

        public void Collections()
        {
            List<object> ls = new List<object>();
            ls.Add(12);
            ls.Add("ABC");
            ls.Add(10);
            ls.Add(11.092);
            ls.Add('k');
            ls.Add(17);

            foreach (var vs in ls)
            {
                Console.WriteLine(vs);
            }


            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add('a');
            arrayList.Add("Abc");
            arrayList.Add(12.5);


            Console.Read();
        }
        public void PropertiesUsed()
        {

            Properties properties = new Properties();
            properties.age = 5;
            int val = properties.count;
        }
        public void Loops()
        {
            int marks = 0;
            int totalScore = 0;
            int studentCount = 0;

            //marks = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Enter the marks");
                bool isParsable = int.TryParse(Console.ReadLine(), out marks);


                if (!isParsable) continue;
                else if (marks == -1) break;
                else
                {
                    totalScore += marks;
                    studentCount++;
                }
            }

            double average = (double)totalScore / (double)studentCount;
            Console.WriteLine(average);
            Console.ReadKey();
        }
        static string Ternary(int val)
        {

            int value;
            prob: Console.WriteLine("Enter Number");
            bool isValid = int.TryParse(Console.ReadLine(), out value);

            string variation = isValid ? Ternary(value) : "Not a valid Temperature";

            Console.WriteLine(variation);
            Console.WriteLine("--------------");
            goto prob;
            int temperature = int.Parse(Console.ReadLine());

            string state;

            state = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liqid";
            Console.WriteLine(state);


            string res;
            res = val <= 15 ? "It is too cold in here" : val >= 16 && val <= 28 ? "It's ok" : "It is hot here";
            // can also be done as 
            // res = val <= 15 ? "It is too cold in here" : val >= 16 && val <= 28 ? "It's ok" : val > 28 ? "It is hot here" : ""; 
            return res;
        }


        static bool CheckGame(int score, string name)
        {
             int highScore = 0;
            string playerName;
            bool b = false;

            playerName = "A";
            
            if (playerName == "A") b = true;
            b = false;


            if (score > highScore)
            {
                return true;
            }
            else return false;
            

            
        }
        private int rollNumber;

        public int RollNumber
        {
            get
            {
                return rollNumber;
            }
            set
            {
                rollNumber = value;
            }
        }
        public static void TryCatchFinally()
        {
            Console.WriteLine("Enter a number");
            start: string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Format error !");
                goto start;
            }
            finally
            {
                Console.WriteLine("won't be able to exit till user enter a valid number");
            }

            Console.WriteLine("Exited sucessfully only after entering a valid number");
        }
        public static void UsingTryParse()
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int number;
            bool canParse = int.TryParse(input, out number);
            if (canParse) Console.WriteLine(number);
            else Console.WriteLine("Input is in wrong format");
            Console.ReadKey();
        }

        public static void DoneBeforeMethod()
        {
            string str = "26";
            string str_ = "78";
            int value_;

            bool itr = Int32.TryParse(str, out value_);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            string name = "Aman";
            string sentence = string.Format("My name is {0} ", name);

            int a = sentence.IndexOf("name");
            Console.WriteLine(a);
            Console.WriteLine(sentence);
            Console.WriteLine(sentence.ToUpper());

            int x = Console.Read();

            Console.WriteLine(x);

            double myVal = -2.6;
            int value = (int)myVal;
            Console.WriteLine(value);
        }
    }
}
