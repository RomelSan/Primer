using System;
using System.Windows.Forms;

namespace Primer
{
    public partial class Form1 : Form
    {
        public static bool isPrime(long number)
        {
            /*
                This routine consists of dividing n by each integer m that is greater than 1 and 
                less than or equal to the square root of n. If the result of any of these divisions is 
                an integer, then n is not a prime, otherwise it is a prime. Indeed, if n = a*b is 
                composite (with a and b ≠ 1) then one of the factors a or b is necessarily at 
                most square root of n
            */
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
