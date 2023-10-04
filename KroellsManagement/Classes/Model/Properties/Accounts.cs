namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents one row in the accounts table, inside the database, as an object
	/// </summary>
	public class Accounts
	{
		private int _accountId;
		private int _balance;
		private int _cardId;

		internal int AccountId
		{
			get { return _accountId; }
			set { _accountId = value; }
		}

		internal int Balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

		internal int CardId
		{
			get { return _cardId; }
			set { _cardId = value; }
		}
	}
}
