using System;
using System.Collections.Generic;
using System.Linq;
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

        public IList<IGrouping<string, IPosition>> GroupByTrader() => new List<IGrouping<string, IPosition>>();

        public IList<IGrouping<object, IPosition>> GroupByTraderAndSymbol() => new List<IGrouping<object, IPosition>>();

        public IEnumerable<string> PrintToFile() => new List<string>();
    }
}