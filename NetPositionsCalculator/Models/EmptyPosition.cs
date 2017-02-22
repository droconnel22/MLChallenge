using System;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Models
{
    public class EmptyPosition : IPosition
    {
        public string Trader { get; }
        public string Broker { get; }
        public string Symbol { get; }
        public int Quantity { get; }
        public int Price { get; }

        [ThreadStatic]
        private static IPosition instance;

        private EmptyPosition()
        {
            this.Trader = string.Empty;
            this.Broker = string.Empty;
            this.Symbol = string.Empty;
            this.Quantity = 0;
            this.Price = 0;
        }
     
        public static IPosition GetInstance()
        {
            if(instance == null)
                return new EmptyPosition();
            return instance;
        }

    }
}