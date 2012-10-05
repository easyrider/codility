using System;

namespace CrackingCodingInterview.Chapter1
{
 
    [Reference(Page = 48, Number = "1.1", 
        Description = "Implement an algorithm to determine " +
                      "if a string has all unique characters. " +
                      "What if you can not use additional data structures?")]
    public class HasStringUniqueCharactersWoDataStructures : Algorithm<string, bool>
    {
        public override bool Execute(string @string)
        {
            if (@string == null) throw new ArgumentNullException("string");

            if (@string == string.Empty) return true;

            var length = @string.Length;

            SetComplexityBase(length);

            for (var i = 0; i < (length - 1); i++)
            {
                IncrementComplexity();
                var current = @string[i];

                for(var j = i + 1; j < length; j++)
                {   
                    IncrementComplexity();
                    if (current == @string[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

}
