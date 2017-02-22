using System.Collections.Generic;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators
{
    internal sealed class NetPositionCalculator : ICalculate
    {
        private readonly IPositionStrategy netPositionStrategy;

        public NetPositionCalculator(IPositionStrategy positionStrategy)
        {
            this.netPositionStrategy = positionStrategy;
        }

        public IEnumerable<IPosition> Calculate(IPositions positions)
        {
            throw new System.NotImplementedException();
        }
    }
}