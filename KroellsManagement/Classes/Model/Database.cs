using Microsoft.Data.SqlClient;
using System.Data;

namespace KroellsManagement.Classes.Model
{
	/// <summary>
	/// This class has database connections and is responsible for all handling of data through the database.
	/// </summary>
	internal class Database
	{
		//
		internal void GetTable(string connStr, string storedProcedure)
		{
			using (SqlConnection connection = new SqlConnection(connStr))
			{
				connection.Open();

				using (SqlCommand command = new SqlCommand(storedProcedure, connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					using (SqlDataReader read = command.ExecuteReader())
					{
						while(read.Read())
						{
							// 
						}
					}
				}
			}
		}
	}
}
