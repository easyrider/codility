using System.Linq;

namespace CrackingCodingInterview
{
    public abstract class CStyleStringAlgorithmBase : Algorithm<CStyleString, CStyleString>
    {
        protected override int? OnInitComplexity(CStyleString arg)
        {
            return arg.TakeWhile(@char => @char != CStyleString.NullCharacter).Count();
        }
    }
}