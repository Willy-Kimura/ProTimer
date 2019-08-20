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
            timer.SetTime(30, 10);

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

            if ((e.Modifiers == Keys.Alt && e.KeyCode == Keys.Space) ||
                e.KeyCode == Keys.C)
            {
                StopTimer();
            }

            if (e.KeyCode == Keys.V)
            {
                
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        #endregion
    }
}
