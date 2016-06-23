using System;
using System.Collections.Generic;
using LP2016Lib.Interfaces;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// A rental contract that a renter can disclose with the livery.
    /// </summary>
    public class Contract : ISaveable
    {
        private readonly List<IRentable> _items; 

        public int Id { get; }
        /// <summary>
        /// The starting date of the rental period.
        /// </summary>
        public DateTime StartDate { get; }
        /// <summary>
        /// The end date of the rental period.
        /// </summary>
        public DateTime EndDate { get; }
        /// <summary>
        /// The renter.
        /// </summary>
        public Renter Renter { get; }
        /// <summary>
        /// The items that are being rented out.
        /// </summary>
        public List<IRentable> Items => new List<IRentable>(_items);

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="startDate">The starting date of the rental period.</param>
        /// <param name="endDate">The ending date of the rental period.</param>
        /// <param name="renter">The renter.</param>
        public Contract(DateTime startDate, DateTime endDate, Renter renter)
        {
            StartDate = startDate;
            EndDate = endDate;
            Renter = renter;
            _items = new List<IRentable>();
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="startDate">The starting date of the rental period.</param>
        /// <param name="endDate">The ending date of the rental period.</param>
        /// <param name="renter">The renter.</param>
        /// <param name="items">The items that are being rented out.</param>
        public Contract(DateTime startDate, DateTime endDate, Renter renter, List<IRentable> items) : this(startDate, endDate, renter)
        {      
            _items = items;
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="id">The id of the contract in the database.</param>
        /// <param name="startDate">The starting date of the rental period.</param>
        /// <param name="endDate">The ending date of the rental period.</param>
        /// <param name="renter">The renter.</param>
        /// <param name="items">The items that are being rented out.</param>
        public Contract(int id, DateTime startDate, DateTime endDate, Renter renter, List<IRentable> items)
            : this(startDate, endDate, renter, items)
        {
            Id = id;
        }

        /// <summary>
        /// Adds a item to the contract.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem(IRentable item)
        {
            if (!_items.Contains(item))
                _items.Add(item);
        }

        public override string ToString()
        {
            return $"{Renter.Name}: {StartDate.Date} - {EndDate.Date}";
        }
    }
}
