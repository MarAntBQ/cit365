using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        //Check Sounds Variables
        bool PSounded = false, MSounded = false, TSounded = false, DSounded = false;

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Set the settings of sound by default in order to don't make a sound when they were changed
            PSounded = false;
            MSounded = false;
            TSounded = false;
            DSounded = false;


            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
        && (minuend - subtrahend == difference.Value)
        && (multiplicand * multiplier == product.Value)
        && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        //Make a method in order to get the Month name through and int
        private String getMonthName(int month)
        {
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }
            return monthName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the user click on the answer input, make it easy to edit
            sum.Click += new EventHandler(answer_Enter);
            difference.Click += new EventHandler(answer_Enter);
            product.Click += new EventHandler(answer_Enter);
            quotient.Click += new EventHandler(answer_Enter);
            //Get the current date
            DateTime thisDate = DateTime.Today;
            //Obtain the month number
            int month = thisDate.Month;
            // send it to the method in order to obtain the name
            string monthName = getMonthName(month);
            //Display on screen the text
            DateLabel.Text = "The Current Date is: " + thisDate.Day + " " + monthName + " " + thisDate.Year;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //by default the inputs boxes are disable, so make them enabled to play
            sum.Enabled = true;
            difference.Enabled = true;
            product.Enabled = true;
            quotient.Enabled = true;
            // Start the quiz
            StartTheQuiz();
            // Make the button disabled until the game is done
            startButton.Enabled = false;    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                startButton.Enabled = true;
                //When all the answers are right make the inputs disabled to be edited
                sum.Enabled = false;
                difference.Enabled = false;
                product.Enabled = false;
                quotient.Enabled = false;
            }
            else if(timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                //if thime is 5 seconds left change the color
                if (timeLeft <= 5) {
                    timeLabel.BackColor = Color.Red;
                }
            }
            
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                //Play a sound when the game is over
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Alarm01.wav");
                simpleSound.Play();
                timeLabel.BackColor = Color.White;
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Math Quiz! - Sorry!");
                //Make the Sound bool vars true in order to don't sound when they'll be changed
                PSounded = true;
                MSounded = true;
                TSounded = true;
                DSounded = true;
                //Display the right answers
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                //Make the button enable in order to play again
                startButton.Enabled = true;
                //Disable the inputs until the user click again to play again
                sum.Enabled = false;
                difference.Enabled = false;
                product.Enabled = false;
                quotient.Enabled = false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Right_Answer(object sender, EventArgs e)
        {
            //if the user didn't make the right math and its answer are right play the sound, and disable each math 

            if ((PSounded == false) && (addend1 + addend2 == sum.Value)) { 
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
                simpleSound.Play();
                sum.Enabled = false;
                PSounded = true;
            }
            if ((MSounded == false) && (minuend - subtrahend == difference.Value))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
                simpleSound.Play();
                MSounded = true;
                difference.Enabled = false;
            }
            if ((TSounded == false) && (multiplicand * multiplier == product.Value))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
                simpleSound.Play();
                TSounded = true;
                product.Enabled = false;
            }
            if ((DSounded == false) && (dividend / divisor == quotient.Value))
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
                simpleSound.Play();
                DSounded = true;
                quotient.Enabled = false;
            }

        }
    }
}
