using System.Collections;
using System.Collections.Generic;
using mlp.interviews.boxing.problem.Calculators;
using mlp.interviews.boxing.problem.Calculators.Strategies;
using mlp.interviews.boxing.problem.Configuration;
using mlp.interviews.boxing.problem.Models;
using mlp.interviews.boxing.problem.Models.Exetensions;
using mlp.interviews.boxing.problem.Models.Interfaces;
using mlp.interviews.boxing.problem.Services;

namespace mlp.interviews.boxing.problem.Director
{
    public class PositionCalculator : IPositionCalculator
    {
        private readonly IPositionCalculatorConfiguration _positionCalculatorConfiguration;

        //Could refactor to dictionary if more calculators added.
        private readonly ICalculate boxedPositionCalculator;

        private readonly ICalculate netPositionCalculator;

        private IPositions positions;

        //Can use IoC here
        public PositionCalculator()
        {
            this._positionCalculatorConfiguration = new PositionCalculatorConfiguration();
            this.boxedPositionCalculator = new BoxedPositionCalculator();
            this.netPositionCalculator = new NetPositionCalculator();
            this.positions = UnitalizedPositions.GetInstance();
        }


        public IPositionCalculator InitalizePositions()
        {
           this.positions =
               FileReaderService
                .ReadFile(this._positionCalculatorConfiguration.NetPositionInputFile)
                .GeneratePositions();
            return this;
        }

        public IPositionCalculator RunNetPositionCalculator()
        {
            if (this.positions is UnitalizedPositions) return this;
            this.netPositionCalculator
                .Calculate(this.positions)
                .PrintResults(this._positionCalculatorConfiguration.NetPositionOutputFile);

            return this;
        }

        public IPositionCalculator RunBoxedPositionCalculator()
        {
            if (this.positions is UnitalizedPositions) return this;
            this.boxedPositionCalculator
                .Calculate(this.positions)
                .PrintResults(this._positionCalculatorConfiguration.BoxedPositionOutputFile);

            return this;
        }
    }
}