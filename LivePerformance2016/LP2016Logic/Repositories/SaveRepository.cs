using System;
using System.Collections.Generic;
using System.Linq;
using LP2016Database.Context;
using LP2016Database.Models;
using LP2016Lib.Classes;
using LP2016Lib.Interfaces;

namespace LP2016Logic.Repositories
{
    public class SaveRepository
    {
        private static SaveRepository _instance;
        private ISaveContext _context;

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
