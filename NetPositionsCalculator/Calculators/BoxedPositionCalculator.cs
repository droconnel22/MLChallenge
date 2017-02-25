using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators
{
    public sealed class BoxedPositionCalculator : ICalculate
    {       
        public BoxedPositionCalculator()
        {           
        }

        //Synchronous approach
        //A trader has long (quantity > 0) and short (quantity < 0
        //positions for the same symbol at different brokers.
        //Show the minimum quantity of all long positions or the 
        //absolute sum of all short positions. 
        //ie. minimum of (100 + 30) and abs(-50) is 50
        public IEnumerable<IPosition> Calculate(IPositions positions)
        {

            var positoinByTraderSymbol = positions
                 .GetPositions()
                 .GroupBy(ps => new { ps.Trader, ps.Broker, ps.Symbol })
                 .ToList();

            foreach (var item in positoinByTraderSymbol)
            {

            }


            var results = new Collection<IPosition>();
            foreach (var position in positions.GetPositions())
            {

            }

            return results;

        }
    }
}