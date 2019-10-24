using System;
using System.Drawing;
using System.Windows.Forms;

using ProTimer.Helpers;

namespace ProTimer.Views
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields

        private bool _alignedText;

        #endregion

        #region Properties

        public bool IsPlaying { get; set; }
        public string Countdown { get; set; }
        public CountDownTimer timer = new CountDownTimer();

        #endregion

        #region Methods

        public void InitializeTimerButtons()
        {
            btnPlayPause.ImageMargin = new Padding(3, 0, 0, 0);
            btnPlayPause.Image = Properties.Resources.Play_104px_4;
        }

        private void PrepareTimer()
        {
            // Set to 30 mins.
            SetCountdown(30, 0);

            // Update label text.
            timer.TimeChanged += delegate
            {
                lblCountdown.Text = timer.TimeLeftMsStr;

                if (!_alignedText)
                {
                    lblCountdown.Left = (Width - lblCountdown.Width) / 2;
                    _alignedText = true;
                }
            };

            // Show messageBox on timer = 00:00.000.
            timer.CountDownFinished += delegate
            {
                PauseTimer();
            };

            // Timer step. By default is 1 second.
            timer.StepMs = 100; // 33;

            InitializeTimerButtons();
        }

        private void SetCountdown(int min = 30, int sec = 00)
        {
            timer.SetTime(min, sec);

            Countdown = $"{min}:{sec}";

            lblCountdownSet.Text = 
                $"{(min.ToString().Length == 1 ? "0" : "")}{min}<span style=\"color: silver;\">:" +
                $"{(sec.ToString().Length == 1 ? "0" : "")}{sec}</span><span style=\"color: darkgray;\">:00</span>";

            lblCountdownSet.Left = (Width - lblCountdownSet.Width) / 2;
        }

        public void PlayTimer()
        {
            timer.Start();
            IsPlaying = true;

            btnPlayPause.ImageMargin = new Padding(0, 0, 0, 0);
            btnPlayPause.Image = Properties.Resources.Pause_104px;
            lblCountdown.Left = (Width - lblCountdown.Width) / 2;
        }

        public void StopTimer()
        {
            timer.Stop();
            IsPlaying = false;

            btnPlayPause.ImageMargin = new Padding(3, 0, 0, 0);
            btnPlayPause.Image = Properties.Resources.Play_104px_4;

            lblCountdown.Text = "00:00:00";
            lblCountdown.Left = (Width - lblCountdown.Width) / 2;

            _alignedText = false;
        }

        public void PauseTimer()
        {
            timer.Pause();
            IsPlaying = false;

            btnPlayPause.ImageMargin = new Padding(3, 0, 0, 0);
            btnPlayPause.Image = Properties.Resources.Play_104px_4;
            lblCountdown.Left = (Width - lblCountdown.Width) / 2;

            _alignedText = false;
        }

        private void PlayPause()
        {
            if (!IsPlaying)
                PlayTimer();
            else
                PauseTimer();
        }

        private void EditCountdown()
        {

        }

        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrepareTimer();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ||
                e.KeyCode == Keys.Space)
            {
                PlayPause();
            }

            if (e.KeyCode == Keys.X)
            {
                StopTimer();
            }

            if (e.KeyCode == Keys.C)
            {
                EditCountdown();
            }
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            EditCountdown();
        }

        private void BtnReset_MouseHover(object sender, EventArgs e)
        {
            cmpToolTip.SetToolTip(btnReset, $"Set new countdown (current: {Countdown})");
        }

        #endregion
    }
}