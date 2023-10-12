using KroellsManagement.Classes.Model.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.JSInterop;
using System.Data;
using System.Globalization;

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
				command.Parameters.AddWithValue("@Username", username); 
				command.Parameters.AddWithValue("@Password", password); 

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
		/// This method applies the changes made to the data, to the database.
		/// </summary>
		internal void ApplyChanges(string[] content, string table, IJSRuntime runtime)
		{
			var config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();

			var conn = config.GetConnectionString("AdminConnection");

			using (SqlConnection connection = new SqlConnection(conn))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand($"dbo.UPDATE{table}", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
                        switch (table)
                        {
                            case "ACCOUNTS":
                                command.Parameters.AddWithValue("@ACCOUNT_ID", content[0]);
                                command.Parameters.AddWithValue("@BALANCE", content[1]);
                                command.Parameters.AddWithValue("@CARD_ID", content[2]);
								Console.WriteLine($"account {content[0]} balance {content[1]} card {content[2]}");
                                break;
                            case "ADDRESSES":
                                command.Parameters.AddWithValue("@ADDRESS_ID", content[0]);
                                command.Parameters.AddWithValue("@ZIP_CODE", content[1]);
                                command.Parameters.AddWithValue("@CITY", content[2]);
                                command.Parameters.AddWithValue("@STREET", content[3]);
                                command.Parameters.AddWithValue("@HOUSE_NR", content[4]);
                                break;
                            case "CARDS":
                                command.Parameters.AddWithValue("@CARD_ID", content[0]);
                                command.Parameters.AddWithValue("@CARD_NR", content[1]);
                                command.Parameters.AddWithValue("@EXPIRE_DATE", DateTime.ParseExact(content[2], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None));
							command.Parameters.AddWithValue("@CVV", content[3]);
                                command.Parameters.AddWithValue("@CLIENT_NAME", content[4]);
                                command.Parameters.AddWithValue("@PIN", content[5]);
                                command.Parameters.AddWithValue("@SPENDING_LIMIT", content[6]);
                                break;
                            case "CLIENTS":
                                command.Parameters.AddWithValue("@CLIENT_ID", content[0]);
                                command.Parameters.AddWithValue("@CLIENT_NAME", content[1]);
                                command.Parameters.AddWithValue("@USERNAME", content[2]);
                                command.Parameters.AddWithValue("@PASSWORDHASHED", content[3]);
                                break;
                            case "CPRS":
                                command.Parameters.AddWithValue("@CPR_ID", content[0]);
                                command.Parameters.AddWithValue("@CLIENT_ID", content[1]);
                                command.Parameters.AddWithValue("@ADDRESS_ID", content[2]);
                                command.Parameters.AddWithValue("@EMPLOYEE_ID", content[3]);
                                command.Parameters.AddWithValue("@CPR_NR", content[4]);
                                break;
                            case "EMPLOYEES":
                                command.Parameters.AddWithValue("@EMPLOYEE_ID", content[0]);
                                command.Parameters.AddWithValue("@POSITION", content[1]);
                                command.Parameters.AddWithValue("@USERNAME", content[2]);
                                command.Parameters.AddWithValue("@PASSWORDHASHED", content[3]);
                                break;
                            case "JOBS":
								command.Parameters.AddWithValue("@JOB_ID", content[0]);
								command.Parameters.AddWithValue("@INCOME", content[1]);
								command.Parameters.AddWithValue("@JOB_NAME", content[2]);
							break;
                            case "LOANS":
                                command.Parameters.AddWithValue("@LOAN_ID", content[0]);
                                command.Parameters.AddWithValue("@CLIENT_ID", content[1]);
								command.Parameters.AddWithValue("@APR", content[2]);
                                command.Parameters.AddWithValue("@AMOUNT", content[3]);
                                break;
                            case "TRANSACTIONS":
                                command.Parameters.AddWithValue("@TRANSACTION_ID", content[0]);
                                command.Parameters.AddWithValue("@AMOUNT", content[1]);
                                command.Parameters.AddWithValue("@DATE_TIME", DateTime.ParseExact(content[2], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None));
                                command.Parameters.AddWithValue("@ACCOUNT_ID", content[3]);
                                break;

						default:
                                break;
                        }
					try
					{
						command.ExecuteNonQuery();
					} catch 
					{
						Admin admin = new Admin();
						admin.ShowError(runtime);
						// Our Backup
						// Console.WriteLine("Try again bitch");
                    }
                }
			}
		}
	}
}
