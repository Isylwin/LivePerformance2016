using System.Collections.Generic;
using System.Data;
using System.Linq;
using LP2016Database.Models;
using LP2016Lib.Classes;
using Oracle.ManagedDataAccess.Client;

namespace LP2016Database.Context
{
    public class SaveSqlContext : ISaveContext
    {
        public void SaveRenter(Renter renter)
        {
            const string query = "INSERT INTO RENTER(Name, Email) VALUES(:name, :email)";

            var parameters = new Dictionary<string, object> {{":name", renter.Name}, {":email", renter.Email}};

            Database.Instance.ExecuteQuery(query, parameters, QueryType.NonQuery);
        }

        public void SaveContract(Contract contract)
        {
            const string spName = "SaveContract";

            //Grabs all the articles from the items and gets the id's into an array.
            var articles = contract.Items.FindAll(x => x is Article).Select(x => x.Id).ToArray();
            //Fills an array with the length of the articles array with the number 4.
            var articlesBind = Enumerable.Repeat(4, articles.Length).ToArray();

            var boats = contract.Items.FindAll(x => x is Boat).Select(x => x.Id).ToArray();
            var boatsBind = Enumerable.Repeat(4, boats.Length).ToArray();

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_renterId", contract.Renter.Id)
                {
                    Direction = ParameterDirection.Input
                },
                new OracleParameter("p_startDate", contract.StartDate.ToShortDateString())
                {
                    Direction = ParameterDirection.Input
                },
                new OracleParameter("p_endDate", contract.EndDate.ToShortDateString())
                {
                    Direction = ParameterDirection.Input
                },
                new OracleParameter("p_articles", articles)
                {
                    //Don't ask why, its Oracle!
                    Direction = ParameterDirection.Input,
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    ArrayBindSize = articlesBind,
                    Size = articles.Length
                },
                new OracleParameter("p_boats", boats)
                {
                    Direction = ParameterDirection.Input,
                    CollectionType = OracleCollectionType.PLSQLAssociativeArray,
                    ArrayBindSize = boatsBind,
                    Size = boats.Length
                }
            };

            Database.Instance.ExecuteStoredProcedure(spName, parameters);
        }
    }
}
