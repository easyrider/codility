using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace CrackingCodingInterview
{
    public abstract class Algorithm<TInput, TResult>
    {
        public const bool LoopBreak = true;
        private readonly Lazy<Stopwatch> _stopwatchLazy = new Lazy<Stopwatch>();
        private int _baseSize;
        private int _iteration;

        public string TimeComplexity
        {
            get { return string.Format("{0}/{1}", _iteration, _baseSize); }
        }

        public TimeSpan ExecutionTime
        {
            get
            {
                if (!_stopwatchLazy.IsValueCreated)
                    throw new InvalidOperationException("Execution has not been run yet");

                return _stopwatchLazy.Value.Elapsed;
            }
        }

        private Stopwatch Stopwatch
        {
            get { return _stopwatchLazy.Value; }
        }

        public TResult Execute(TInput arg)
        {
            SetBaseSize(OnInitComplexity(arg));

            if (Stopwatch.IsRunning)
                throw new InvalidOperationException("Execution is already running. The class is not thread-safe");

            Stopwatch.Reset();
            Stopwatch.Start();

            try
            {
                return OnExecute(arg);
            }
            finally
            {
                Stopwatch.Stop();
            }
        }

        protected abstract int OnInitComplexity(TInput arg);

        protected void For(int start, int end, Action<ForContext> body)
        {
            var context = new ForContext();
            for (context.Seed = start; context.Seed < end; context.Seed++)
            {
                IncrementIteration();
                body(context);

                if (context.Break)
                    break;
            }
        }

        protected void While(Func<bool> condition, Action body)
        {
            while (condition())
            {
                IncrementIteration();
                body();
            }
        }

        protected void IncrementIteration()
        {
            _iteration++;
        }

        private void SetBaseSize(int baseSize)
        {
            _baseSize = baseSize;
        }

        protected abstract TResult OnExecute(TInput arg);

        #region Nested type: ForContext

        protected class ForContext
        {
            public int Seed { get; set; }
            public bool Break { get; set; }
        }

        #endregion
    }
}