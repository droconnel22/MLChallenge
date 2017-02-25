using System.Configuration;

namespace mlp.interviews.boxing.problem.Configuration
{
    public class PositionCalculatorConfiguration : IPositionCalculatorConfiguration
    {
        //Example of using getter and setter for null configuration checking. 
        //Remaining omitted for brevity.
        private char fileDeliminator;
        public char ApplicationFileDeliminator
        {
            set
            {
                var result = ConfigurationManager.AppSettings["ApplicationFileDeliminator"];
                if (string.IsNullOrEmpty(result)) fileDeliminator = ',';
                fileDeliminator = result[0];
            }

            get { return ','; }
        } 

        public string NetPositionInputFile => ConfigurationManager.AppSettings["NetPositionInputFile"];
        public string NetPositionOutputFile => ConfigurationManager.AppSettings["NetPositionOutputFile"];
        public string BoxedPositionInputFile => ConfigurationManager.AppSettings["BoxedPositionInputFile"];
        public string BoxedPositionOutputFile => ConfigurationManager.AppSettings["BoxedPositionOutputFile"];

    }
}