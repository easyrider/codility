using System;

namespace CrackingCodingInterview.Chapter5
{
    [Reference(
        Page = 58
        , Number = "5.5"
        , Description = "Write a function to determine the number of bits required to convert integer A to integer B")]
    public class GetNumberOfBitsRequiredToConvert : Algorithm<Tuple<int, int>, int>
    {
        protected override int OnExecute(Tuple<int, int> arg)
        {
            if (arg == null)
            {
                throw new ArgumentNullException("arg");
            }

            int a = arg.Item1;
            int b = arg.Item2;
            int count = 0;

            for (int i = a ^ b; i != 0x00; i >>= 1)
            {
                count += i & 0x01;
            }

            return count;
        }
    }
}