namespace CrackingCodingInterview
{
    public abstract class Algorithm<TInput, TResult>
    {
        private int _base;
        private int _complexityIncrement;

        public string Complexity
        {
            get { return string.Format("{0}/{1}", _complexityIncrement, _base); }
        }

        protected void SetComplexityBase(int @base)
        {
            _base = @base;
        }

        protected void IncrementComplexity()
        {
            _complexityIncrement++;
        }

        public abstract TResult Execute(TInput arg);
    }
}