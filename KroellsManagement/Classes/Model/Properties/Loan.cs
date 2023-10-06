namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object as a loan table row.
	/// </summary>
	public class Loan : TableBlueprint
	{
		private int _clientAccountId;
		private int _clientId;
		private short _apr;
		private int _amount;

		internal int ClientAccountId
		{
			get { return _clientAccountId; }
			set { _clientAccountId = value; }
		}

		internal int ClientId
		{
			get { return _clientId; }
			set { _clientId = value; }
		}

		internal short Apr
		{
			get { return _apr; }
			set { _apr = value; }
		}

		internal int Amount
		{
			get { return _amount; }
			set { _amount = value; }
		}
	}
}
