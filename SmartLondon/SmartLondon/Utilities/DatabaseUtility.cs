using System;
using System.Data;
using MySql.Data.MySqlClient;

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
    }
}
