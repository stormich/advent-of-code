using System;
using System.Collections.Generic;

namespace CSharpAdvent
{
    public class Day_3
    {
        public int EncounteredTreesNum(List<string> lines)
        {
            int totalCountTrees = 0;
            char tree = '#';
            int right = 2;

            for(int i = 1; i < lines.Count; i++)
            {
                string line = lines[i];
                if(right < line.Length)
                {
                    /*System.Console.WriteLine();
                    System.Console.WriteLine("--");
                    System.Console.WriteLine(line);
                    System.Console.WriteLine(line[i]);
                    System.Console.WriteLine(right);
                    System.Console.WriteLine(line[right]);
                    System.Console.WriteLine("--");
                    System.Console.WriteLine();*/

                    if(line[right] == tree)
                    {
                        totalCountTrees++;
                    }
                }else{
                    right = right - line.Length;
                }
                right += 2; 
            }

            return totalCountTrees;            
        }
    }
}