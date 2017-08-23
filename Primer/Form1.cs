using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace Primer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        long toFactor; // global variable, number to factor
        Stopwatch stopwatch = new Stopwatch(); // timer

        private void working_on()
        {
            button1_factor.Enabled = false;
            button2_checkPrime.Enabled = false;
            button1_factor.Text = "Working...";
            button2_checkPrime.Text = "Working...";
            textBox2_result.Clear();
            Refresh();

            // Reset StopWatch
            stopwatch.Reset();

            // Begin timing.
            stopwatch.Start();
        }
        private void working_off()
        {
            // Stop timing.
            stopwatch.Stop();

            // Write calculation time result.
            label3_timer.Text = "Time Elapsed: " + stopwatch.Elapsed.ToString();

            // re enable button
            button1_factor.Text = "Factor";
            button2_checkPrime.Text = "Is it prime?";
            button1_factor.Enabled = true;
            button2_checkPrime.Enabled = true;
            textBox1_number.Focus();
        }
        private void button2_checkPrime_Click(object sender, EventArgs e)
        {
            working_on();
            // Checks if the number entered is prime
            bool canbeFactored = check_enteredValue(textBox1_number.Text); // checks if the number is a "long".
            if (canbeFactored == false)
            {
                string message = "The number must be between 2 and " + long.MaxValue;
                MessageBox.Show(message, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // if the value entered can be factored then proceed
            {
                bool checkPrime_result = isPrime(toFactor);
                if (checkPrime_result == true)
                {
                    textBox2_result.Text = "It is prime";
                }
                else
                {
                    textBox2_result.Text = "It is not prime";
                }
            }
            working_off();
        }
        private void button1_factor_Click(object sender, EventArgs e)
        {
            working_on();
            // Try to Factor the number entered in the textbox
            bool canbeFactored = check_enteredValue(textBox1_number.Text); // checks if the number can be factored
            if (canbeFactored == false)
            {
                string message = "The number must be between 2 and " + long.MaxValue;
                MessageBox.Show(message, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // if the value entered can be factored then proceed to factor
            {
                string factor_result = factor_number(toFactor);
                textBox2_result.Text = factor_result; // returns the factor result
            }
            working_off();
        }

        private bool check_enteredValue(string enteredValue)
        {
            // check if the entered value can be factored (Checks if it can be validated as a "long")
            if (!long.TryParse(enteredValue, out toFactor))  
            {
                toFactor = -1; // set the variable to -1 if the value can not be factored
            }

            if (toFactor < 2)
            {
                return false;
            }
            else
            {
                return true; // the entered value can be factored
            }
        }
        #region Factor Number Functions
        private string factor_number(long number)
        {
            // Get the factors.
            List<long> factors = FindFactors(number);
            List<string> strings = factors.ConvertAll<string>(x => x.ToString());
            return string.Join(" x ", strings.ToArray());
            // Return the number prime factor.
        }
        private List<long> FindFactors(long num)
        {
            List<long> result = new List<long>();

            // Take out the 2s.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Take out other primes.
            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // This is a factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Go to the next odd number.
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);

            return result;
        }
        #endregion

    }
}
