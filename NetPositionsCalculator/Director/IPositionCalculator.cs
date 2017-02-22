using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlp.interviews.boxing.problem.Director
{
    public interface IPositionCalculator
    {

        IPositionCalculator InitalizePositions();

        IPositionCalculator RunNetPositionCalculator();

        IPositionCalculator RunBoxedPositionCalculator();
      
    }
}
