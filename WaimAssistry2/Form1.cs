using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaimAssistry2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Stopwatch watch = new Stopwatch();
        public static Stopwatch watch2 = new Stopwatch();
        private bool gameStarted = false;

        private Random random = new Random();

        int hits = 0;
        int miss = 0;
        int EZ = 1500;
        int Med = 900;
        int hard = 700;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            pbTarget.BackColor = Color.FromArgb(0,255,255,255);
            if (comboBox1.SelectedIndex == 0)
                tmTime.Interval = EZ;
            else if (comboBox1.SelectedIndex == 1)
                tmTime.Interval = Med;
            else if (comboBox1.SelectedIndex == 2)
                tmTime.Interval = hard;

            btnStart.Enabled = false;
            btnStart.Visible = false;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            watch.Reset();
            hits = 0;
            miss = 0;
            lblHits.Text = hits + "";
            lblMiss.Text = miss + "";
        }

        private void btnStart_Click(object sender, EventArgs e)
       {
          // if (!gameStarted)
          // {
          //     gameStarted = true;
          //     watch.Start();
          //
          //     int maxLeft = this.Width - pbTarget.Width;
          //     int maxTop = this.Height - pbTarget.Height;
          //
          //     pbTarget.Left = random.Next(0, maxLeft);
          //     pbTarget.Top = random.Next(0, maxTop);
          //     pbTarget.Visible = true;
          // }
       
       }
        private void btnStop_Click(object sender, EventArgs e)
        {
            watch.Stop();
            gameStarted= false;
        }
       
       
       

        private void tmTime_Tick(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                // Update the elapsed time label
                

                // Move the target button randomly within the form
                int maxLeft = this.Width - pbTarget.Width;
                int maxTop = this.Height - pbTarget.Height;

                pbTarget.Left = random.Next(0, maxLeft);
                pbTarget.Top = random.Next(0, maxTop);
                pbTarget.Visible = true;
            }
        }

        public void tbTrueTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = watch.Elapsed.ToString("hh':'mm':'ss'.'ff");


            // Check if tmTime has reached the target time
            GameOver();
        }

        private void pbTarget_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                watch.Start();

                int maxLeft = this.Width - pbTarget.Width;
                int maxTop = this.Height - pbTarget.Height;

                pbTarget.Left = random.Next(0, maxLeft);
                pbTarget.Top = random.Next(0, maxTop);
                pbTarget.Visible = true;
            }


            pbTarget.Visible = false;
            hits++;
            lblHits.Text = hits + "";

            GameOver();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            miss++;
            lblMiss.Text = miss + "";
            GameOver();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                tmTime.Interval = EZ;
            else if (comboBox1.SelectedIndex == 1)
                tmTime.Interval = Med;
            else if (comboBox1.SelectedIndex == 2)
                tmTime.Interval = hard;
        }
       public void GameOver()
        {

            if (miss == 5 || tbTrueTime.Enabled && tbTrueTime.Interval >= 30000)
            {
                // Stop the timer and update the game state
                tmTime.Stop();
                gameStarted = false;

                // Show the game results
                MessageBox.Show("You hit the Target: " + hits + " times. \r\nYou missed the Target: " + miss + " times. \r\nThe Total time was: " + lblTime.Text);

                // Reset the game state
                hits = 0;
                miss = 0;
                lblHits.Text = hits.ToString();
                lblMiss.Text = miss.ToString();
            }
        }
    }
}
