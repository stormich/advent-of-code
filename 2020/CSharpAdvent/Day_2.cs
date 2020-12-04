using System;
using System.Collections.Generic;

namespace CSharpAdvent
{
    class Day_2
    {
        // Day-2-Part-1
        // The password policy indicates the lowest and highest number of times a given letter must appear for the password to be valid. 
        // For example, 1-3 a means that the password must contain a at least 1 time and at most 3 times.
        // How many passwords are valid according to their policies?
        public int ValidPasswordsPartOne(List<string> lines)
        {
            int totalCount = 0;
            for(int i = 0; i < lines.Count; i++)
            {
                char[] delimiterChars = { ':', '-', ' '};
                string[] splitArr = lines[i].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                int min = int.Parse(splitArr[0]);
                int max = int.Parse(splitArr[1]);
                char x = char.Parse(splitArr[2]);
                string word = splitArr[3];
                
                int count = 0;

                for(int j = 0; j < word.Length; j++)
                {
                    if(word[j] == x)
                    {
                        count++;
                    }
                }

                if(count >= min && count <= max)
                {
                    totalCount++;
                }
            }
            return totalCount;
        }

        // Each policy actually describes two positions in the password, where 1 means the first character, 2 means the second character, and so on. 
        // (Be careful; Toboggan Corporate Policies have no concept of "index zero"!) Exactly one of these positions must contain the given letter. 
        // Other occurrences of the letter are irrelevant for the purposes of policy enforcement.//
        // 1-3 a: abcde is valid: position 1 contains a and position 3 does not.
        // 1-3 b: cdefg is invalid: neither position 1 nor position 3 contains b.
        // 2-9 c: ccccccccc is invalid: both position 2 and position 9 contain c.
        public int ValidPasswordsPartTwo(List<string> lines)
        {
            int totalCount = 0;
            for(int i = 0; i < lines.Count; i++)
            {
                char[] delimiterChars = { ':', '-', ' '};
                string[] splitArr = lines[i].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                int pos1 = int.Parse(splitArr[0]);
                int pos2 = int.Parse(splitArr[1]);
                char x = char.Parse(splitArr[2]);
                string word = splitArr[3];
                
                bool match = false;
                if(pos1 <= word.Length && word[pos1-1] == x)
                {
                    totalCount++;
                    match = true;
                }
                if(pos2 <= word.Length && word[pos2-1] == x)
                {
                    if(!match)
                    {
                        totalCount++;
                    }else
                    {
                        totalCount--;
                    }
                }
            }
            return totalCount;
        }
    }
}