using System;

namespace Exercise_Stopwatch
{
    public class Stopwatch
    {
        private bool _isTimerStarted = false;
        private bool _isTimerEnded = true;

        private DateTime _start;
        private DateTime _end;

        private TimeSpan interval;

        public void Start()
        {
            if (this._isTimerStarted)
            {
                throw new InvalidOperationException("Timer is already started");
            }
            this._start = DateTime.Now;
            this._isTimerStarted = true;
        }

        public void End()
        {
            if (this._isTimerEnded && this._isTimerStarted == false)
            {
                throw new InvalidOperationException("Timer has already ended or Timer hasn't started");
            }
            this._end = DateTime.Now;
            this._isTimerEnded = true;
            this._isTimerStarted = false;
            interval = this._end - this._start;
            Console.WriteLine($"Spanned time was: {interval.ToString()}");
        }
    }
}