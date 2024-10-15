using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class Index : Form
    {
        private int remainingTime = 0;
        private int setTime = 0;
        private bool isTimerRunning = false;
        public Index()
        {
            InitializeComponent();
        }
        private void UpdateTimer() //method to update the visual timer on the app
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingTime);
            TimerLabel.Text = time.ToString(@"hh\:mm\:ss");
        }
        private void TimerTick(object sender, EventArgs e) //method tu update the timer inside of the componene
        {
            if (remainingTime > 0) 
            {
                remainingTime--;
                UpdateTimer();
            }
            else
            {
                TimerTimer.Stop();
                MessageBox.Show("Time is up!"),
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {
                TimerTimer.Start();
                StartButton.Text = "Stop";
                StartButton.BackColor = Color.Blue;
            }
            else
            {
                TimerTimer.Stop();
                StartButton.Text = "Start";
                StartButton.BackColor = Color.Chartreuse;
            }
        }

        private void SetTimerButton_Click(object sender, EventArgs e)
        {
            IEnumerable<string> texteInputSplited = TimerSeterTextBox.Text.Split(':');
            if (int.TryParse(, out int value))
            {

            }
        }
    }
}
