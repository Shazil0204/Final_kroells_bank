namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object as a row in the Employee table in the database
	/// </summary>
	public class Employee
	{
		private int _employeeId;
		private string _position;
		private string _username;
		private string _password;

		internal int EmployeeId
		{
			get { return _employeeId; }
			set { _employeeId = value; }
		}

		internal string Position
		{
			get { return _position; }
			set { _position = value; }
		}

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
	}
}
