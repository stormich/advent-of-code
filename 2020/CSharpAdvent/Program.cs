using System;
using System.Collections.Generic;

namespace CSharpAdvent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader oFileReader = new FileReader();

            System.Console.WriteLine();
            // Day-1 - Expense report
            Day_1 oDayOne = new Day_1();
            System.Console.WriteLine("----- DAY ONE -----");
            // Get input from file and add it to list
            List<string> linesPartOne = oFileReader.getLines("day-1-input.txt");

            //Day-1-Part 1: Find the two entries that sum to 2020 and then multiply those two numbers together.
            int resultPartOne = oDayOne.MultiplySumOfTwoNumbers(linesPartOne);
            System.Console.WriteLine("Result part1: " + resultPartOne);
            System.Console.WriteLine();
            //Day-1-Part 3: Find the three entries that sum to 2020 and then multiply those two numbers together.
            int resultPartTwo = oDayOne.MultiplySumOfThreeNumbersOf2020(linesPartOne);
            System.Console.WriteLine("Result part1: " + resultPartTwo);

            // ------------------------------------------------------------------------------------------------------------------------
            System.Console.WriteLine();
            // Day-2: Password Philosophy
            Day_2 oDayTwo = new Day_2();
            System.Console.WriteLine("----- DAY TWO -----");
            // Each line gives the password policy and then the password. 
            // Get input from file and add it to list
            List<string> linesPartTwo = oFileReader.getLines("day-2-input.txt");

            // Day-2-Part-1
            // The password policy indicates the lowest and highest number of times a given letter must appear for the password to be valid. 
            // For example, 1-3 'a' means that the password must contain 'a' at least 1 time and at most 3 times.
            // How many passwords are valid according to their policies?
            int resultDayTwoPartOne = oDayTwo.ValidPasswordsPartOne(linesPartTwo);
            System.Console.WriteLine("Valid passwords for part1: " + resultDayTwoPartOne);

            // Day-2-Part-2
            // Each policy actually describes two positions in the password, where 1 means the first character, 2 means the second character, and so on. 
            // (Be careful; Toboggan Corporate Policies have no concept of "index zero"!) Exactly one of these positions must contain the given letter. 
            // Other occurrences of the letter are irrelevant for the purposes of policy enforcement.//
            // 1-3 a: abcde is valid: position 1 contains a and position 3 does not.
            // 1-3 b: cdefg is invalid: neither position 1 nor position 3 contains b.
            // 2-9 c: ccccccccc is invalid: both position 2 and position 9 contain c.
            int resultDayTwoPartTwo = oDayTwo.ValidPasswordsPartTwo(linesPartTwo);
            System.Console.WriteLine("Valid passwords for part2: " + resultDayTwoPartTwo);
        }
    }
}
