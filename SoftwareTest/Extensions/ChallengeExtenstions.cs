using System;
using System.Collections.Generic;
using SoftwareTest.Challenges.Interfaces;

namespace SoftwareTest.Extensions
{
    internal static class ChallengeExtenstions
    {
        public static void PrintChallengeResult(this IEnumerable<IChallenge> challenges)
        {
            foreach (IChallenge challenge in challenges)
            {
                string name = challenge.GetType().Name;
                Console.WriteLine(challenge.Winner() ? $"You win at challenge {name}" : $"You lose at challenge {name}");
            }
        }
    }
}