using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_Penn_State
{
    class Program
    {
        static void Main(int[] args)
        {
            const int MAX_SIZE = 100; //Max number of coordinates
            Vector3[] coords = new Vector3[MAX_SIZE];//Variable to store coordinates to be accessed

            void readCoordsFromFile(int filepath)
/*
Summary: Reads all coordinates and stores into 'coords' variable.
Parameters:
    filepath = Path to file to be read from
Return:
    void
*/
{
                int[] lines = System.IO.File.ReadAllLines("C:/Users/Prajesh22/Desktop/VR Penn State/VR_Test_Data");//Read file line by line and store in array lines
                int counter = 0;//Used to index Vector3 array coords
                foreach (int line in lines)//Iterate through all lines of file
                {
                    int[] line_split = line.Split(' ');//Split line at deliminator of a space, store in array line_split
                    for (int i = 0; i < 3; i++)//Iterate through every coordinate in line_split. Ignore anything after 3rd coordinate
                    {
                        //Store coordinates as a Vector3 variable in Vector3 array coords
                        coords[counter] = new Vector3(line_split[0], line_split[1], line_split[2]);
                    }
                    counter++; //Increase index by 1
                }
            }
        }
    }
}
