using System;
using System.Collections.Generic;

namespace CSharpAdvent
{
    class Day_1
    {
        public int MultiplySumOfTwoNumbers(List<string> Lines)
        {
            //Day-1-Part-1: Find the two entries that sum to 2020 and then multiply those two numbers together.
            int current = 0;
            int sum = 2020;

            for(int i = 0; i < Lines.Count; i++)
            {
                current = int.Parse(Lines[i]);
                for(int j = 0; j < Lines.Count; j++){
                    int x = int.Parse(Lines[j]);
                    if((current + x) == sum)
                    {
                        System.Console.WriteLine("Current: {0} and x: {1} and sum: {2}", current, x, current + x);
                        return (current * x);
                    }
                }
            } 
            return -1;
        }

        //Day-1-Part-2 Find the three entries that sum to 2020 and then multiply those two numbers together.
        public int MultiplySumOfThreeNumbersOf2020(List<string> Lines)
        {
            int current = 0;
            int sum = 2020;

            for(int i = 0; i < Lines.Count; i++)
            {
                current = int.Parse(Lines[i]);
                for(int j = 0; j < Lines.Count; j++)
                {
                    int x = int.Parse(Lines[j]);
                    for(var k = 0; k < Lines.Count; k++)
                    {
                        int y = int.Parse(Lines[k]);
                        if((current + x + y) == sum)
                        {
                            System.Console.WriteLine("Current: {0} and x: {1} and y: {2} and sum: {3}", current, x, y, current + x);
                            return (current * x * y);
                        }
                    }
                }
            } 
            return -1;   
        }
    }
}