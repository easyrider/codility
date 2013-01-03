using System;

namespace CrackingCodingInterview.Chapter8
{
    [Reference(
        Page = 64
        , Number = "8.1"
        , Description = "Write a method to generate the nth Fibonacci number"
        , Variant = 1)]
    public class GetFibonacciNumberRecursive : Algorithm<int, int>
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

            if (arg == 1)
            {
                return 1;
            }
            
            return OnExecute(arg - 1) + OnExecute(arg - 2);
        }
    }
}
