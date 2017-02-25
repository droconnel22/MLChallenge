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
            Assert.IsNotNull(results);
            foreach (var result in results)
            {

                Assert.AreEqual("Joe", result.Trader);
                Assert.AreEqual("IBM.N", result.Symbol);
                Assert.AreEqual(80, result.Quantity);
            }
            

        }
    }
}
