using System.Collections.Generic;
using LP2016Lib.Enums;
using LP2016Lib.Interfaces;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// Boats can be rented within the livery.
    /// </summary>
    public abstract class Boat : IRentable, ISaveable
    {
        private readonly List<Water> _allowedIn; 

        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        /// <summary>
        /// The type of the boat.
        /// </summary>
        public BoatType Type { get; }
        /// <summary>
        /// The types of water the boat is allowed in.
        /// </summary>
        public List<Water> AllowedIn => new List<Water>(_allowedIn);

        /// <summary>
        /// Constructs an boat.
        /// </summary>
        /// <param name="id">The id of the boat in the database.</param>
        /// <param name="name">The name of the boat.</param>
        /// <param name="price">The price of the boat.</param>
        /// <param name="type">The type of the boat.</param>
        /// <param name="allowedIn">The types of water the boat is allowed in.</param>
        protected Boat(int id, string name, decimal price, BoatType type, List<Water> allowedIn)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            _allowedIn = allowedIn;
        }

        public override string ToString()
        {
            return $"{Name} - €{Price}";
        }
    }
}
