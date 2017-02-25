using System;
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
        public IEnumerable<IPosition> Calculate(IPositions positions)
        {
            var results = new Collection<IPosition>();

            foreach (var position in positions.GetPositions())
            {
                
            }

            return results;

        }
    }
}