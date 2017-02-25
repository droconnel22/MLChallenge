using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mlp.interviews.boxing.problem.Calculators;
using NetPositionsCalculator.Test.Utility;

namespace NetPositionsCalculator.Test.BoxedPositionTests
{
    [TestClass]
    public class BoxedPositionTests
    {
        private ICalculate boxedPositionCalculator;


        [TestMethod]
        public void Calculate_WhenGiven_ValidBoxed_Position_Always_ReturnsPositionWithAbsoluteSum()
        {
            //Arrange
            this.boxedPositionCalculator = new BoxedPositionCalculator();

            //Act
           var results = this.boxedPositionCalculator.Calculate(TestUtility.GetValidPositions());

            //Assert
            foreach (var result in results)
            {
                System.Console.WriteLine(result.ToString());
            }
            

        }
    }
}
