namespace KroellsManagement.Classes.Model.Properties
{
	public class Login
	{
		private string _username;
		private string _password;

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
