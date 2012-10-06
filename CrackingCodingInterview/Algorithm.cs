using System;
using System.Diagnostics;

namespace CrackingCodingInterview
{
    public abstract class Algorithm<TInput, TResult>
    {
        public  TResult Execute(TInput arg)
        {
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

        public TimeSpan ExecutionTime
        {
            get
            {
                if (!_stopwatchLazy.IsValueCreated)
                    throw new InvalidOperationException("Execution has not been run yet");

                return _stopwatchLazy.Value.Elapsed;
            }
        }

        protected abstract TResult OnExecute(TInput arg);
    
        private Stopwatch Stopwatch
        {
            get { return _stopwatchLazy.Value; }
        }

        private readonly Lazy<Stopwatch> _stopwatchLazy = new Lazy<Stopwatch>(); 
    }
}