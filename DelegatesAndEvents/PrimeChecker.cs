using System;

namespace DelegatesAndEvents
{
    public class PrimeChecker
    {
        public bool IsPrime(int n)
        {
            int i = 2;
            int percentCounter = 1;
            int percentModulo = (int)(Math.Sqrt(n) * 0.1);

            OnPrimeCheckingStarted();

            if (n < 2)
            {
                OnPrimeCheckFinished();
                return false;
            }

            for (; i * i < n; i++)
            {
                if (percentModulo > 1)
                {
                    if (i % percentModulo == 0)
                    {
                        OnPrimeCheckedProgressUpdated(10 * percentCounter);
                        percentCounter++;
                    }
                }

                if (n % i != 0) continue;
                OnPrimeCheckFinished();
                return false;
            }

            OnPrimeCheckFinished();
            return true;

        }

        public delegate void PrimeCheckingStartedEventHandler(object sender, EventArgs e);
        public delegate void PrimeCheckedProgressUpdatedEventHandler(object sender, ProgressEventArgs e);
        public delegate void PrimeCheckedFinishedEventHandler(object sender, EventArgs e);

        public event PrimeCheckingStartedEventHandler PrimeCheckingStarted;
        public event PrimeCheckedProgressUpdatedEventHandler PrimeCheckedProgressUpdated;
        public event PrimeCheckedFinishedEventHandler PrimeCheckedFinished;

        protected virtual void OnPrimeCheckingStarted()
        {
            PrimeCheckingStarted?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnPrimeCheckedProgressUpdated(int progress)
        {
            PrimeCheckedProgressUpdated?.Invoke(this, new ProgressEventArgs(progress));
        }

        protected virtual void OnPrimeCheckFinished()
        {
            PrimeCheckedFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}
