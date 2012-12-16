namespace CrackingCodingInterview.Chapter5
{
    [Reference(
        Page = 58
        , Number = "5.6"
        , Description = "Write a program to swap odd and even bits in an integer with as few instructions as" +
                        "possible")]
    public class SwapOddAndEventBits : Algorithm<uint, uint>
    {
        protected override uint OnExecute(uint arg)
        {
            const uint oddBitsMask = 0xaaaaaaaa;
            const uint evenBitsMask = 0x55555555;
            return (((arg & oddBitsMask) >> 1) | ((arg & evenBitsMask) << 1));
        }
    }
}
