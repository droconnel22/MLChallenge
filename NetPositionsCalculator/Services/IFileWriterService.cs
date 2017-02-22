using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlp.interviews.boxing.problem.Services
{
    interface IFileWriterService
    {
        void WriteToFile(IEnumerable<string> rawLines, string filePath);
    }
}
