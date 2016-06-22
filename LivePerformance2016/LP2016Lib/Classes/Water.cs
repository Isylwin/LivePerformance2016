using LP2016Lib.Enums;
using LP2016Lib.Interfaces;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// The different types of waters the renters from the livery could venture into.
    /// </summary>
    public class Water : ISaveable
    {
        public int Id { get; }
        /// <summary>
        /// The name of the water area.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The price for entering the water.
        /// </summary>
        public decimal Price { get; }
        /// <summary>
        /// The type of water.
        /// </summary>
        public WaterType Type { get; }
        /// <summary>
        /// If applicable, the limit for entering the water after which the price increases.
        /// </summary>
        public int Limit { get; }
        /// <summary>
        /// If applicable, the extra price for entering the water after a certain limit.
        /// </summary>
        public decimal PriceExtra { get; }

        /// <summary>
        /// Creates a new water instance.
        /// </summary>
        /// <param name="id">The id of the water in the database.</param>
        /// <param name="name">The name of the water.</param>
        /// <param name="price">The price for entering the water.</param>
        /// <param name="type">The type of water.</param>
        public Water(int id, string name, decimal price, WaterType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            Limit = -1;
        }

        /// <summary>
        /// Creates a new water instance.
        /// </summary>
        /// <param name="id">The id of the water in the database.</param>
        /// <param name="name">The name of the water.</param>
        /// <param name="price">The price for entering the water.</param>
        /// <param name="type">The type of water.</param>
        /// <param name="limit">If applicable, the limit for entering the water after which the price increases.</param>
        /// <param name="priceExtra">If applicable, the extra price for entering the water after a certain limit.</param>
        public Water(int id, string name, decimal price, WaterType type, int limit, decimal priceExtra) : this(id, name, price, type)
        {
            Limit = limit;
            PriceExtra = priceExtra;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}) - €{Price}";
        }
    }
}
