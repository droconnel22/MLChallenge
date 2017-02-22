using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators
{
    internal interface ICalculate
    {
        IEnumerable<string> Calculate(IPositions positions);
    }
}
