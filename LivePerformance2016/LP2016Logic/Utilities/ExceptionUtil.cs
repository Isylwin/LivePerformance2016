using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP2016Logic.Exceptions;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LP2016Logic.Utilities
{
    public class ExceptionUtil
    {
        /// <summary>
        /// Catches all oracle database exceptions from an exception and turns it into a general database error if it is a oracle exception.
        /// </summary>
        /// <param name="e">The exception to check.</param>
        public static void FilterOracleDatabaseException(Exception e)
        {
            Console.WriteLine(e.Message);

            if (e is OracleException || e.GetBaseException() is OracleException || e is OracleTypeException || e.GetBaseException() is OracleTypeException)
                throw new DatabaseException("A database error has occured.", e);
        }
    }
}
