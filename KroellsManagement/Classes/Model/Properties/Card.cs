namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents one row in the cards table, as an object.
	/// </summary>
	public class Card
	{
		private int _cardId;
		private int _cardNumber;
		private string _expirationDate;
		private short _cvv;
		private string _clientName;
		private short _pin;
		private int _spendingLimit;

		internal int CardId
		{
			get { return _cardId; }
			set { _cardId = value; }
		}

		internal int CardNumber
		{
			get { return _cardNumber; }
			set { _cardNumber = value; }
		}

		internal int SpendingLimit
		{
			get { return _spendingLimit; }
			set { _spendingLimit = value; }
		}

		internal string ExpirationDate
		{
			get { return _expirationDate; }
			set { _expirationDate = value; }
		}

		internal string ClientName
		{
			get { return _clientName; }
			set { _clientName = value; }
		}

		internal short CVV
		{
			get { return _cvv; }
			set { _cvv = value; }
		}

		internal short Pin
		{
			get { return _pin; }
			set { _pin = value; }
		}
	}
}
