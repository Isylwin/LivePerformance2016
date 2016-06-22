using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LP2016Database
{
    /// <summary>
    /// Database class, is a singleton, handles the connecting to the database automaticly.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Connection string for an oracle connection.
        /// </summary>
        private static readonly string ConnectionString =
            $"data source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = {DatabaseConfig.Default.Host})(PORT = {DatabaseConfig.Default.Port})))" +
            $"(CONNECT_DATA =(SERVICE_NAME = {DatabaseConfig.Default.Service})));USER ID={DatabaseConfig.Default.Username};PASSWORD={DatabaseConfig.Default.Password}";

        private static Database _instance;

        private readonly string PackageName = "pkgPlSql.";

        /// <summary>
        /// The instance of the singleton Database. Connects to the database automaticly.
        /// </summary>
        public static Database Instance
        {
            get
            {
                if (_instance == null || !_instance.IsConnected)
                {
                    return _instance = new Database();
                }
                return _instance;
            }
        }

        private bool IsConnected => Connection.State == ConnectionState.Open;

        public OracleConnection Connection { get; }

        /// <summary>
        /// Private constructor that connects to a database using the connection string.
        /// </summary>
        private Database()
        {
            Connection = new OracleConnection { ConnectionString = ConnectionString };
            Connection.Open();
        }

        /// <summary>
        /// Deconstructor for closing the connection when the program terminates.
        /// </summary>
        ~Database()
        {
            Connection.Close();
        }

        /// <summary>
        /// Executes a query given as string with the given parameters and query type.
        /// </summary>
        /// <param name="query">The query that should be send to the database.</param>
        /// <param name="parameters">The parameters used in the query.</param>
        /// <param name="queryType">The type of query.</param>
        /// <returns>A reader object if the query returns results, returns null otherwise.</returns>
        public OracleDataReader ExecuteQuery(string query, Dictionary<string, object> parameters, QueryType queryType)
        {
            using (var command = new OracleCommand(query, Connection) { CommandType = CommandType.Text })
            {
                //Add all the parameters to the oracle command.
                foreach (var entry in parameters)
                {
                    command.Parameters.Add(new OracleParameter(entry.Key, entry.Value));
                }

                //If the query should return a reader, return a reader.
                if (queryType == QueryType.Query)
                    return command.ExecuteReader();
                command.ExecuteNonQuery();
                return null;
            }
        }

        /// <summary>
        /// Executes a query given as string with the given query type.
        /// </summary>
        /// <param name="query">The query that should be send to the database.</param>
        /// <param name="queryType">The type of query.</param>
        /// <returns>A reader object if the query returns results, returns null otherwise.</returns>
        public OracleDataReader ExecuteQuery(string query, QueryType queryType) => ExecuteQuery(query, new Dictionary<string, object>(), queryType);

        /// <summary>
        /// Executes a non returning stored procedure with the given parameters.
        /// </summary>
        /// <param name="name">The name of the procedure.</param>
        /// <param name="parameters">The parameters for the procedure.</param>
        public void ExecuteStoredProcedure(string name, List<OracleParameter> parameters)
        {
            using (var command = new OracleCommand(PackageName + name, Connection) {CommandType = CommandType.StoredProcedure})
            {
                foreach (var param in parameters)
                {                 
                    command.Parameters.Add(param);
                }

                command.ExecuteNonQuery();
            }
        }
    }

    public enum QueryType
    {
        Query = 1,
        NonQuery = 0
    }
}
