using System.Diagnostics;

namespace CrackingCodingInterview.Test
{
    public abstract class TestBase
    {
        protected static TOutput RunTest<TInput, TOutput>(TInput @string, Algorithm<TInput, TOutput> cut)
        {
            var withHashSetTest = cut.Execute(@string);
            Trace.TraceInformation("Execution Time: {0}", cut.ExecutionTime);
            Trace.TraceInformation("TimeComplexity: {0}", cut.TimeComplexity);
            return withHashSetTest;
        }
    }
}