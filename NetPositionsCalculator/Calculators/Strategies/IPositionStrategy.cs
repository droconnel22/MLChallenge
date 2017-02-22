using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Calculators.Strategies
{
    /// <summary>
    /// Boxed positions are defined as:
    ///  A trader has long quantity less than 0 
    /// and short quantity greater than 0
    /// positions for the same symbol at different brokers.
    /// </summary>

    internal interface IPositionStrategy
    {
        bool DoesMatch(IPosition position);
    }
}