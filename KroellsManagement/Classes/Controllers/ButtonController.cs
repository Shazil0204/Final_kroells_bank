using KroellsManagement.Classes.Model.Properties;
using Microsoft.JSInterop;

namespace KroellsManagement.Classes.Controllers
{
    internal class ButtonController
	{
		private IJSRuntime _runtime;

		internal void TableHandler(Button button, bool edit)
		{
			// Gets the connection string from appsettings
			string connection = Environment.GetEnvironmentVariable("DatabaseConnection");

			string storedProcedure = "";

			// Switch statement to determine the correct stored procedure.
			switch (button.ButtonName)
			{
				case "Addresses":
					// JAVASCRIPT TO CREATE HEADER AND FOOTER, IN THE CORRECT LOCATION
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

			// RETURN TABLE FROM THE Database CLASS.

			// JAVA SCRIPT TO OUTPUT DATA AS TABLE IN HTML
		}

		internal bool EditLock(bool currentState)
		{
			currentState = !currentState;
			return currentState;
		}

		internal void Delete()
		{

		}
	}
}
