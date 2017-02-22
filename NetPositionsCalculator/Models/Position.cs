using System;
using mlp.interviews.boxing.problem.Models.Interfaces;

namespace mlp.interviews.boxing.problem.Models
{
    public sealed class Position : IPosition, IEquatable<IPosition>
    {
        public string Trader { get; }
        public string Broker { get; }
        public string Symbol { get; }
        public int Quantity { get; }
        public int Price { get; }

        public Position(string trader, string broker, string symbol, int quantity, int price )
        {
            if(string.IsNullOrEmpty(trader) || string.IsNullOrEmpty(broker) || string.IsNullOrEmpty(symbol)) 
                throw  new ArgumentNullException("Position unable to be created");

            this.Trader = trader;
            this.Broker = broker;
            this.Symbol = symbol;
            this.Quantity =  quantity;
            this.Price = price;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj);
        }

        public bool Equals(IPosition other)
        {

            if (other == null) return false;

            return
                string.Equals(this.Trader, other.Trader, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(this.Broker, other.Broker, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(this.Symbol, other.Symbol, StringComparison.InvariantCultureIgnoreCase)
                && this.Quantity == other.Quantity
                && this.Price == other.Price;
        }
    }
}