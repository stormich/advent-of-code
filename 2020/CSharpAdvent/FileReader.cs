using System;
using System.Collections.Generic;

namespace CSharpAdvent
{
    class FileReader
    {
        public List<string> getLines(string filename)
        {
            List<string> Lines = new List<string>();

            string line;  

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\matic\Documents\GitHub\advent-of-code\2020\" + filename);  
            while((line = file.ReadLine()) != null)  
            {  
                Lines.Add(line);
            }  
            file.Close();

            return Lines;
        }
    }
}