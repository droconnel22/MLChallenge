using SoftwareTest.Challenges.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareTest
{
    /// <summary>
    /// Challenge Uno - NumberCalculator
    ///
    /// Fill out the TODOs with your own code and make any
    /// other appropriate improvements to this class.
    /// </summary>
    public class NumberCalculator : IChallenge
    {
        public int FindMax(int[] numbers) => numbers.Max();
      
        public int[] FindMax(int[] numbers, int n) =>
            numbers
                .OrderByDescending(nu => nu)
                .Take(n)
                .ToArray();

        //Orderby is stable and better performing then Sort()
        public int[] Sort(int[] numbers) => 
            numbers
            .OrderBy(n => n)
            .ToArray();
       

        public bool Winner()
        {
            var numbers = new[] { 5, 7, 5, 3, 6, 7, 9 };
            var sorted = Sort(numbers);
            var maxes = FindMax(numbers, 2);
          
            // TODO: Are the following test cases sufficient, to prove your code works
            // as expected? If not either write more test cases and/or describe what
            // other tests cases would be needed.

            /*

            --Order Of Operations
            --Size of Arrays, test for stack overflow
            --

            */

            return FindMax(numbers) == 9 && FindMax(sorted) == 9;

            return sorted.First() == 3
                   && sorted.Last() == 9
                   && FindMax(numbers) == 9
                   && maxes[0] == 9
                   && maxes[1] == 7;

        }
    }
}