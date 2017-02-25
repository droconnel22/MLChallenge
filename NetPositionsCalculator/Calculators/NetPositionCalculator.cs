using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;
using mlp.interviews.boxing.problem.Models;
using System.Linq;


namespace mlp.interviews.boxing.problem.Calculators
{
    public sealed class NetPositionCalculator : ICalculate
    {
        //for completeness (.net complier automatically generates)
        public NetPositionCalculator(){ }
        //Could be made parallel with PLinq, however order will not be preserved and 
        //input data sample is too small to justify overhead cost.
        //price could be made decimal, but kept int for contrived case.
        public IEnumerable<IPosition> Calculate(IPositions positions) => 
          positions
                .GetPositions()
                .GroupBy(p =>new { p.Trader, p.Symbol })               
                .Select(pos =>
                    new Position(pos.First().Trader, pos.First().Broker, pos.First().Symbol, (int)pos.Sum(pl => pl.Quantity) , pos.First().Price))
                .ToList();
    }
}

/*
 * Contrived Parallel Example (too slow for sample size). Note order will not be preserved.
 *    .GetPositions()
                .GroupBy(p =>new { p.Trader, p.Symbol })
                .AsParallel()
                .Select(pos =>
                    new Position(pos.First().Trader, pos.First().Broker, pos.First().Symbol, (int)pos.Sum(pl => pl.Quantity) , pos.First().Price))
                .ToList()
                .OrderBy(p => p.Trader);
 */
