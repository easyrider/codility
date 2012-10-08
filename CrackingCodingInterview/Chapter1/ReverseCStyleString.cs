using System.Linq;

namespace CrackingCodingInterview.Chapter1
{
    [Reference(
        Page = 48
        , Number = "1.2"
        , Description = "Write code to reverse a C-Style String."
        , Variant = 1
    )]
    public class ReverseCStyleString : Algorithm<CStyleString, CStyleString>
    {
        protected override CStyleString OnExecute(CStyleString arg)
        {
            var lastIndex = 0;
            While(() =>  arg[lastIndex] != CStyleString.NullCharacter, ()=>lastIndex++);
            lastIndex--;
            var firstIndex = 0;
            While(() => firstIndex < lastIndex, () =>
                                                    {
                                                        var tmp = arg[firstIndex];
                                                        arg[firstIndex] = arg[lastIndex];
                                                        arg[lastIndex] = tmp;
                                                        firstIndex++;
                                                        lastIndex--;
                                                    });

            return arg;
        }

        protected override int OnInitComplexity(CStyleString arg)
        {
            return arg.TakeWhile(@char => @char != CStyleString.NullCharacter).Count();
        }
    }

   
}
