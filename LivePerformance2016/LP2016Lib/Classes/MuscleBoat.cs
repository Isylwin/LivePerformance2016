using System.Collections.Generic;
using LP2016Lib.Enums;

namespace LP2016Lib.Classes
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
        /// <param name="type">The type of the boat.</param>
        /// <param name="allowedIn">The waters the boat is allowed in.</param>
        /// <param name="paysToll">Indicates wheter a boat pays toll at a gate</param>
        public MuscleBoat(int id, string name, decimal price, BoatType type, List<Water> allowedIn, bool paysToll) : base(id, name, price, type, allowedIn, paysToll)
        {

        }
    }
}
