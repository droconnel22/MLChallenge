using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators
{
    public  interface ICalculate
    {
        IEnumerable<IPosition> Calculate(IPositions positions);
    }
}
