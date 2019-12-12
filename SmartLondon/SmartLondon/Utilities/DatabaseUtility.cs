﻿using System;
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
                    getSummary = reader.GetDouble(0).ToString();

                }
            }
            connection.Close();

            return getSummary;
        }

        //Stored Procedure 4 => GetSafety
        public string GetSafety(string lad)
        {
            return GetSummary(lad, "GetSafety");
        }

        //Stored Procedure 5 => GetSchools
        public string GetSchools(string lad)
        {
            return GetSummary(lad, "GetSchools");
        }

        //Stored Procedure 6 => GetGreenSpace
        public string GetGreenSpace(string lad)
        {
            return GetSummary(lad, "GetGreenSpace");
        }

        //Stored Procedure 7 => GetRentPerMonth
        public string GetRentPerMonth(string lad)
        {
            return GetSummary(lad, "GetRentPerMonth");
        }

        //Stored Procedure 8 => GetTravelInfo
        public string GetTravelInfo(string lad)
        {
            return GetSummary(lad, "GetTravelInfo");
        }

        //Stored Procedure 9 => GetGeneralDescription
        public string GetGeneralDescription(string lad)
        {
            string returnType = "string";

            return GetSummary(lad, "GetGeneralDescription", returnType);
        }
    }
}
