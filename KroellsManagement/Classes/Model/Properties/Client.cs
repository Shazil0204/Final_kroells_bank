namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object of a clients table row.
	/// </summary>
	public class Client
	{
		private int _clientId;
		private string _clientName;
		private string _Username;
		private string _Password;

		internal int ClientId
		{
			get { return _clientId; }
			set { _clientId = value; }
		}

		internal string ClientName
		{
			get { return _clientName; }
			set { _clientName = value; }
		}

		internal string Username
		{
			get { return _Username; }
			set { _Username = value; }
		}

		internal string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}
	}
}
