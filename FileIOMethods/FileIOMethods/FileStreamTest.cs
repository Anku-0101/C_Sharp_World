using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOMethods
{
    class FileStreamTest
    {
        public static void CreateAndReadFile()
        {
            FileStream fileStream = null;

            fileStream = new FileStream("C:/Users/anku/Documents/MyGeneratedFiles/Text.txt", FileMode.Create);

            for (char ch = 'A'; ch <= 'M'; ch++)
            {
                fileStream.WriteByte((byte)ch);
            }
            fileStream.Close();

            FileStream reading = new FileStream("C:/Users/anku/Documents/MyGeneratedFiles/Text.txt", FileMode.Open);

            int i = reading.ReadByte();
            while (i != -1)
            {
                Console.WriteLine((char)i);
                i = reading.ReadByte();
            }

        }

    }
}
