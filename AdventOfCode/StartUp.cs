using System;
using AdventOfCode.Day1;
using AdventOfCode.Helpers;

namespace AdventOfCode
{
    public class StartUp
    {
        public static void Main()
        {
            var fileReader = new FileReader();

            Console.WriteLine("Hello world");

            var day1Solution = new DepthFinder(fileReader).Solve();
            Console.WriteLine($"The solution to Day1 is: {day1Solution}");
            var day1Part2Solution = new DepthFinderPart2(fileReader).Solve();
            Console.WriteLine($"The solution to Day1 Part2 is: {day1Part2Solution}");
        }
    }
}
