using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.3"
        , Description = "Design an algorithm and write ode to remove the duplicate " +
                        "characters in a string without using any additional buffer"
        , Variant = 1
    )]
    public class RemoveDuplicateCharacters : CStyleStringAlgorithmBase
    {
        protected override CStyleString OnExecute(CStyleString arg)
        {
            if (arg == null)
                throw new ArgumentNullException();
            
            if (arg[0] == CStyleString.NullCharacter || arg[1] == CStyleString.NullCharacter)
                return arg;

            var tail = 1;
            int i = 1;


            while(arg[i] != CStyleString.NullCharacter)
            {
                IncrementIteration();
                int j;
                for (j = 0; j < tail; ++j)
                {
                    IncrementIteration();
                    if (arg[i] == arg[j]) break;
                }

                if (j == tail)
                {
                    arg[tail] = arg[i];
                    tail++;
                }
                    i++;
            }

            arg[tail] = CStyleString.NullCharacter; 

            return arg;
        }
    }
}
