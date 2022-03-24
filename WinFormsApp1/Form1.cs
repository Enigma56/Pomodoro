using System;
using System.Windows.Forms;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form //Partial just means it is one part of the whole class
    {

        private Array flowTimerOptions = new[] { 5, 10, 25, 45, 60};
        private Array breakTimerOptions = new[] { 1, 5, 10 };

        private object selectedBreakTimer;
        private int flowTimerDuration;

        private int totalSeconds;
        public Form1()
        {
            InitializeComponent();
        }
        
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timerEnd.Enabled = false;

            foreach (var item in flowTimerOptions)
            {
                minuteOptions.Items.Add(item);
            }

            foreach (var item in breakTimerOptions)
            {
                breakOptions.Items.Add(item);
            }

        }

        private void timerStart_Click(object sender, EventArgs e)
        {
            object totalMinutes = minuteOptions.SelectedItem;
            
            if (totalMinutes == null && selectedBreakTimer == null) {
                MessageBox.Show("You must select a flow and break duration!");
                return;
            }

            timerStart.Enabled = false;
            timerEnd.Enabled = true;

            totalSeconds = (int) totalMinutes * 60; //Move into mainTimer_Tick
            flowTimerDuration = totalSeconds;
            mainTimer.Enabled = true;
        }

        private void timerEnd_Click(object sender, EventArgs e)
        {
            timerStart.Enabled = true;
            timerEnd.Enabled = false;

            mainTimer.Stop();
        }

        private void mainTimer_Tick(object sender, EventArgs e) //activates at the end of the allotted seconds
        {
            //everything is in milliseconds
            if(totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = (int) (totalSeconds / 3600.0 % 1 * 60);
                int seconds = totalSeconds - (minutes * 60);
              
                Debug.WriteLine(totalSeconds);
                timerClock.Text = $"{minutes.ToString():00}:" + 
                                  $"{seconds.ToString():00}";
            }
            else
            {
                mainTimer.Stop();
                MessageBox.Show("Flow Over! Break Begins.");
                breakTimer.Start(); //Starts the break timer and adjusts totalSeconds accordingly
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {
            selectedBreakTimer = breakOptions.SelectedItem;

            int totalSeconds = (int)selectedBreakTimer * 60;

            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = (int)(totalSeconds / 3600.0 % 1 * 60);
                int seconds = totalSeconds - (minutes * 60);

                Debug.WriteLine(totalSeconds);
                timerClock.Text = $"{minutes.ToString():00}:" +
                                  $"{seconds.ToString():00}";
            }
            else
            {
                breakTimer.Stop();
                MessageBox.Show("Break ends! Flow Begins");
                mainTimer.Start();
                totalSeconds = flowTimerDuration;
            }
        }
    }
}