using System;
using System.Collections.Generic;
using AdventOfCode.dayOne;
namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            dayOne.dayOne test = new dayOne.dayOne();
            List<string> fuelInput = test.ImportInput();
            Console.WriteLine(test.calculateFuelPartTwo(fuelInput));
        }

    }
}
