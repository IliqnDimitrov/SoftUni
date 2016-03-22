namespace _2.Reformat_Your_Own_Code
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student_reformatted
    {
        public const string FileName = "example.bin";

        /// <summary>
        /// this is Main method
        /// </summary>
        public static void Main()
        {
            FileStream fileStream = new FileStream(FileName, FileMode.CreateNew);

            // Create the writer for data.
            BinaryWriter writeData = new BinaryWriter(fileStream);

            // Write data to Test.data.
            for (int i = 0; i < 11; i++)
            {
                writeData.Write((int)i);
            }

            writeData.Close();

            fileStream.Close();

            // Create the reader for data.
            fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryReader readData = new BinaryReader(fileStream); // Read data from  Test.data.
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(readData.ReadInt32());
            }

            readData.Close();
            fileStream.Close();
        }
    }
}
