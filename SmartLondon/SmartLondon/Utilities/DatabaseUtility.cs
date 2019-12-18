using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SmartLondon.Models;

namespace SmartLondon.Utilities
{
    public class DatabaseUtility
    {
        private readonly string connectionStrings = "server=localhost;username=root;password=;database=smartlondon";
        public MySqlConnection connection;

        public DatabaseUtility()
        {
            this.connection = new MySqlConnection(connectionStrings);
            connection.Open();
        }

        public void GetConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        //Stored Procedure 1 => isUserExist
        public bool IsUserExist(string username)
        {
            GetConnection();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "isUserExist";
            command.Parameters.AddWithValue("username", username);

            MySqlParameter oblogin = new MySqlParameter();
            oblogin.ParameterName = "yes_no";
            oblogin.MySqlDbType = MySqlDbType.Int16;
            oblogin.Direction = ParameterDirection.Output;
            command.Parameters.Add(oblogin);
            command.ExecuteNonQuery();
            connection.Close();

            int res = Convert.ToInt32(oblogin.Value);
            if (res == 1)
                return true;

            return false;
        }

        //Stored Procedure 2 => RegisterUser
        public void RegisterUser(string userName, string email, string password)
        {
            GetConnection();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "RegisterUser";
            command.Parameters.AddWithValue("username", userName);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("password", password);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

        //Stored Procedure 3 => UserLogin
        public bool LoginUser(string userName, string password)
        {
            GetConnection();
            MySqlCommand command = new MySqlCommand("UserLogin", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("username", userName);
            command.Parameters.AddWithValue("password", password);
            MySqlParameter oblogin = new MySqlParameter();
            oblogin.ParameterName = "yes_no";
            oblogin.MySqlDbType = MySqlDbType.Int16;
            oblogin.Direction = ParameterDirection.Output;
            command.Parameters.Add(oblogin);
            command.ExecuteNonQuery();
            connection.Close();
            int res = Convert.ToInt32(oblogin.Value);
            if (res == 1)
                return true;

            return false;
        }

        //View 1 => GetLocations
        public MapViewModel GetLocations()
        {
            int i = 0;

            GetConnection();
            var mapView = new MapViewModel();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM GetLocations";
            MySqlDataReader dr = command.ExecuteReader();

            string[] locations = new string[33];
            string[] lads = new string[33];

            while (dr.Read())
            {
                locations[i] = dr["coordinates"].ToString();
                lads[i] = dr["lad"].ToString();
                i++;
            }

            mapView.Locations = locations;
            mapView.Lad = lads;

            return mapView;
        }

        private string GetSummary(string lad, string procedureName, string returnType = "double")
        {
            GetConnection();
            string getSummary = "";

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Parameters.AddWithValue("lad", lad);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (returnType == "string")
                    {
                        getSummary = reader.GetString(0);
                        break;
                    }
                    var summaryArr = reader.GetDouble(0).ToString().Split('.');
                    getSummary = summaryArr[0] + "." + summaryArr[1].Substring(0, 2);
                }
            }
            connection.Close();

            return getSummary;
        }

        //Stored Procedure 4 => GetSafety
        public string GetSafety(string lad)
        {
            string procedureName = "GetSafety";
            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 5 => GetSchools
        public string GetSchools(string lad)
        {
            string procedureName = "GetSchools";
            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 6 => GetGreenSpace
        public string GetGreenSpace(string lad)
        {
            string procedureName = "GetGreenSpace";
            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 7 => GetRentPerMonth
        public string GetRentPerMonth(string lad)
        {
            string procedureName = "GetRentPerMonth";
            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 8 => GetTravelInfo
        public string GetTravelInfo(string lad)
        {
            string procedureName = "GetTravelInfo";

            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 9 => GetSchoolCount
        public string GetSchoolCount(string lad)
        {
            string returnType = "string";
            string procedureName = "GetSchoolCount";

            return GetSummary(lad, procedureName, returnType);
        }

        //Stored Procedure 10 => GetAverageTax
        public string GetAverageTax(string lad)
        {
            string procedureName = "GetAverageTax";
            return GetSummary(lad, procedureName);
        }

        //Stored Procedure 11 => AddAComment
        public void AddAComment(string lad, int userId, string content)
        {
            GetConnection();
            var geoShapeId = GetGeoShapeId(lad);
            GetConnection();
            MySqlCommand command = new MySqlCommand("AddAComment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("userId", userId);
            command.Parameters.AddWithValue("content", content);
            command.Parameters.AddWithValue("geoShapeId", geoShapeId);

            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

        //Stored Procedure 12 => GetUserId
        public int GetUserId(string username)
        {
            GetConnection();
            int userId = 0;

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Id FROM users WHERE Username=@username";
            command.Parameters.AddWithValue("@username", username);
            MySqlDataReader dr = command.ExecuteReader();

            while(dr.Read())
            {
                userId = (int)dr["Id"];
            }
            connection.Close();
            return userId;
        }

        //Stored Procedure 13 => GetGeoShapeId
        public int GetGeoShapeId(string lad)
        {
            GetConnection();
            int getId = 0;
            string procedureName = "GetGeoShapeId";

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
            command.Parameters.AddWithValue("lad", lad);

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    getId = reader.GetInt16(0);
                }
            }
            connection.Close();

            return getId;
        }

        public Comments GetCommentsByDistrictName(string lad)
        {
            GetConnection();

            MySqlCommand command = new MySqlCommand();
            var commentDetail = new Comments() { Content = new List<string>(), Username = new List<string>()};
            command.Connection = connection;
            command.CommandText = "SELECT c.Content, u.Username FROM comments c inner join geoshape g on c.GeoShapeId = g.id inner join users u on u.Id = c.UserId WHERE g.lad=@lad";
            command.Parameters.AddWithValue("@lad", lad);
            MySqlDataReader dr = command.ExecuteReader();

            while(dr.Read())
            {
                commentDetail.Username.Add(dr["Username"].ToString());
                commentDetail.Content.Add(dr["Content"].ToString());
            }
            connection.Close();
            return commentDetail;
        }
    }
}