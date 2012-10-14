using System.Diagnostics;

namespace CrackingCodingInterview.Test
{
    public abstract class TestBase
    {
        protected static TOutput RunTest<TInput, TOutput>(TInput input, Algorithm<TInput, TOutput> cut)
        {
            var withHashSetTest = cut.Execute(input);
            Trace.TraceInformation("Execution Time: {0}", cut.ExecutionTime);
            Trace.TraceInformation("TimeComplexity: {0}", cut.TimeComplexity);
            return withHashSetTest;
        }
    }
}