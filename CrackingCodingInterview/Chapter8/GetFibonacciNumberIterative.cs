using System;

namespace CrackingCodingInterview.Chapter8
{
    [Reference(
        Page = 64
        , Number = "8.1"
        , Description = "Write a method to generate the nth Fibonacci number"
        , Variant = 2)]
    public class GetFibonacciNumberIterative : Algorithm<int, int>
    {
        protected override int OnExecute(int arg)
        {
            if (arg < 0)
            {
                throw new ArgumentException("Can not be less than zero");
            }

            if (arg == 0)
            {
                return 0;
            }

            int a = 1, b = 1;

            for (int i = 2; i < arg; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;

        }
    }
}