namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents one row inside the Transactions table, as an object
	/// </summary>
	public class Transaction : TableBlueprint
	{
		private int _transactionId;
		private int _amount;
		private DateTime _dateTime;
		private int _accountId;

		internal int TransactionId
		{
			get { return _transactionId; }
			set { _transactionId = value; }
		}

		internal int Amount 
		{ 
			get { return _amount; } 
			set {  _amount = value; } 
		}

		internal DateTime DateTime
		{
			get { return _dateTime; }
			set { _dateTime = value; }
		}

		internal int AccountId
		{
			get { return _accountId; }
			set { _accountId = value; }
		}
	}
}
