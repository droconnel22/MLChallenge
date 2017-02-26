using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;
using System.Linq;

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

        public IList<IGrouping<string, IPosition>> GroupByTrader() =>
            this.positions
            .GroupBy(p => p.Trader)
            .ToList();      

        public IList<IGrouping<object, IPosition>> GroupByTraderAndSymbol() => 
            this.positions                 
                 .GroupBy(ps => (object)new { ps.Trader, ps.Symbol })
                 .ToList();

    }
}