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
		private protected string username;
		private protected string password;

		internal string Username
		{
			get { return username; }
			set { username = value; }
		}

		internal string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// This method will talk to the database /CreateTable\ Procedure and insert a new row inside the table we have choosen
		/// </summary>
		internal void CreateTable(string tableName)
		{
			var config = new ConfigurationBuilder()
			   .AddJsonFile("appsettings.json")
			   .Build();

			var conn = config.GetConnectionString("AdminConnection");

			using (SqlConnection connection = new SqlConnection(conn))
			{
				connection.Open();

				using (SqlCommand cmd = new SqlCommand("dbo.CREATETABLE", connection))
				{
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the table name parameter
                    cmd.Parameters.AddWithValue("@TABLENAME", tableName);

					cmd.ExecuteNonQuery();
                }
			}

		}

		internal List<string[]> GetTable(string table)
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
					command.Parameters.AddWithValue("@TableName", table);

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

		internal void DeleteData(string cellContent, string tableName)
		{
			var config = new ConfigurationBuilder()
			   .AddJsonFile("appsettings.json")
			   .Build();

			var conn = config.GetConnectionString("AdminConnection");

			using (SqlConnection connection = new SqlConnection(conn))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand("dbo.DeleteTableData", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@TableName", tableName);
					command.Parameters.AddWithValue("@ID", cellContent);

					command.ExecuteNonQuery();
				}
			}
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
				command.Parameters.AddWithValue("@Username", username); // Replace with your username
				command.Parameters.AddWithValue("@Password", password); // Replace with your password

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
		internal void ApplyChanges(string table)
		{
			var config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();

			var conn = config.GetConnectionString("AdminConnection");

			using (SqlConnection connection = new SqlConnection(conn))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand($"dbo.UPDATE{table.ToUpper()}", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					
				}
			}
		}
	}
}
