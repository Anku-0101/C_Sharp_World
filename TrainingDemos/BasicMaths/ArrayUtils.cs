using System;
using System.Collections.Generic;

namespace BasicMaths
{
    public class ArrayUtils
    {
        public int GetMax(List<int> arr)
        {
            if(arr.Count == 0)
            {
                throw new Exception("Empty list");
            }
            int max = arr[0];
            for(int i = 0; i<arr.Count; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        public int GetMin(List<int> arr)
        {
            if (arr.Count == 0)
            {
                throw new Exception("Empty list");
            }
            int min = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        public float GetAverage(List<int> arr)
        {
            float Sum = SumList(arr);

            return Sum / arr.Count; 
        }

        public int GetUnique(List<int> arr)
        {
            HashSet<int> unique = new HashSet<int>();
            foreach(int val in arr)
            {
                unique.Add(val);
            }
            return unique.Count;
        }

        public Dictionary<int, int> FrequencyCounter(List<int> arr)
        {
            // arr = 1,2,1,2,3
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach(int val in arr)
            {
                if (freq.ContainsKey(val))
                {
                    freq[val]++;
                }
                else
                {
                    freq.Add(val, 1);
                }
            }
            // freq -> (1,2) , (2,1)
            return freq;
        }
        public void Test_FreqCounter()
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 1, 1, 2, 5 };
            Dictionary<int, int> freq = FrequencyCounter(arr);

            Dictionary<int, int> res = new Dictionary<int, int>();
            res.Add(1, 3);
            res.Add(2, 2);
            res.Add(3, 1);
            res.Add(4, 1);
            res.Add(5, 1);

            foreach(int key in res.Keys)
            {
                //Assert.Equal(freq[key], res[key]);
            }

        }

        public void AutomateGetMaxTest()
        {
            for(int i = 0; i < 1000000000; i += 50)
            {
                List<int> input_ = new List<int>();
                for(int j = i; j<i+50; j++)
                {
                    input_.Add(j);
                }

                int res = GetMax(input_);
                Assert.Equal(res, i + 49);
            }
        }
        public List<int> GetMostFreqElement(List<int> arr)
        {
            List<int> res = new List<int>();
            int maxFreq = 0;
            Dictionary<int, int> freq = FrequencyCounter(arr);
            foreach(int key in freq.Keys)
            {
                if (freq[key] > maxFreq)
                {
                    maxFreq = freq[key];
                }
            }

            foreach(int key in freq.Keys)
            {
                if (freq[key] == maxFreq)
                    res.Add(key);
            }
            return res;
        }

        private float SumList(List<int> arr)
        {
            int res = 0;
            foreach(int val in arr)
            {
                res += val;
            }
            return (float)res;
        }
    }


}

