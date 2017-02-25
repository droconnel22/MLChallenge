using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using mlp.interviews.boxing.problem.Configuration;
using mlp.interviews.boxing.problem.Models;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Services
{
    public static class FileWriterService
    {
        public static void WriteToFile(IEnumerable<IPosition> outputLines, string filePath)
        {
            try
            {
                if(string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));               
                File.WriteAllLines(filePath, PrependHeader(outputLines));             
            }
            catch (Exception exception)
            {
                //Log Infrastructure errors.
            }
        }

        private static IEnumerable<string> PrependHeader(IEnumerable<IPosition> outputLines)
        {
            var results = new List<string>();
            results.Add("TRADER,SYMBOL,QUANTITY");
            results.AddRange(outputLines.Select(p => p.ToString()));
            return results;
        }
    }
}