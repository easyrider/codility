using System;
using System.Text;

namespace CrackingCodingInterview.Chapter5
{
    [Reference(
        Page = 58
        , Number = "5.2"
        , Description = "Given a (decimal - e.g. 3.72) number that is passed in as a string, print the binary " +
                        "representation. If the number can not be represented accurately in binary, print \"Error\""
        , Incorrect = true)]
    public class GetDecimalNumberBinaryRepresentation : Algorithm<string, string>
    {
        protected override string OnExecute(string arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            const char dot = '.';
            int indexOfDot = arg.IndexOf(dot);

            int intPart = int.Parse(arg.Substring(0, indexOfDot));
            double decPart = double.Parse(arg.Substring(indexOfDot));

            StringBuilder intString = new StringBuilder();

            while (intPart > 0)
            {
                int r = intPart % 2;
                intPart >>= 1;
                intString.Insert(0, r);
            }

            StringBuilder decString = new StringBuilder();

            while (decPart > 0)
            {
                if (decString.Length > 32)
                {
                    return "ERROR";
                }

                if (/*Math.Abs(decPart - 1f) < double.Epsilon*/decPart >= 1)
                {
                    decString.Append((int)decPart);
                    break;
                }

                double r = decPart*2;

                if (r >= 1)
                {
                    decString.Append(1);
                    decPart = r - 1;
                }
                else
                {
                    decString.Append(0);
                    decPart = r;
                }
            }

            return string.Concat(intString, dot, decString);

        }
    }
}
