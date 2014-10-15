using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else
            {
                var matches = Regex.Matches(numbers, @"^\/\/.\n");
                string CustomDelimiter = "";
                if(matches.Count > 0)
                {
                    CustomDelimiter = Regex.Replace(matches[0].Value, @"\/|\n","");
                    numbers = Regex.Replace(numbers, @"^\/\/.\n", "");
                }
                return ParseStringList(numbers,CustomDelimiter).Sum();
            }
        }

        private List<int> ParseStringList(string list, string customDelimiter)
        {
            List<char> delimiters = new List<char> { ',', '\n' };
            if (!String.IsNullOrEmpty(customDelimiter))
            {
                delimiters.AddRange(customDelimiter.ToCharArray());
            }
            string[] parts = list.Split(delimiters.ToArray<char>(),StringSplitOptions.RemoveEmptyEntries);
            List<int> toAdd = new List<int>();
            foreach (string s in parts)
            {
                toAdd.Add(int.Parse(s));
            }
            return toAdd;
        }
    }
}