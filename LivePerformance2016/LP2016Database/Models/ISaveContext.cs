using LP2016Lib.Classes;

namespace LP2016Database.Models
{
    /// <summary>
    /// Interface for saving data to the database.
    /// </summary>
    public interface ISaveContext
    {
        /// <summary>
        /// Saves a renter to the database.
        /// </summary>
        /// <param name="renter">The renter that needs to be saved.</param>
        void SaveRenter(Renter renter);
        /// <summary>
        /// Saves a contract to the database.
        /// </summary>
        /// <param name="contract">The contract that should be saved.</param>
        void SaveContract(Contract contract);
    }
}
