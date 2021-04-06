using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace SystemTextJSONTest
{
    class Program
    {
        public static FileStream FileStream { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee emp = new Employee(231, "Shiva");
            emp.Age = 23;
            emp.Salary = 3452.3f;
            
            Address ad = new Address();
            ad.City = "Bangalore";
            ad.HouseNumber = 983;
            ad.PINCode = 812342;
            ad.State = "Maharashtra";

            emp.address = ad;

            emp.Introduce();



            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            // JSON serialized String 
            string JSONSerializer = JsonSerializer.Serialize<Employee>(emp, options);

            Console.WriteLine(JSONSerializer);


            var options1 = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var e1 = JsonSerializer.Deserialize<Employee>(JSONSerializer, options1);
            Employee emp1 = (Employee)e1;
            Console.WriteLine(emp1.Age);

            //string jsonoutput = JsonSerializer.Serialize(emp, new JsonSerializerOptions(
            //    new JsonSerializerDefaults{}){});
            //Console.WriteLine(jsonoutput);
            //File.WriteAllText("serializeddata.json", jsonoutput);

            //string JsonString = File.ReadAllText("SerializedData.json");
            //Employee e1 = JsonSerializer.Deserialize<Employee>(JsonString, new JsonSerializerOptions(new JsonSerializerDefaults { }));
            //Console.WriteLine(e1.address.City);
            //Console.WriteLine(e1.address.HouseNumber);
            //Console.WriteLine(e1.address.PINCode);
            //Console.WriteLine(e1.address.State);
            //Console.WriteLine(e1.Age);
            //Console.WriteLine(e1.Salary);

            //string filepath = @"D:\\Folder\\abcq.json";

            //FileStream fileStream = new FileStream(filepath, FileMode.Create);
            //Utf8JsonWriter utf8JsonWriter = new Utf8JsonWriter(fileStream);

            //JsonSerializer.Serialize(utf8JsonWriter, emp);

            //FileStream fileStream1 = new FileStream(filepath, FileMode.Open);
            //string contents = File.ReadAllText(filepath);
            //Employee emp1 = null;
            //emp1 = (Employee)JsonSerializer.Deserialize(contents, typeof(Employee));
            //Console.WriteLine(emp1.Age);
            //Console.WriteLine(emp1.Salary);
            //emp1.Introduce();
            //BinaryFormatter bf = new BinaryFormatter();
            //string filename = "abc.dat";
            //if (File.Exists(filename))
            //{
            //    File.Delete(filename);
            //}

            //FileStream fileStream= File.Create(filename);
            //bf.Serialize(fileStream, emp);


            //fileStream.Close();

            //fileStream = File.OpenRead(filename);
            //object obj = bf.Deserialize(fileStream);
            //Employee e1 = (Employee)obj;
            //Console.WriteLine(e1.Age);
            Console.Read();
        }
    }
}
