using KroellsManagement.Classes.Model.Properties;

namespace KroellsManagement.Classes.Controllers
{
    internal class ButtonController
	{
		internal void ButtonHandler(Button button)
		{
			// Gets the connection string from appsettings
			string connection = Environment.GetEnvironmentVariable("DatabaseConnection");

			string storedProcedure = "";

			// Switch statement to determine the correct stored procedure.
			switch (button.ButtonName)
			{
				case "Addresses":
					storedProcedure = "";
					break;
				case "Cards":
					storedProcedure = "";
					break;
				case "Clients":
					storedProcedure = "";
					break;
				case "CPRs":
					storedProcedure = "";
					break;
				case "Employees":
					storedProcedure = "";
					break;
				case "Jobs":
					storedProcedure = "";
					break;
				case "Loans":
					storedProcedure = "";
					break;
				case "Transactions":
					storedProcedure = "";
					break;
			}

			// JAVA SCRIPT TO REMOVE PREVIOUS TABLE
		}
	}
}
