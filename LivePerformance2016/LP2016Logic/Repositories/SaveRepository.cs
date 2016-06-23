using System;
using System.Collections.Generic;
using LP2016Database.Context;
using LP2016Database.Models;
using LP2016Lib.Classes;

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

        public void SaveContract(DateTime startDate, DateTime endDate, Renter renter, List<Boat> boats, List<Article> articles)
        {
            try
            {
                var contract = new Contract(startDate, endDate, renter);
                boats.ForEach(x => contract.AddItem(x));
                articles.ForEach(x => contract.AddItem(x));
                
                _context.SaveContract(contract);
            }
            catch (Exception)
            {               
                throw;
            }
        }

        public void SaveRenter(string name, string email)
        {
            try
            {
                //TODO email check in a utility class and include here.
                //TODO custom exceptions.
                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
                    throw new Exception("Naam of email is niet ingevuld.");

                var renter = new Renter(name, email);
                _context.SaveRenter(renter);
            }
            catch (Exception)
            {            
                throw;
            }
        }

    }
}
