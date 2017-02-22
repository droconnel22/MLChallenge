using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlp.interviews.boxing.problem.Models.Interfaces
{
    public interface IPositions
    {
        IEnumerable<IPosition> GetPositions();
    }
}
