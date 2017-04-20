using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VR_Penn_State_Read_File
{
    public class ReadFromFile
    {
        static void Main()
        {
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Prajesh22\Desktop\VR Penn State\VR_Test_Data.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}