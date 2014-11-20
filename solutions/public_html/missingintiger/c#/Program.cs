using System;
using System.Collections.Generic;
using System.Linq;

//https://codility.com/demo/results/demoEE3FC4-SV6/


namespace missingintiger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };
        }

        public static int Solution(int[] A)
        {
            Dictionary<int, int> B = new Dictionary<int, int>();
            int result = -1;
    
            if (A.Length == 1) {
                return A[0] <= 0 ? 1 : A[0] + 1;
            }
    
            for (var i = 0; i <= A.Length-1; i++) {
                if (!B.ContainsKey(A[i]))
                {
                    B[A[i]] = A[i];
                }
            }
    
            if (B.Count == 0) {
                return 1;
            }
    
            for (var j = 1; j <= B.Count; j++) {
                if (!B.ContainsKey(j))
                {
                    result =  j;
                    break;
                }
            }

            return result;
        }
    }
}