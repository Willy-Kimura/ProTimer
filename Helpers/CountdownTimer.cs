using System;
using System.Windows.Forms;

namespace ProTimer.Helpers
{
    public class CountDownTimer : IDisposable
    {
        #region Constructors

        public CountDownTimer()
        {
            Init();
        }

        public CountDownTimer(DateTime dt)
        {
            SetTime(dt);
            Init();
        }

        public CountDownTimer(int min, int sec)
        {
            SetTime(min, sec);
            Init();
        }

        #endregion

        #region Fields

        public Action TimeChanged;
        public Action CountDownFinished;

        private Timer timer = new Timer();
        private DateTime _maxTime = new DateTime(1, 1, 1, 0, 30, 0);
        private DateTime _minTime = new DateTime(1, 1, 1, 0, 0, 0);

        #endregion

        #region Properties

        #region Public

        public bool IsRunning => timer.Enabled;

        public int StepMs
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        public DateTime TimeLeft { get; private set; }

        public string TimeLeftStr => TimeLeft.ToString("mm:ss");

        public string TimeLeftMsStr => TimeLeft.ToString("mm:ss:ff");

        #endregion

        #region Private

        private long TimeLeftMs => TimeLeft.Ticks / TimeSpan.TicksPerMillisecond;

        #endregion

        #endregion

        #region Methods

        #region Public

        public void SetTime(DateTime dt)
        {
            TimeLeft = _maxTime = dt;
            TimeChanged?.Invoke();
        }

        public void SetTime(int min, int sec = 0) => SetTime(new DateTime(1, 1, 1, 0, min, sec));

        public void Start() => timer.Start();

        public void Pause() => timer.Stop();

        public void Stop()
        {
            Pause();
            Reset();
        }

        public void Reset()
        {
            TimeLeft = _maxTime;
        }

        public void Restart()
        {
            Reset();
            Start();
        }

        public void Dispose() => timer.Dispose();

        #endregion

        #region Private

        private void Init()
        {
            TimeLeft = _maxTime;

            StepMs = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (TimeLeftMs > timer.Interval)
            {
                TimeLeft = TimeLeft.AddMilliseconds(-timer.Interval);
                TimeChanged?.Invoke();
            }
            else
            {
                Stop();
                TimeLeft = _minTime;

                TimeChanged?.Invoke();
                CountDownFinished?.Invoke();
            }
        }

        #endregion

        #endregion
    }
}