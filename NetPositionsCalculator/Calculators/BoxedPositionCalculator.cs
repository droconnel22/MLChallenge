using System;
using System.Collections.Generic;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators
{
    internal sealed class BoxedPositionCalculator : ICalculate
    {
        private readonly IPositionStrategy boxedPositionStrategy;
        
        //TODO DOC
        public BoxedPositionCalculator(IPositionStrategy positionStrategy)
        {
            this.boxedPositionStrategy = new BoxedPositionStrategy();
        }


        //Synchronous approach
        public IEnumerable<string> Calculate(IPositions positions)
        {
         
            
            
            throw new NotImplementedException();  
        }
    }
}