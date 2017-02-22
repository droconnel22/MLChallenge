using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using mlp.interviews.boxing.problem.Director;

namespace NetPositionsCalculator.Console
{
    class Program
    {
        private static readonly IPositionCalculator positionCalculator = new PositionCalculator();

        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Running....");
                positionCalculator
                    .InitalizePositions()
                    .RunNetPositionCalculator()
                    .RunBoxedPositionCalculator();
                System.Console.WriteLine("Completed Successfully.");
            }
            catch (Exception exception)
            {
              System.Console.WriteLine(exception.Message);
            }

            System.Console.ReadLine();
        }
    }
}
