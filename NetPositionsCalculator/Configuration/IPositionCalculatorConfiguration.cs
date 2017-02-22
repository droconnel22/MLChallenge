using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlp.interviews.boxing.problem.Configuration
{
    interface IPositionCalculatorConfiguration
    {
        char ApplicationFileDeliminator { get; }

        string NetPositionInputFile { get; }

        string NetPositionOutputFile { get; }

        string BoxedPositionInputFile { get; }

        string BoxedPositionOutputFile { get; }

        
    }
}
