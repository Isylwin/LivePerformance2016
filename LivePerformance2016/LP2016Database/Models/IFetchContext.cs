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
        /// Gets a renter by it's id.
        /// </summary>
        /// <param name="id">The id of the renter.</param>
        /// <returns>The renter with the given id.</returns>
        Renter GetRenterById(int id);
        /// <summary>
        /// Gets all the contracts from the database.
        /// </summary>
        /// <returns>A list with all the contracts.</returns>
        List<Contract> GetAllContracts();
        /// <summary>
        /// Gets a contract by it's id.
        /// </summary>
        /// <param name="id">The id of the contract.</param>
        /// <returns>The contract with the given id.</returns>
        Contract GetContractById(int id);
        /// <summary>
        /// Gets all the boats from the database.
        /// </summary>
        /// <returns>A list with all the boats from the database.</returns>
        List<Boat> GetAllBoats();
        /// <summary>
        /// Gets a boat by it's id.
        /// </summary>
        /// <param name="id">The id of the boat.</param>
        /// <returns>The boat with the given id.</returns>
        Boat GetBoatById(int id);
        /// <summary>
        /// Gets all the articles from the database.
        /// </summary>
        /// <returns>A list with all the articles from the database.</returns>
        List<Article> GetAllArticles();
        /// <summary>
        /// Gets an article by it's id.
        /// </summary>
        /// <param name="id">The id of the article.</param>
        /// <returns>The article with the given id.</returns>
        Article GetArticleById(int id);
        /// <summary>
        /// Gets all the waters from the database.
        /// </summary>
        /// <returns>A list with all the waters.</returns>
        List<Water> GetAllWaters();
        /// <summary>
        /// Gets a water by it's id.
        /// </summary>
        /// <param name="id">The id of the water.</param>
        /// <returns>The water with the given id.</returns>
        Water GetWaterById(int id);
    }
}
