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
        public static void WriteToFile(IEnumerable<IPosition> positions, string filePath)
        {
            try
            {
                if(string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
                if(positions is UnitalizedPositions) return;
                File.WriteAllLines(filePath, positions.Select(p=> p.ToString()));
            }
            catch (Exception exception)
            {
                //Log Infrastructure errors.
            }
        }
    }
}