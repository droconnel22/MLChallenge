using System.Collections.Generic;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Models.Interfaces;
using mlp.interviews.boxing.problem.Models;
using System.Linq;

//http://stackoverflow.com/questions/16522645/linq-groupby-sum-and-count
namespace mlp.interviews.boxing.problem.Calculators
{
    public sealed class NetPositionCalculator : ICalculate
    {
        public IEnumerable<IPosition> Calculate(IPositions positions) => 
            positions
                .GroupByTrader()
                .SelectMany(p => p.Select(pos =>
               new Position(pos.Trader, pos.Broker, pos.Symbol, p.Sum(pss => pss.Price), pos.Price)));
    }
}