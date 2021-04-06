using System;
using System.Xml;

namespace XmlReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\testing.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("Creating XML file");
            xmlWriter.WriteStartElement("Employees");

            for(int i = 1; i<4; i++)
            {
                xmlWriter.WriteStartElement("e" + i);
                Console.WriteLine("Enter Employee name");
                xmlWriter.WriteElementString("Name ", Console.ReadLine());
                
                Console.WriteLine("Enter Employee Age");
                xmlWriter.WriteElementString("Age ", Console.ReadLine());

                Console.WriteLine("Enter Employee Dept");
                xmlWriter.WriteElementString("Dept ", Console.ReadLine());

                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }
}
