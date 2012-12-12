using System;

namespace CrackingCodingInterview.Chapter5
{
     [Reference(
        Page = 58
        , Number = "5.3"
        , Description = "Given an integer, print the next smallest and next largest number that have the same" +
                        "number of 1 bits in their binary representation.")]
    public class GetNextSmallerAndBiggerNumsWithSameAmountOfBits : Algorithm<uint, Tuple<uint, uint>>
    {
        protected override Tuple<uint, uint> OnExecute(uint arg)
        {
            return Tuple.Create(GetSmaller(arg), GetBigger(arg));
        }

        private static uint GetBigger(uint u)
        {
            return GetNext(u, true);
        }

        private static uint GetNext(uint arg, bool bigger)
        {
            if (arg == 0)
            {
              return 0;
            }

            int index = 0;
            int count = 0;

            while ((!GetBit(arg, index) && bigger) || (GetBit(arg, index) && !bigger))
            {
                index++;
            }

            while ((GetBit(arg, index) && bigger) || (!GetBit(arg, index) && !bigger))
            {
                index++;
                count++;
            }

            arg = SetBit(arg, index, bigger);
            index--;
            arg = SetBit(arg, index, !bigger);
            count--;

            for (int i = index - 1; i >= count; i--)
            {
                arg = SetBit(arg, i, !bigger);
            }

            for (int i = count - 1; i >= 0; i--)
            {
                arg = SetBit(arg, i, bigger);
            }

            return arg;
        }

        private static uint GetSmaller(uint arg)
        {
            return GetNext(arg, false);
        }

        private static bool GetBit(uint u, int index)
        {
            return ((u & (1 << index)) > 0);
        }

        private static uint SetBit(uint u, int index, bool bit)
        {
            if (bit)
            {
                return u | (uint) (1 << index);
            }
            
            uint mask = (uint)~(1 << index);
            return u & mask;
        }
    }
}
