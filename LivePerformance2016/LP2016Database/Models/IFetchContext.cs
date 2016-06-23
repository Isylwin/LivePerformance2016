using System.Collections.Generic;
using LP2016Lib.Classes;

namespace LP2016Database.Models
{
    /// <summary>
    /// Interface for all the fetching from the database.
    /// </summary>
    public interface IFetchContext
    {
        /// <summary>
        /// Gets all the renters from the database.
        /// </summary>
        /// <returns>All the renters that exist.</returns>
        List<Renter> GetAllRenters();
        /// <summary>
        /// Gets all the contracts from the database.
        /// </summary>
        /// <returns>A list with all the contracts.</returns>
        List<Contract> GetAllContracts();
        /// <summary>
        /// Gets all the boats a single contract.
        /// </summary>
        /// <param name="contractId">The id of the contract.</param>
        /// <returns>A list with boats.</returns>
        List<Boat> GetBoatsFor(int contractId);
        /// <summary>
        /// Gets all the articles a single contract.
        /// </summary>
        /// <param name="contractId">The id of the contract.</param>
        /// <returns>A list with articles.</returns>
        List<Article> GetArticlesFor(int contractId);
        /// <summary>
        /// Gets all the allowed waters for a single boat.
        /// </summary>
        /// <param name="boatTypeId">The id of the boat type.</param>
        /// <returns>A list with waters.</returns>
        List<Water> GetWaterFor(int boatTypeId);
        /// <summary>
        /// Gets all the boats from the database.
        /// </summary>
        /// <returns>A list with all the boats from the database.</returns>
        List<Boat> GetAllBoats();
        /// <summary>
        /// Gets all the articles from the database.
        /// </summary>
        /// <returns>A list with all the articles from the database.</returns>
        List<Article> GetAllArticles();
        /// <summary>
        /// Gets all the waters from the database.
        /// </summary>
        /// <returns>A list with all the waters.</returns>
        List<Water> GetAllWaters();
    }
}
