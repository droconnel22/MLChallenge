using mlp.interviews.boxing.problem.Models;
using mlp.interviews.boxing.problem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPositionsCalculator.Test.Utility
{
   internal static class TestUtility
    {
        internal static IPositions GetValidPositions() =>
            new Positions(new List<IPosition>()
            {
                new Position("Joe","ML","IBM.N",100,50),
                new Position("Joe","DB", "IBM.N",-50,50),
                new Position("Joe","CS","IBM.N",30,30), //not boxed because negative
                new Position("Mike","DB","IBM.N",-50,50),
                new Position("Debby","DB","NVDA.N",500,30)
            });

       
    }
}
