using System;
using System.Collections.Generic;
using LP2016Database.Context;
using LP2016Database.Models;
using LP2016Lib.Classes;
using LP2016Logic.Exceptions;
using static LP2016Logic.Utilities.ExceptionUtil;

namespace LP2016Logic.Repositories
{
    public class SaveRepository
    {
        private static SaveRepository _instance;
        private readonly ISaveContext _context;

        public static SaveRepository Instance => _instance ?? (_instance = new SaveRepository());

        private SaveRepository()
        {
            _context = new SaveSqlContext();
        }

        /// <summary>
        /// Saves a contract to the database.
        /// </summary>
        /// <param name="startDate">The starting date of the contract.</param>
        /// <param name="endDate">The end date of the contract.</param>
        /// <param name="renter">The renter of the contract.</param>
        /// <param name="boats">The boats that are being rented.</param>
        /// <param name="articles">The articles that are being rented.</param>
        public void SaveContract(DateTime startDate, DateTime endDate, Renter renter, List<Boat> boats, List<Article> articles)
        {
            try
            {
                if(renter == null || boats.Count == 0 || articles.Count == 0)
                    throw new NullException("Vul alle velden in.");

                var contract = new Contract(startDate, endDate, renter);
                boats.ForEach(x => contract.AddItem(x));
                articles.ForEach(x => contract.AddItem(x));
                
                _context.SaveContract(contract);
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        }

        /// <summary>
        /// Saves a renter to the database.
        /// </summary>
        /// <param name="name">The name of the renter.</param>
        /// <param name="email">The email of the renter.</param>
        public void SaveRenter(string name, string email)
        {
            try
            {
                //TODO email check in a utility class and include here.
                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
                    throw new NullException("Naam of email is niet ingevuld.");

                var renter = new Renter(name, email);
                _context.SaveRenter(renter);
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        }

    }
}
