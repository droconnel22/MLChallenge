using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Models
{
    public sealed class Positions : IPositions
    {
        private IEnumerable<IPosition> positions;

        public Positions(IEnumerable<IPosition> positions)
        {
            this.positions = positions;
        }

        public IEnumerable<IPosition> GetPositions() => this.positions;
    }
}