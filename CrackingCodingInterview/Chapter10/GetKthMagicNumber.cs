using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter10
{

     [Reference(
       Page = 68
       , Number = "10.7"
       , Description = "Design an algorithm to find the kth number such that the only prime factors are 3, 5, and 7."
       )]
    public class GetKthMagicNumber : Algorithm<int, int>
    {
        protected override int OnExecute(int arg)
        {
            if (arg == 0)
            {
                return 0;
            }

            int value = 1;

            Queue<int> q3 = new Queue<int>(new[] { 3 });
            Queue<int> q5 = new Queue<int>(new[] { 5 });
            Queue<int> q7 = new Queue<int>(new[] { 7 });

            for (--arg; arg > 0; --arg)
            {
                value = Math.Min(q3.Peek(), Math.Min(q5.Peek(), q7.Peek()));
                
                if (value == q7.Peek())
                {
                    q7.Dequeue();
                }
                else
                {
                    if (value == q5.Peek())
                    {
                        q5.Dequeue();
                    }
                    else
                    {
                        q3.Dequeue();
                        q3.Enqueue(value * 3);
                    }

                    q5.Enqueue(value * 5);
                }

                q7.Enqueue(value * 7);
            }

            return value;
        }
    }
}
