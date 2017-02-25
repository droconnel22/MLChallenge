using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using mlp.interviews.boxing.problem.Configuration;

namespace mlp.interviews.boxing.problem.Services
{

    /// <summary>
    /// Assume a single file of appropriate size.
    /// This is a class that does Infrastructure, so no need for unit testing, therefore static is fine.
    /// </summary>
    public static class FileReaderService 
    {
        private static readonly IPositionCalculatorConfiguration _positionCalculatorConfiguration;

        static FileReaderService()
        {
            _positionCalculatorConfiguration = new PositionCalculatorConfiguration();
        }

        public static IEnumerable<string[]> ReadFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
                return File
                    .ReadAllLines(filePath)
                    .Skip(1)
                    .Select(ro => ro.Split(_positionCalculatorConfiguration.ApplicationFileDeliminator))
                    .ToList();

            }
            catch (Exception exception)
            {
                //Log infrastructure error with file processing..
                return new List<string[]>();
            }
        }
    }
}