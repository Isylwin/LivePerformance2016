using System;
using System.Collections.Generic;
using LP2016Database.Context;
using LP2016Database.Models;
using LP2016Lib.Classes;
using static LP2016Logic.Utilities.ExceptionUtil;

namespace LP2016Logic.Repositories
{
    public class FetchRepository
    {
        private static FetchRepository _instance;
        private readonly IFetchContext _context;

        public static FetchRepository Instance => _instance ?? (_instance = new FetchRepository());

        private FetchRepository()
        {
            _context = new FetchSqlContext();
        }

        public List<Renter> GetAllRenters()
        {
            try
            {
                return _context.GetAllRenters();
            }
            catch (Exception e)
            {       
                FilterOracleDatabaseException(e);       
                throw;
            }
        }

        public List<Contract> GetAllContracts()
        {
            try
            {
                return _context.GetAllContracts();
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        }

        public List<Article> GetAllArticles()
        {
            try
            {
                return _context.GetAllArticles();
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        }

        public List<Boat> GetAllBoats()
        {
            try
            {
                return _context.GetAllBoats();
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        }

        public List<Water> GetAllWaters()
        {
            try
            {
                return _context.GetAllWaters();
            }
            catch (Exception e)
            {
                FilterOracleDatabaseException(e);
                throw;
            }
        } 
    }
}
