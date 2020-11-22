using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapUtilTest
{
    public class MapUtil
    {
        /// <summary>
        /// Unmodifiable map(IDictionary in C#) of size 0.
        /// It is very convenient to initalize a variable to EMPTY_MAP instead of null.
        /// It will make code clean by eliminating lot of null checks.
        /// </summary>
        public static IDictionary<object, object> EMPTY_MAP = new ReadOnlyDictionary<object, object>(new Dictionary<object, object>());

        // {{{ get/putXXX methods

        /// <summary>
        /// Returns <code>map.get(key)</code>. 
        /// Added for completeness.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object Get(IDictionary<object, object> map, object key)
        {
            return map[key];
        }

        public static object Get(IDictionary<object, object> map, object key, object defaultValue)
        {
            return map.ContainsKey(key) ? map[key] : defaultValue;
        }

        /// <summary>
        /// Same as <code>map.put(key, value)</code>. 
        /// Added for completeness.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Put(IDictionary<object, object> map, object key, object value)
        {
            if(!map.ContainsKey(key))
            map.Add(key, value);
            else
            {
                map[key] = value;
            }
        }

        public static int GetInt(IDictionary<object, object> map, object key)
        {
            object temp = map[key];
            if (temp == null)
                return -1;
            else
            {
                //In java Integer is used as casting gives error on primitive type int
                //In C# Int32 is used as Int32 is the wrapper class for int  
                Int32 value = (Int32)temp;

                //In java value.intValue was used, which is like floor function
                //In C# we should be typecasting it to int 
                //We should not be using method Convert.TOInt32(value) as it rounds off the value to its nearest integer
                return (int)value;
            }
        }

        public static int GetInt(IDictionary<object, object> map, object key, int defaultValue)
        {
            return map.ContainsKey(key) ? GetInt(map, key) : defaultValue;
        }

        public static void PutInt(IDictionary<object, object> map, object key, int value)
        {
            map.Add(key, value);
        }


        public static long GetLong(IDictionary<object, object> map, object key)
        {
            object temp = map[key];
            if (temp == null)
                return -1;
            else
            {

                Int64 value = (Int64)temp;
                return (long)value;
            }
        }

        public static long GetLong(IDictionary<object, object> map, object key, long defaultValue)
        {
            return map.ContainsKey(key) ? GetLong(map, key) : defaultValue;
        }

        public static void PutLong(IDictionary<object, object> map, object key, long value)
        {
            map.Add(key, value);
        }


        public static float GetFloat(IDictionary<object, object> map, object key)
        {
            object temp = map[key];
            Single value = (Single)temp;
            return (float)value;
        }

        public static float GetFloat(IDictionary<object, object> map, object key, float defaultValue)
        {
            return map.ContainsKey(key) ? GetFloat(map, key) : defaultValue;
        }

        public static void PutFloat(IDictionary<object, object> map, object key, float value)
        {
            map.Add(key, value);
        }

        public static double GetDouble(IDictionary<object, object> map, object key)
        {
            object temp = map[key];
            Double value = (Double)temp;
            return (double)value;
        }

        public static double GetDouble(IDictionary<object, object> map, object key, double defaultValue)
        {
            return map.ContainsKey(key) ? GetDouble(map, key) : defaultValue;
        }

        public static void PutDouble(IDictionary<object, object> map, object key, double value)
        {
            map.Add(key, value);
        }

        public static bool GetBoolean(IDictionary<object, object> map, object key)
        {
            object temp = map[key];
            Boolean value = (Boolean)temp;
            return (bool)value;
        }

        public static bool GetBoolean(IDictionary<object, object> map, object key, bool defaultValue)
        {
            return map.ContainsKey(key) ? GetBoolean(map, key) : defaultValue;
        }

        public static void PutBoolean(IDictionary<object, object> map, object key, bool value)
        {
            map.Add(key, value);
        }

        // }}}

        // {{{ creteMap methods

        /// <summary>
        /// Creates an empty map.
        /// </summary>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap()
        {
            return new Dictionary<object, object>();
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(object[] keys, object[] values)
        {
            IDictionary<object, object> map = new Dictionary<object, object>();

            for (int i = 0; i < keys.Length; i++)
                map.Add(keys[i], values[i]);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <param name="key2"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1,
            object key2, object value2)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);
            map.Add(key2, value2);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <param name="key2"></param>
        /// <param name="value2"></param>
        /// <param name="key3"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1,
            object key2, object value2,
            object key3, object value3)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);
            map.Add(key2, value2);
            map.Add(key3, value3);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <param name="key2"></param>
        /// <param name="value2"></param>
        /// <param name="key3"></param>
        /// <param name="value3"></param>
        /// <param name="key4"></param>
        /// <param name="value4"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1,
            object key2, object value2,
            object key3, object value3,
            object key4, object value4)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);
            map.Add(key2, value2);
            map.Add(key3, value3);
            map.Add(key4, value4);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <param name="key2"></param>
        /// <param name="value2"></param>
        /// <param name="key3"></param>
        /// <param name="value3"></param>
        /// <param name="key4"></param>
        /// <param name="value4"></param>
        /// <param name="key5"></param>
        /// <param name="value5"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1,
            object key2, object value2,
            object key3, object value3,
            object key4, object value4,
            object key5, object value5)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);
            map.Add(key2, value2);
            map.Add(key3, value3);
            map.Add(key4, value4);
            map.Add(key5, value5);

            return map;
        }

        /// <summary>
        /// Creates a map with the specified key-value pairs.
        /// </summary>
        /// <param name="key0"></param>
        /// <param name="value0"></param>
        /// <param name="key1"></param>
        /// <param name="value1"></param>
        /// <param name="key2"></param>
        /// <param name="value2"></param>
        /// <param name="key3"></param>
        /// <param name="value3"></param>
        /// <param name="key4"></param>
        /// <param name="value4"></param>
        /// <param name="key5"></param>
        /// <param name="value5"></param>
        /// <param name="key6"></param>
        /// <param name="value6"></param>
        /// <returns></returns>
        public static IDictionary<object, object> CreateMap(
            object key0, object value0,
            object key1, object value1,
            object key2, object value2,
            object key3, object value3,
            object key4, object value4,
            object key5, object value5,
            object key6, object value6)
        {

            IDictionary<object, object> map = new Dictionary<object, object>();
            map.Add(key0, value0);
            map.Add(key1, value1);
            map.Add(key2, value2);
            map.Add(key3, value3);
            map.Add(key4, value4);
            map.Add(key5, value5);
            map.Add(key6, value6);

            return map;
        }
        // }}}

        //params is used in C# when we don't know about the number of arguments that are 
        //supposed to be passed to the method 
        public static IDictionary<object, object> CreateMap(params object[] items)
        {
            IDictionary<object, object> map = new Dictionary<object, object>();

            for (int i = 1; i < items.Length; i += 2)
            {
                object key = items[i - 1];
                object value = items[i];
                map.Add(key, value);
            }
            return map;
        }



        // In java we use LinkedHashMap as it preserves insertion order, whereas in case
        // of C# we can directly use dictionary which by default preserves insertion order

        public static IDictionary<object, object> CreateLinkedMap(params object[] items)
        {
            IDictionary<object, object> map = new Dictionary<object, object>();
            for (int i = 1; i < items.Length; i += 2)
            {
                object key = items[i - 1];
                object value = items[i];
                map.Add(key, value);
            }
            return map;
        }
    }
}