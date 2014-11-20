using System;
using System.Collections.Generic;
using System.Linq;

//https://codility.com/demo/results/demoXDG8XG-SF2/

namespace TapeEquilibrium
{
    class Program
    {
        static int Solution(int[] A)
        {
            var head = A[0];
            var tail = 0;
            var ans = 10000;

            for (var i = 1; i <= A.Length - 1; i++)
            {
                tail += A[i];
            }

            for (var j = 1; j <= A.Length - 1; j++)
            {
                if (A.Length > 2) head += A[j];
                if (A.Length > 2) tail -= A[j];

                if (Math.Abs(head - tail) < ans)
                {
                    ans = Math.Abs(head - tail);
                }
            }
            return ans;
        }
    }
}
