using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_PBR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };

            PrintArray(marks, 5);
            UpdateArray(marks, 5);
            PrintArray(marks, 5);
            Console.Read();
        }

        static void PrintArray(int[] arr, int n)
        {
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void UpdateArray(int[] arr, int n)
        {
            for(int i = 0; i <n; i++)
            {
                arr[i] = arr[i] + 2;
            }
        }
    }
}
