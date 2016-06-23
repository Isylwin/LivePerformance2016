using LP2016Lib.Interfaces;

namespace LP2016Lib.Classes
{
    /// <summary>
    /// A customer of the livery.
    /// </summary>
    public class Renter
    {
        public int Id { get; }
        /// <summary>
        /// The name of the renter.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The email of the renter.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Creates a new renter.
        /// </summary>
        /// <param name="name">The name of the renter.</param>
        /// <param name="email">The email of the renter.</param>
        public Renter(string name, string email)
        {
            Name = name;
            Email = email;
        }

        /// <summary>
        /// Creates a new renter.
        /// </summary>
        /// <param name="id">The id of the renter in the database.</param>
        /// <param name="name">The name of the renter.</param>
        /// <param name="email">The email of the renter.</param>
        public Renter(int id, string name, string email) : this(name, email)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}
