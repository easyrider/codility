using System;

namespace CrackingCodingInterview.Chapter1
{
 
    [Reference(Page = 48, Number = "1.1", 
        Description = "Implement an algorithm to determine " +
                      "if a string has all unique characters. " +
                      "What if you can not use additional data structures?")]
    public class UniqueCharactersInString
    {
        public bool HasAllUniqueCharactersWithoutDataStructures(string @string)
        {
            if (@string == null) throw new ArgumentNullException("string");

            if (@string == string.Empty) return true;

            var length = @string.Length;

            for (var i = 0; i < (length - 1); i++)
            {
                var current = @string[i];

                for(var j = i + 1; j < length; j++)
                {
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
