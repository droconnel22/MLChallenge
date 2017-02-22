using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using mlp.interviews.boxing.problem.Configuration;

namespace mlp.interviews.boxing.problem.Services
{

    /// <summary>
    /// Assume a single file of appriopriate size.
    /// </summary>
    public class FileReaderService : IFileReaderService
    {

        private readonly IPositionCalculatorConfiguration _positionCalculatorConfiguration;

        public FileReaderService()
        {
            
        }

        public IEnumerable<string[]> ReadFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
                return File
                    .ReadAllLines(filePath)
                    .Select(ro => ro.Split(this._positionCalculatorConfiguration.ApplicationFileDeliminator));

            }
            catch (Exception exception)
            {
                //Log infrastructure error with file processing..
                return new List<string[]>();
            }
        }
    }
}