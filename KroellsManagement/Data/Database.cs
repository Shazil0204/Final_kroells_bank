using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace KroellsManagement.Data
{
    internal class Database
    {

        private protected string _username;
        private protected string _password;

        internal string Username 
        {
            get { return _username; }
            set { _username = value; }
        }
        
        internal string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        internal async Task<bool> DBConnection()
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            var conn = config.GetConnectionString("DefaultConnection");

            SqlConnection sqlcon = new SqlConnection(conn);

            sqlcon.Open();

            using (SqlCommand command = new SqlCommand("CheckEmployeeLogin", sqlcon))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Input parameters
                command.Parameters.AddWithValue("@Username", _username); // Replace with your username
                command.Parameters.AddWithValue("@Password", _password); // Replace with your password

                // Output parameter for result
                SqlParameter resultParameter = command.Parameters.Add("@Result", SqlDbType.Int);
                resultParameter.Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                int resultCode = (int)resultParameter.Value;

                switch (resultCode)
                {
                    case 1:
                        return true;
                    case 0:
                        return false;
                    case -1:
                        return false;
                    default:
                        return false;
                }
            }
        }
    }
}
