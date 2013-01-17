using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingCodingInterview.Chapter8
{
    [Reference(
        Page = 64
        , Number = "8.4"
        , Description = "Write a method to compute all permutations of a string.")]
    public class GetPermutationsOfString : Algorithm<string, List<string>>
    {
        protected override List<string> OnExecute(string arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            List<string> permutations = new List<string>();

            if (arg.Length == 0)
            {
                permutations.Add(string.Empty);
                return permutations;
            }

            string firstChar = arg.Substring(0, 1);
            string reminder = arg.Substring(1);

            List<string> words = OnExecute(reminder);

            foreach (string word in words)
            {
                for (int i = 0; i <= word.Length; i++)
                {
                    permutations.Add(word.Insert(i,firstChar));
                }
            }

            return permutations;
        }
    }
}
