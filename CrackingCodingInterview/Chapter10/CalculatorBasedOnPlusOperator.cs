using System;

namespace CrackingCodingInterview.Chapter10
{
     [Reference(
        Page = 68
        , Number = "10.4"
        , Description = "Write a method to implement *, - , / operations. You should use only the + operator"
        )]
    public class CalculatorBasedOnPlusOperator
    {
         private int Negate(int x)
         {
             int modifier = x < 0 ? 1 : -1;
             int result = 0;

             while (x != 0)
             {
                 x += modifier;
                 result += modifier;
             }

             return result;
         }

         private static bool DifferentSigns(int x, int y)
         {
             return ((x > 0 && y < 0) || (x < 0 && y > 0));
         }

         private int Abs(int x)
         {
             return x < 0 ? Negate(x) : x;
         }

         public int Minus(int x, int y)
         {
             return x + Negate(y);
         }

         public int Multiple(int x, int y)
         {
             if (x > y)
             {
                 return Multiple(y, x);
             }

             int sum = 0;

             for (int i = Abs(x); i > 0; --i)
             {
                 sum += y;
             }

             if (x < 0)
             {
                 sum = Negate(sum);
             }

             return sum;
         }

         public int Divide(int x, int y)
         {
             if (y == 0)
             {
                 throw new DivideByZeroException();
             }

             int quotient = 0;
             int divisor = Negate(Abs(y));
             int divend;
             for (divend = Abs(x); divend >= Abs(divisor); divend += divisor)
             {
                ++quotient;
             }
             if (DifferentSigns(x, y))
             {
                 quotient = Negate(quotient);
             }
             return quotient;
         }
    }
}
