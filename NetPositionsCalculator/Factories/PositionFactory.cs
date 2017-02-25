using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mlp.interviews.boxing.problem.Models;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Factories
{
    public static class PositionFactory
    {
        public static IPositions CreatePositions(IEnumerable<string[]> rawlines) => new Positions(rawlines.Select(CreatePosition).ToList());
        public static IPosition CreatePosition(string[] model)
        {
           if(model == null) throw  new ArgumentNullException(nameof(model));
           if (model.Length < 5) return EmptyPosition.GetInstance();
           return  new Position(model[0], model[1], model[2], TranslateToQuantity(model[3]), TranslateToPrice(model[4]));
        }

        private static int TranslateToQuantity(string s)
        {
            int result;
            int.TryParse(s, out result);
            return result;
        }

        private static int TranslateToPrice(string s)
        {
            int result;
            int.TryParse(s, out result);
            return result;
        }
    }
}
