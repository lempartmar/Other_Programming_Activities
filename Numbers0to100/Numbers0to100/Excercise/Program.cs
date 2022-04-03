

using System;
using System.Linq;

// https://softdevpractice.com/blog/enumerable-range-by-example/

//FizzBuzz is a children’s game where
//you count from 1 to 20. Easy, right?

//Here’s the catch: instead of saying
//numbers divisible by 3, say “Fizz”.
//And instead of saying numbers
//divisible by 5, say “Buzz”. For
//numbers divisible by both 3 and 5, say
//“FizzBuzz”.

//“1, 2, Fizz, 4, Buzz”…and so forth

//Let’s start by using console.log to
//print out all of the numbers from 1
//and 20.

//But don’t type out the numbers in
//order—find a more awesome way!

namespace Excercise
{

    public class Program
    {
        private static void Solution()
        {
            Enumerable.Range(1, 100).Select(x =>
            {
                var napis = "";
                if (x % 3 == 0)
                    napis += "Fizz";
                if (x % 5 == 0)
                    napis += "FizzBuzz";
                if (napis == "")
                    napis = x.ToString();

                return napis;

            }).ToList().ForEach(Console.WriteLine);
            
        }
        public static void Main(string[] args)
        {
            Solution();

        }
    }
}