# Primer
Find a number’s prime factors in C#

### Requires
* Net Framework 4.5.2
* Built on Visual Studio 2015
* Tested on Windows 10

### Explanation
Source **C# Helper** :  
This example uses the following `FindFactors` method to find a number’s prime factors.
```cs
// Return the number's prime factors.
private List FindFactors(long num)
{
    List result = new List();

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
```
First, while the number `num` is divisible by 2, the program adds 2 to the list of factors and divides `num` by 2.  

Next, for odd numbered values `factor` = 3, 5, 7, and so on, the program determines whether `factor` divides evenly into `num`. If factor does divide evenly into `num`, the program adds `factor` to the list of `factors` and divides `num` by it. If `factor` does not divide `num` evenly, the program adds 2 to `factor` to check the next odd number.  

The program stops when `factor` &mult; `factor` is greater than `num`.  

The following code shows how the program uses this method.  

```cs
// Get the number's factors.
long num = long.Parse(txtNumber.Text);
List<long> factors = FindFactors(num);

// Display the factors.
List<string> strings = factors.ConvertAll(x => x.ToString());
txtFactors.Text = string.Join(" x ", strings.ToArray());
```
This code first calls the `FindFactors` method to get the list of factors.  

That list contains long integers and the program needs strings, so the code calls the list’s `ConvertAll` method. That’s a LINQ extension method that takes as a parameter a method that converts each of the items in the list into a new type. This example uses the lambda expression `x => x.ToString()` to call each value’s `ToString` method to convert it into a string.  

Finally the code calls the `string.Join` method to merge the factors (now strings) into a single string. It uses the list’s `ToArray` LINQ extension method to convert the list into an array because `string.Join` cannot work with a list. The code finishes by displaying the concatenated results in its text box.  

### Credits
* Rod Stephens - [website](http://csharphelper.com/blog/rod/)