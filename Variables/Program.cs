using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment - uses 2 forward slashes to indicate that the compiler will ignore this
            //comments are for humans to leave notes / comments

            //start variables exercise coding below:
            int dogAge = 10;
            string dogName = "Daisy";
            bool isLazy = true;
            double hoursADay = 16;
            decimal weight = 60.5m;

            Console.WriteLine($"My dog's name is {dogName}, She is {dogAge}, She is {isLazy}, She Sleeps {hoursADay}, She weight {weight},");
        }
    }
}
