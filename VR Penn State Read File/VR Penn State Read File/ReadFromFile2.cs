using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VR_Penn_State_Read_File
{
    public class ReadFromFile2
    {
        static void Main()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Prajesh22\Desktop\VR Penn State\VR_Test_Data");
            while ((line = file.ReadLine()) != null)
            {
               System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
