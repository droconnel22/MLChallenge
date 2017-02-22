namespace mlp.interviews.boxing.problem.Models.Interfaces
{
    public interface IPosition
    {
        string Trader { get; }

        string Broker { get; }

        string Symbol { get; }

        int Quantity { get; }

        //Contrived.
        int Price { get; }
    }
}
