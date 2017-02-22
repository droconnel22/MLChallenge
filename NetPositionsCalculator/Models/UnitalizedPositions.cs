using System;
using System.Collections.Generic;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Models
{
    public class UnitalizedPositions : IPositions
    {

        [ThreadStatic]
        private static IPositions instance;
        
        private UnitalizedPositions()
        {
            
        }

        public static IPositions GetInstance()
        {
            if(instance == null)
                return new UnitalizedPositions();
            return instance;
        }

        public IEnumerable<IPosition> GetPositions() => new List<IPosition>();
        
    }
}