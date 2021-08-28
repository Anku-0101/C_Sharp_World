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
            double[] data = new double[] { 5.2, -2.5, 3.0, -1.4, 9, 11, 15, -4.5, 5, 3, 2.6, 3.8 };
            IColumn col = ColumnFactory.CreateDoubleColumn("doubleCol", data);

            IntSet set = col.GetRowIndicesInRange(0, 5);
            IntIterator iterator = set.Iterator();

            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

            bool[,] arr = new bool[2, 3];
            for(int i =0; i<2; i++)
            {
                for(int j =0; j<3; j++)
                    Console.WriteLine(arr[i,j]);
            }

            int[] arr_ = new int[5];
            for (int i = 0; i < 5; i++) Console.WriteLine(arr_[i]);
            Console.ReadKey();
        }
    }
}
