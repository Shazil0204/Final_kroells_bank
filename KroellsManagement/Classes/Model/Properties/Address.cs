namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object as a row in the Addresses table, from the database
	/// </summary>
	public class Address
	{
		private int _addressId;
		private int _zipCode;
		private string _city;
		private string _street;
		private int _houseNr;

		internal int AddressId
		{
			get { return _addressId; }
			set { _addressId = value; }
		}

		internal int ZipCode
		{
			get { return _zipCode; }
			set { _zipCode = value; }
		}

		internal int HouseNr
		{
			get { return _houseNr; }
			set { _houseNr = value; }
		}

		internal string City
		{
			get { return _city; }
			set { _city = value; }
		}

		internal string Street
		{
			get { return _street; }
			set { _street = value; }
		}
	}
}
