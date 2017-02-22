using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Services
{
    interface IFileWriterService
    {
        void WriteToFile(IPositions positions, string filePath);
    }
}
