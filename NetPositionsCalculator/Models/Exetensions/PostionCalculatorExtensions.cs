using System.Collections.Generic;
using mlp.interviews.boxing.problem.Factories;
using mlp.interviews.boxing.problem.Models.Interfaces;
using mlp.interviews.boxing.problem.Services;

namespace mlp.interviews.boxing.problem.Models.Exetensions
{

    //Utility class to improve readability.
    internal static class PostionCalculatorExtensions
    {
        public static IPositions GeneratePositions(this IEnumerable<string[]> rawlines) => PositionFactory.CreatePositions(rawlines);


        public static void PrintResults(this IEnumerable<IPosition> results, string outFile) => FileWriterService.WriteToFile(results, outFile);
    }
}
