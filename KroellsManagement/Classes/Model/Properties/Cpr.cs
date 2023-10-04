namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object from the CPRs table row.
	/// </summary>
	public class Cpr
	{
		private int _cprId;
		private int _clientId;
		private int _addressId;
		private int _EmployeeId;
		private int _cprNr;

		internal int CprId
		{
			get { return _cprId; }
			set { _cprId = value; }
		}

		internal int ClientId
		{
			get { return _clientId; }
			set { _clientId = value; }
		}

		internal int AddressId
		{
			get { return _addressId; }
			set { _addressId = value; }
		}

		internal int EmployeeId
		{
			get { return _EmployeeId; }
			set { _EmployeeId = value; }
		}

		internal int CprNr
		{
			get { return  _cprNr; }
			set { _cprNr = value; }
		}
	}
}
