using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlp.interviews.boxing.problem.Services
{
    interface IFileReaderService
    {
        IEnumerable<string[]> ReadFile(string filePath);
    }
}
