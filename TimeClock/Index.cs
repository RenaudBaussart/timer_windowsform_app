using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

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
            TimerProgessBar.Minimum = 0;
            TimerProgessBar.Maximum = setTime;
            TimerProgessBar.Value = remainingTime;
        }
        private void TimerTick(object sender, EventArgs e) //method to update the timer inside of the componene
        {
            if (remainingTime > 0) 
            {
                remainingTime--;
                UpdateTimer();
            }
            else
            {
                StartButton_Click(sender, e);
                SystemSounds.Beep.Play();
                MessageBox.Show("Time is up!");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)// method to do a flip flop button start/stop and start and stop the timer
        {
            if (!isTimerRunning)
            {
                TimerTimer.Start();
                isTimerRunning = true;
                StartButton.Text = "Stop";
                StartButton.BackColor = Color.Blue;
            }
            else
            {
                TimerTimer.Stop();
                isTimerRunning = false;
                StartButton.Text = "Start";
                StartButton.BackColor = Color.Chartreuse;
            }
        }

        private void SetTimerButton_Click(object sender, EventArgs e)//method to set the timer and check if the entry is valid
        {
            string[] setTimmerSplitedFromTextBox = TimerSeterTextBox.Text.Split(':');
            

            if (setTimmerSplitedFromTextBox.Length != 3)
            {
                MessageBox.Show("Please enter in the valid format (HH:MM:SS)");
                return;
            }
            else
            {
                //check if the entry are number and can be parsed and store the return in a bool local variable
                bool hoursParsed , minutesParsed , secondsParsed ;
                hoursParsed = int.TryParse(setTimmerSplitedFromTextBox[0], out int hours);
                minutesParsed = int.TryParse(setTimmerSplitedFromTextBox[1], out int minutes);
                secondsParsed = int.TryParse(setTimmerSplitedFromTextBox[2], out int seconds);

                if (hours > 100 || minutes > 60 || seconds > 60) //check if the number we tried to set does not exceed the format
                {
                    MessageBox.Show("Please enter in the valid format (HH:MM:SS)");
                    return;
                }

                if (hoursParsed && minutesParsed && secondsParsed)//check if all the local variable for the parsing are true
                {
                    setTime = hours * 3600 + minutes * 60 + seconds;
                    remainingTime = hours * 3600 + minutes * 60 + seconds;
                    UpdateTimer();

                    if(isTimerRunning)
                    {
                        StartButton_Click(sender, e);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter in the valid format (HH:MM:SS)");
                    return;
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) //method to reset the timer to the start of it
        {
            if (isTimerRunning)
            {
                StartButton_Click(sender, e);
            }
            remainingTime = setTime;
            UpdateTimer() ;
            
        }

        private void ClearButton_Click(object sender, EventArgs e)//method to clear the timer and the set textbox part of the app
        {
            if (isTimerRunning)
            {
                StartButton_Click(sender, e);
            }
            remainingTime = 0;
            setTime = 0;
            UpdateTimer () ;
            TimerSeterTextBox.Text = "00:00:00";
        }
    }
}
