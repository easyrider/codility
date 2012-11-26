using System;

namespace CrackingCodingInterview.Chapter1
{
     [Reference(
        Page = 48
        , Number = "1.5"
        , Description = "Replace spaces in a string with '%20'"
    )]
    public class ReplaceSpacesWithHtmlCode : Algorithm<Tuple<CStyleString, int>, CStyleString>
     {
         protected override int? OnInitComplexity(Tuple<CStyleString, int> arg)
         {
             return arg.Item2;
         }

         protected override CStyleString OnExecute(Tuple<CStyleString, int> arg)
         {
             if (arg == null) throw new ArgumentNullException("arg");
             var @string = arg.Item1;
             if (@string == null) throw new ArgumentException();
             var length = arg.Item2;
             if (length == 0) return @string;

             var spaceCount = 0;

             const char space = ' ';
             for(var i = 0; i < length; i++)
             {
                 if (@string[i] == space) 
                     spaceCount++;
             }

             var newLength = length + spaceCount*2;
             @string[newLength] = CStyleString.NullCharacter;

             for(var i = length - 1; i >= 0; i--)
             {
                 if (@string[i] == space)
                 {
                     @string[--newLength] = '0';
                     @string[--newLength] = '2';
                     @string[--newLength] = '%';
                 } 
                 else
                 {
                     @string[--newLength] = @string[i];
                 }
             }

             return @string;

         }
     }
}
