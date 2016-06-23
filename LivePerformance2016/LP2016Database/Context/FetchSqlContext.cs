using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using LP2016Database.Models;
using LP2016Lib.Classes;
using LP2016Lib.Enums;
using LP2016Lib.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace LP2016Database.Context
{
    public class FetchSqlContext : IFetchContext
    {
        public List<Renter> GetAllRenters()
        {
            const string spName = "GetAllRenters";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Renter>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var email = reader.GetString(2);

                    ret.Add(new Renter(id, name, email));
                }
            }

            return ret;
        }

        public List<Contract> GetAllContracts()
        {
            const string spName = "GetAllContracts";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Contract>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var renterId = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var email = reader.GetString(2);
                    var renter = new Renter(renterId, name, email);
                    var id = reader.GetInt32(3);
                    var startDate = DateTime.ParseExact(reader.GetString(4), "dd-M-yyyy", CultureInfo.InvariantCulture);
                    var endDate = DateTime.ParseExact(reader.GetString(5), "dd-M-yyyy", CultureInfo.InvariantCulture);
                    var items = new List<IRentable>();
                    items.AddRange(GetBoatsFor(id));
                    items.AddRange(GetArticlesFor(id));

                    ret.Add(new Contract(id, startDate, endDate, renter, items));
                }
            }
            return ret;
        }

        public List<Boat> GetBoatsFor(int contractId)
        {
            const string spName = "GetBoatsFor";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_contractId", contractId) {Direction = ParameterDirection.Input},
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Boat>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    //TODO fix with more dynamic creation.
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var boatTypeId = reader.GetInt32(2);
                    var type = (BoatType)Enum.Parse(typeof(BoatType), reader.GetString(3));
                    var boatClass = reader.GetString(4);
                    var price = reader.GetDecimal(5);
                    var tank = !reader.IsDBNull(6) ? reader.GetInt32(6) : 0;
                    var allowedIn = GetWaterFor(boatTypeId);

                    if(boatClass == "Muscleboat")
                        ret.Add(new MuscleBoat(id, name, price, type, allowedIn));
                    else
                        ret.Add(new MotorBoat(id, name, price, type, tank, allowedIn));
                }
            }

            return ret;
        }

        public List<Water> GetWaterFor(int boatTypeId)
        {
            const string spName = "GetWaterFor";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_contractId", boatTypeId) {Direction = ParameterDirection.Input},
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Water>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetDecimal(2);
                    var limit = !reader.IsDBNull(3) ? reader.GetInt32(3) : -1;
                    var priceExtra = !reader.IsDBNull(4) ? reader.GetDecimal(4) : 0;
                    var type = (WaterType) Enum.Parse(typeof (WaterType), reader.GetString(5));

                    ret.Add(new Water(id, name, price, type, limit, priceExtra));
                }
            }

            return ret;
        }

        public List<Article> GetArticlesFor(int contractId)
        {
            const string spName = "GetArticlesFor";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_contractId", contractId) {Direction = ParameterDirection.Input},
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Article>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetDecimal(2);

                    ret.Add(new Article(id, name, price));
                }
            }
            return ret;
        }

        public List<Boat> GetAllBoats()
        {
            const string spName = "GetAllBoats";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Boat>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var boatTypeId = reader.GetInt32(2);
                    var type = (BoatType)Enum.Parse(typeof(BoatType), reader.GetString(3));
                    var boatClass = reader.GetString(4);
                    var price = reader.GetDecimal(5);
                    var tank = !reader.IsDBNull(6) ? reader.GetInt32(6) : 0;
                    var allowedIn = GetWaterFor(boatTypeId);

                    if (boatClass == "Muscleboat")
                        ret.Add(new MuscleBoat(id, name, price, type, allowedIn));
                    else
                        ret.Add(new MotorBoat(id, name, price, type, tank, allowedIn));

                }
            }

            return ret;
        }

        public List<Article> GetAllArticles()
        {
            const string spName = "GetAllArticles";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Article>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetDecimal(2);

                    ret.Add(new Article(id, name, price));
                }
            }
            return ret;
        }

        public List<Water> GetAllWaters()
        {
            const string spName = "GetAllRenters";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("p_ret", OracleDbType.RefCursor) {Direction = ParameterDirection.Output}
            };

            var ret = new List<Water>();

            using (var reader = Database.Instance.ExecuteStoredProcedure(spName, parameters, QueryType.Query))
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    var price = reader.GetDecimal(2);
                    var limit = reader.IsDBNull(3) ? reader.GetInt32(3) : -1;
                    var priceExtra = reader.IsDBNull(4) ? reader.GetDecimal(4) : 0;
                    var type = (WaterType)Enum.Parse(typeof(WaterType), reader.GetString(5));

                    ret.Add(new Water(id, name, price, type, limit, priceExtra));
                }
            }
            return ret;
        }
    }
}
