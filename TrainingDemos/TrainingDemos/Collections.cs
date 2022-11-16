using System;
using System.Collections;
using System.Collections.Generic;

namespace TrainingDemos
{
    public class Collections
    {
        private Dictionary<string, int> monthVsDays;
        private ArrayList al;

        public Collections()
        {
            monthVsDays = new Dictionary<string, int>();
            al = new ArrayList();
        }

        public void AddNumberOfDays(string month, int days)
        {
            monthVsDays.Add(month, days);
        }

        public void getDaysInMonth()
        {
            foreach(string month in monthVsDays.Keys)
            {
                Console.WriteLine("month " + month + " has total " + monthVsDays[month].ToString() + " days");
            }
        }

        public void AddObjects(Object obj)
        {
            al.Add(obj);
        }

        public void GetObjects()
        {
            foreach(Object obj in al)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}

