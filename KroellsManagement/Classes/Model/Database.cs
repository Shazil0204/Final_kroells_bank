using KroellsManagement.Classes.Model.Properties;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KroellsManagement.Classes.Model
{
    /// <summary>
    /// This class has database connections and is responsible for all handling of data through the database.
    /// </summary>
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

        internal List<string[]> GetTable(Button button)
        {

            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            var conn = config.GetConnectionString("AdminConnection");

			using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("dbo.GetTableData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TableName", button.ButtonName);

                    List<string[]> rows = new List<string[]>();

                    rows.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string[] row = new string[reader.FieldCount];

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader[i].ToString();
                                }

                                rows.Add(row);
                            }
                        }
                        return rows;
                    }
                }
            }
        }

        //for now on i am just giving this a void but i will change it later
        internal void DeleteData() 
        {
            
        }

        internal async Task<sbyte> DBConnection()
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
                        return 1;
                    case 0:
                        return 0;
                    case -1:
                        return -1;
                    default:
                        return -2;
                }
            }
        }

        /// <summary>
        /// This deletes the currently selected row.
        /// </summary>
        internal void DeleteRow()
        {

        }

        /// <summary>
        /// This creates a new row in the table.
        /// </summary>
        internal void CreateRow()
        {

        }

        /// <summary>
        /// This method applies the changes made to the data, to the database.
        /// </summary>
        internal void ApplyChanges()
        {

        }
    }
}
