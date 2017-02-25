using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Models.Interfaces;
using mlp.interviews.boxing.problem.Models;

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
            var boxedPositions = new List<IPosition>();           
            foreach (var groupedPositions in positions.GroupByTraderAndSymbol())
            {
                if(groupedPositions.Select(gp => gp.Broker).Distinct().Count() > 1
                    && groupedPositions.Any(pp => pp.Quantity < 0) 
                    && groupedPositions.Any(pp => pp.Quantity > 0))
                {
                     boxedPositions.Add(new Position(
                        groupedPositions.First().Trader,
                        groupedPositions.First().Broker,
                        groupedPositions.First().Symbol,
                        GetAbsoluteQuantityValue(groupedPositions),
                        groupedPositions.First().Price));
                }               
            }

            return boxedPositions;
        }

        private int GetAbsoluteQuantityValue(IGrouping<object, IPosition> gorupedPositoins) => (int)Math.Abs(gorupedPositoins.Sum(p => p.Quantity));
    }
}