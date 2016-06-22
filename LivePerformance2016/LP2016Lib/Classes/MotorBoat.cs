using System.Collections.Generic;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// A motor driven boat.
    /// </summary>
    public class MotorBoat : Boat
    {
        /// <summary>
        /// The size of the tank in liters.
        /// </summary>
        public int Tank { get; }

        /// <summary>
        /// The action radius of the vessel in kilometers.
        /// </summary>
        public int ActionRadios => Tank*15;

        /// <summary>
        /// Creates a new motorboat instance.
        /// </summary>
        /// <param name="id">The id of the boat in the database.</param>
        /// <param name="name">The name of the boat.</param>
        /// <param name="price">The price of the boat.</param>
        /// <param name="tank">The volume of the tank.</param>
        /// /// <param name="allowedIn">The waters the boat is allowed in.</param>
        public MotorBoat(int id, string name, decimal price, int tank, List<Water> allowedIn)
            : base(id, name, price, allowedIn)
        {
            Tank = tank;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {ActionRadios}km";
        }
    }
}
