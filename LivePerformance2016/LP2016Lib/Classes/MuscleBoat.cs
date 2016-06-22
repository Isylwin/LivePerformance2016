﻿namespace LP2016Lib.Classes
{
    /// <summary>
    /// A boat driven by muscular forces.
    /// </summary>
    public class MuscleBoat : Boat
    {

        /// <summary>
        /// Creates an instance of a muscle boat.
        /// </summary>
        /// <param name="id">The id of the boat in the database.</param>
        /// <param name="name">The name of the boat.</param>
        /// <param name="price">The price of the boat.</param>
        public MuscleBoat(int id, string name, decimal price) : base(id, name, price)
        {
            
        }
    }
}
