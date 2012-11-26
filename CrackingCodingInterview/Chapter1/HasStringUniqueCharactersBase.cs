namespace CrackingCodingInterview.Chapter1
{
    public abstract class HasStringUniqueCharactersBase : Algorithm<string, bool>
    {
        protected override int? OnInitComplexity(string arg)
        {
            return arg.Length;
        }
    }
}