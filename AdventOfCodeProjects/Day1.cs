using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCodeProjects
{
    public class Day1
    {
        public static void Day1Function()
        {
            string filePath = @"C:\users\andrew.evans\Documents\input.txt";
            string[] lines = File.ReadAllLines(filePath);
            int total = 0;

            foreach (string line in lines)
            {
                SortedDictionary<int, int> indexes = new SortedDictionary<int, int>();

                string[] patterns =
                {
                    "one",
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9"
                };

                foreach (string pattern in patterns)
                {
                    MatchCollection hits = Regex.Matches(line, pattern);

                    foreach (Match match in hits)
                    {
                        int digit;

                        switch (match.Value)
                        {
                            case "one": digit = 1; break;
                            case "two": digit = 2; break;
                            case "three": digit = 3; break;
                            case "four": digit = 4; break;
                            case "five": digit = 5; break;
                            case "six": digit = 6; break;
                            case "seven": digit = 7; break;
                            case "eight": digit = 8; break;
                            case "nine": digit = 9; break;
                            default: digit = int.Parse(match.Value); break;
                        }

                        indexes[match.Index] = digit;
                    }
                }

                int value = (indexes.Values.First() * 10) + indexes.Values.Last();
                total += value;
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }   
        
    }
}
