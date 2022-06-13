using Agilent.MHDA.Dataset;
using Agilent.MHDA.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasetMethodsTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //CheckingDatasetMethod();
            //TestingDictionary();
            //TreeMap();
            //checkRem();
            //ValueString();
            Console.ReadKey();
        }

        static bool ValidParan(string inp)
        {
            Stack<char> paran = new Stack<char>();
            paran.Peek();
            List<char> hg = new List<char>();
            hg.Contains('a');
            //hg.Remove()
            return true;
        }
        static void ValueString()
        {
            float x = float.MaxValue;
            string str = x.ToString();
            Console.WriteLine(str);
            bool res = float.MaxValue.ToString() == str;
            Console.WriteLine(res);
        }
        static void checkRem()
        {
            double val = 0.0001;
            Console.WriteLine(val%1);
            bool res = val % 1 == 0;
            Console.WriteLine(res);
        }
        static void TreeMap()
        {
            Dictionary<double, string> meanMap = new Dictionary<double, string>();
            meanMap.Add(9.8, "QWE");
            meanMap.Add(3.4, "QSW");
            meanMap.Add(2.1, "awe");
            meanMap.Add(33, "sse");
            meanMap.Add(21, "wde");
            meanMap.Add(6, "val");

            List<double> key = new List<double>();
            foreach(var keys in meanMap.Keys)
            {
                key.Add(keys);
                Console.WriteLine(keys);
                Console.WriteLine(meanMap[keys]);
            }

            key.Sort();
            
                

            Dictionary<double, string> sortedDictionary = new Dictionary<double, string>();
            foreach (double val in key)
            {
                sortedDictionary.Add(val, meanMap[val]);
            }
            Console.WriteLine("printing tree map");
            foreach(double val in sortedDictionary.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(sortedDictionary[val]);
            }
        }
        static void TestingDictionary()
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            keyValuePairs.Add("ABC", 5);

            keyValuePairs["ABC"] = keyValuePairs["ABC"] + 7;

            Console.WriteLine(keyValuePairs["ABC"]);
        }
        static void RoundingFloatingPoint()
        {
            float val = Convert.ToSingle(Console.ReadLine());
            float truncate = (float)(Math.Truncate((double)val * 100.0) / 100.0);
            float roundedOFF = (float)Math.Round((decimal)val, 2);
            Console.WriteLine(truncate);
        }
        static void GetRowMatchingIndices()
        {
            int[] data_for = new int[] {10, 23, 54, 67, 99, 45, 76};
            int[] data_in = new int[] { 878, 10, 54, 111, 99, 44, 76, 88, 67, 23, 45 };

            IColumn searchFor = ColumnFactory.CreateIntColumn("SerchFOR", data_for);
            IColumn searchIn = ColumnFactory.CreateIntColumn("SearchIN", data_in);

            IndexedIntArray searchedIndices = DatasetUtil.GetMatchingRowIndices(searchFor, searchIn);

            for (int i = 0; i < searchedIndices.GetSize(); i++)
            {
                Console.WriteLine("Searched Indices = {0} ", searchedIndices.Get(i));
            }
            Console.WriteLine();
            IColumn subSetColumn =  ColumnFactory.CreateSubsetColumn(searchIn, searchedIndices);

            for (int i = 0; i < subSetColumn.GetSize(); i++)
            {
                Console.WriteLine("Subset column at index = {0} has value = {1} ", i, subSetColumn.Get(i));
            }
            Console.WriteLine();
            for (int i = 0; i < searchFor.GetSize(); i++)
            {
                Console.WriteLine("SearchFor column at index = {0} has value = {1} ", i, searchFor.Get(i));
            }
        }
        static void percentile()
        {
            while (true)
            {
                float percentile = Convert.ToSingle(Console.ReadLine());

                int num = Convert.ToInt32(Console.ReadLine());

                float product = (percentile * num) / 100;
                Console.WriteLine("Product is {0}", product);

                int result;

                if (product % 1 == 0)
                    result = (int)product;
                else
                    result = (int)product + 1;

                Console.WriteLine("result is {0}", result);
            }
        }
        static void CheckingDatasetMethod()
        {
            double[] data = new double[] { 5.2, -2.5, 3.0, -1.4, 9, 11, 15, -4.5, 5, 3, 2.6, 3.8, 0 };
            IColumn col = ColumnFactory.CreateDoubleColumn("doubleCol", data);

            IntSet set = col.GetRowIndicesInRange(0, 5); // Both limits are inclusive

            //IntSet set = col.GetRowIndicesInRange(0,true ,5,true); // LL is not inclusive , UP is inclusive

            //IntSet set = col.GetRowIndicesInRange(0, false, 5, false); // Both limits are inclusive

            //IntSet set = col.GetRowIndicesInRange(0, true, 5, false); // LL is inclusive and UL in not inclusive

            //IntSet set = col.GetRowIndicesInRange(0, false, 5, true); // Both are inclusive

            IntIterator iterator = set.Iterator();


            while (iterator.HasNext())
            {

                Console.WriteLine(iterator.Next());
            }

            Console.WriteLine("\n Original Data \n");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine();
                Console.Write(data[i]);
                Console.Write("\t Has index \t");
                Console.Write(i);
            }

        }
    }
}
