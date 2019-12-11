using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.dayOne
{
    class dayOne
    {
        List<string> fuelInput = new List<string>();

        public List<string> ImportInput()
        {
            fuelInput = File.ReadAllLines("input.txt").ToList();
            return fuelInput;
        }

        public int calculateFuelPartTwo(List<String> FuelList)
        {
            var result = 0;
            foreach (string moduel in FuelList)
            {
                var moduelNum = int.Parse(moduel);
                while (true)
                {
                    var fuel = FuelAlgorithm(moduelNum);
                    if (fuel <= 0)
                    {
                        break;
                    }
                    result += fuel;
                    moduelNum = fuel;
                }            
            }
            return result;
        }

        public int calculateFuelPartOne(List<String> FuelList)
        {
            var result = 0;
            foreach (string moduel in FuelList){
                result += FuelAlgorithm(int.Parse(moduel));
            }
            return result;
        }

        public int FuelAlgorithm(int mass)
        {
            return mass / 3 - 2; ;
        }
    }
}
