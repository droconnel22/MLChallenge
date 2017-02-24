using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTest.Challenges;
using SoftwareTest.Challenges.Interfaces;
using SoftwareTest.Extensions;

namespace SoftwareTest
{
    public class Program
    {
        private static IEnumerable<IChallenge> challenges = new IChallenge[2]{new NumberCalculator(),new RunLengthEncodingChallenge() };

        public static void Main(string[] args)
        {
            challenges.PrintChallengeResult();
            Console.ReadLine();
        }
    }
}
