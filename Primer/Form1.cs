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

        private void button1_factor_Click(object sender, EventArgs e)
        {
            button1_factor.Enabled = false;
            button1_factor.Text = "Working...";
            textBox2_result.Clear();
            Refresh();

            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Get the number.
            long number;
            if (!long.TryParse(textBox1_number.Text, out number)) number = -1;
            if (number < 2)
            {
                MessageBox.Show("The number must be between 2 and " + long.MaxValue);
                textBox1_number.Focus();
                button1_factor.Text = "Factor";
                button1_factor.Enabled = true;
                return;
            }

            // Get the factors.
            List<long> factors = FindFactors(number);
            List<string> strings = factors.ConvertAll<string>(x => x.ToString());
            textBox2_result.Text = string.Join(" x ", strings.ToArray());

            // Stop timing.
            stopwatch.Stop();

            // Write calculation time result.
            label3_timer.Text = "Time Elapsed: " + stopwatch.Elapsed.ToString();

            // re enable button
            button1_factor.Enabled = true;
            button1_factor.Text = "Factor";
            textBox1_number.Focus();
        }

        // Return the number's prime factors.
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
    }
}
